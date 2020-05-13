using SODA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace model
{   
    public class DataManager
    {
        private const string airQualityRepository = "https://www.datos.gov.co";
        private const string airQualityId = "ysq6-ri4e";
        private const string harvestRepository = "https://www.datos.gov.co";
        private const string harvestId = "3d2z-wkgw";
        private const string plantedRepository = "https://www.datos.gov.co";
        private const string plantedId = "vs5v-e66i";
        private string url;
        private List<Measurement> measurements;
        private List<CropMeasurement> harvested;
        private List<CropMeasurement> planted;
        private Dictionary<string, string> columnDeserialize;

        public DataManager() { 
            measurements = new List<Measurement>();
            harvested = new List<CropMeasurement>();
            planted = new List<CropMeasurement>();
            readInfo(airQualityRepository, airQualityId);
            List<string> list = new List<String>();
            list.Add("Nombre del municipio");
            string[] values = new string[1];
            values[0] = "BUENAVENTURA"; query(list, values, "measurements");
            values[0] = "GUADALAJARA%20DE%20BUGA"; query(list, values, "measurements");
            values[0] = "CALI"; query(list, values, "measurements");
            values[0] = "CANDELARIA"; query(list, values, "measurements");
            values[0] = "JAMUNDÍ"; query(list, values, "measurements");
            values[0] = "PALMIRA"; query(list, values, "measurements");
            /*
            readInfo(harvestRepository, harvestId);
            list = new List<String>(); list.Add("municipios");
            values[0] = "Cali"; query(list, values, "harvested");
            values[0] = "Palmira"; query(list, values, "harvested");
            values[0] = "Candelaria"; query(list, values, "harvested");
            values[0] = "Buga"; query(list, values, "harvested");
            values[0] = "Buenaventura"; query(list, values, "harvested");
            readInfo(plantedRepository, plantedId);
            list = new List<String>(); list.Add("municipios");
            values[0] = "Cali"; query(list, values, "planted");
            values[0] = "Palmira"; query(list, values, "planted");
            values[0] = "Candelaria"; query(list, values, "planted");
            values[0] = "Buga"; query(list, values, "planted");
            values[0] = "Buenaventura"; query(list, values, "planted");
            */
        }

        private void readInfo(string repositoryUrl, string datasetId)
        {
            columnDeserialize = new Dictionary<string, string>();
            url = repositoryUrl + "/resource/" + datasetId + ".json?";
            var client = new SodaClient(repositoryUrl, "zzanGqreT6bAIRPuvhwn9yso3");
            var dataset = client.GetResource<Object>(datasetId);
            foreach (var c in dataset.Columns)
            {
                columnDeserialize.Add(c.Name, c.SodaFieldName);
            }
        }

        private void query(List<string> list, string[] values, string type)
        {
            string url2 = url;
            string str;

            for (int i = 0; i < list.Count; i++)
            {

                str = columnDeserialize[list[i].ToString()] + "=" + values[i] + "&";
                url2 += str;

            }

            string rawData = new WebClient().DownloadString(url2);
            Console.WriteLine(url2);
            if (type.Equals("measurements"))
            {
                string[] regs = rawData.Substring(1, rawData.Length - 2).Split('}');
                foreach (string r in regs)
                {
                    string s = r.Replace("\n", "").Replace("\"", ""); ;
                    if (s.Length > 10)
                    {
                        string[] attrs = s.Substring(1).Split(',');
                        string date = attrs[0].Split(' ')[0].Split(':')[1];
                        string authority = attrs[1].Split(':')[1];
                        string stationName = attrs[2].Split(':')[1];
                        string technology = attrs[3].Split(':')[1];
                        string[] num = attrs[4].Split(':')[1].Split('.');
                        double latitude = double.Parse(num[0]);
                        if (num.Length == 2)
                        {
                            latitude += double.Parse(num[1]) / Math.Pow(10, num[1].Length);
                        }
                        num = attrs[5].Split(':')[1].Split('.');
                        double longitude = double.Parse(num[0]);
                        if (num.Length == 2)
                        {
                            longitude += double.Parse(num[1]) / Math.Pow(10, num[1].Length);
                        }
                        string departmentCode = attrs[6].Split(':')[1];
                        string department = attrs[7].Split(':')[1];
                        string municipalityCode = attrs[8].Split(':')[1];
                        string municipality = attrs[9].Split(':')[1];
                        string stationType = attrs[10].Split(':')[1];
                        double exhibitionTime = Double.Parse(attrs[11].Split(':')[1]);
                        string variable = attrs[12].Split(':')[1];
                        string unit = attrs[13].Split(':')[1];
                        num = attrs[14].Split(':')[1].Split('.');
                        double concentration = double.Parse(num[0]);
                        if (num.Length == 2)
                        {
                            concentration += double.Parse(num[1]) / Math.Pow(10, num[1].Length);
                        }
                        if (variable.Contains("PM2"))
                        {
                            Console.WriteLine(variable);
                        }
                        Measurement m = new Measurement(date, authority, stationName, technology, latitude, longitude, departmentCode, department, municipalityCode, municipality, stationType, exhibitionTime, variable, unit, concentration);
                        measurements.Add(m);
                        if (department.ToLower().Contains("valle") && variable.ToLower().Equals("NO2"))
                        {
                            Console.WriteLine("yes");
                        }
                    }
                }
            }
            else if (type.Equals("harvested"))
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                CropMeasurement[] data = js.Deserialize<CropMeasurement[]>(rawData);
                foreach (CropMeasurement m in data)
                {
                    harvested.Add(m);
                }
            }
            else {
                JavaScriptSerializer js = new JavaScriptSerializer();
                CropMeasurement[] data = js.Deserialize<CropMeasurement[]>(rawData);
                foreach (CropMeasurement m in data)
                {
                    planted.Add(m);
                }
            }
        }

        public void setUrl(string url)
        {
            this.url = url;
        }

        public List<Measurement> Measurements 
        {
            get 
            {
                return measurements;
            }
        }

        public List<CropMeasurement> Harvested
        {
            get
            {
                return harvested;
            }
        }

        public List<CropMeasurement> Planted
        {
            get
            {
                return planted;
            }
        }
    }
}
