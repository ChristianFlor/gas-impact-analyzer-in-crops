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
        private Kmeans algorithm;

        public DataManager()
        {
            measurements = new List<Measurement>();
            harvested = new List<CropMeasurement>();
            planted = new List<CropMeasurement>();
            readInfo(airQualityRepository, airQualityId);
            List<string> list = new List<String>
            {
                "Nombre del municipio"
            };
            string[] values = new string[1];
            values[0] = "BUENAVENTURA"; query(list, values, "measurements");
            values[0] = "GUADALAJARA%20DE%20BUGA"; query(list, values, "measurements");
            values[0] = "CALI"; query(list, values, "measurements");
            values[0] = "CANDELARIA"; query(list, values, "measurements");
            values[0] = "JAMUNDÍ"; query(list, values, "measurements");
            values[0] = "PALMIRA"; query(list, values, "measurements");
            values[0] = "YUMBO"; query(list, values, "measurements");

            readInfo(harvestRepository, harvestId);
            list = new List<String>(); list.Add("Municipios");
            values[0] = "Cali"; query(list, values, "harvested");
            values[0] = "Palmira"; query(list, values, "harvested");
            values[0] = "Candelaria"; query(list, values, "harvested");
            values[0] = "Buga"; query(list, values, "harvested");
            values[0] = "Buenaventura"; query(list, values, "harvested");
            readInfo(plantedRepository, plantedId);
            list = new List<String>(); list.Add("Municipios");
            values[0] = "Cali"; query(list, values, "planted");
            values[0] = "Palmira"; query(list, values, "planted");
            values[0] = "Candelaria"; query(list, values, "planted");
            values[0] = "Buga"; query(list, values, "planted");
            values[0] = "Buenaventura"; query(list, values, "planted");
            /*
            list.Add("Departamento");
            values[0] = "VALLE%20DEL%20CAUCA"; query(list, values, "measurements");
            */

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
        public void initializeKmeans(string crop)
        {
            
            double[][] data = new double[harvested.Count][];
            for (int i = 0; i < harvested.Count; i++)
            {
                data[i] = new double[] { measurements[i].Concentration, harvested[i].getTypeCrop(crop)};

            }
            algorithm = new Kmeans(data, 5);
        }
        public void addDataJustToTest_DeleteItAndAdaptTheChartToTheRealSituationAfterSeeingThisWorking()
        {
            Random r = new Random();
            for (int i = 2011; i <= 2017; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    measurements.Add(new Measurement(r.Next(28) + "/" + j + "/" + i, "autoridad", "station" + i, "tech" + i, 1, 2, "123", "VALLE DEL CAUCA", "mucicipiocode", "Buenaventura", "tipo", 123, "CO2", "unit", r.NextDouble() * (100.0 * Math.PI)));
                    measurements.Add(new Measurement(r.Next(28) + "/" + j + "/" + i, "autoridad", "station" + i, "tech" + i, 1, 2, "123", "VALLE DEL CAUCA", "mucicipiocode", "Buga", "tipo", 123, "CO2", "unit", r.NextDouble() * (100.0 * Math.PI)));
                    measurements.Add(new Measurement(r.Next(28) + "/" + j + "/" + i, "autoridad", "station" + i, "tech" + i, 1, 2, "123", "VALLE DEL CAUCA", "mucicipiocode", "Cali-Cascajal", "tipo", 123, "CO2", "unit", r.NextDouble() * (100.0 * Math.PI)));
                    measurements.Add(new Measurement(r.Next(28) + "/" + j + "/" + i, "autoridad", "station" + i, "tech" + i, 1, 2, "123", "VALLE DEL CAUCA", "mucicipiocode", "Candelaria", "tipo", 123, "CO2", "unit", r.NextDouble() * (100.0 * Math.PI)));
                    measurements.Add(new Measurement(r.Next(28) + "/" + j + "/" + i, "autoridad", "station" + i, "tech" + i, 1, 2, "123", "VALLE DEL CAUCA", "mucicipiocode", "Jamundí", "tipo", 123, "CO2", "unit", r.NextDouble() * (100.0 * Math.PI)));
                }
            }
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
                    string s = r.Replace("\n", "").Replace("\"", "");
                   // Console.WriteLine(s);
                    if (s.Length > 10)
                    {
                        string[] attrs = s.Substring(1).Split(',');
                        string date = attrs[0].Split(' ')[0].Split(':')[1];
                        string authority = attrs[1].Split(':')[1];
                        string stationName = attrs[2].Split(':')[1];
                        string technology = attrs[3].Split(':')[1];
                        double latitude = ParseDouble(attrs[4].Split(':')[1]);
                        double longitude = ParseDouble(attrs[5].Split(':')[1]); ;
                        string departmentCode = attrs[6].Split(':')[1];
                        string department = attrs[7].Split(':')[1];
                        string municipalityCode = attrs[8].Split(':')[1];
                        string municipality = attrs[9].Split(':')[1];
                        string stationType = attrs[10].Split(':')[1];
                        double exhibitionTime = ParseDouble(attrs[11].Split(':')[1]);
                        string variable = attrs[12].Split(':')[1];
                        string unit = attrs[13].Split(':')[1];
                        double concentration = ParseDouble(attrs[14].Split(':')[1]);
                        Measurement m = new Measurement(date, authority, stationName, technology, latitude, longitude, departmentCode, department, municipalityCode, municipality, stationType, exhibitionTime, variable, unit, concentration);
                        measurements.Add(m);
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
            else
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                CropMeasurement[] data = js.Deserialize<CropMeasurement[]>(rawData);
                foreach (CropMeasurement m in data)
                {
                    planted.Add(m);
                }
            }
        }
      
        public List<Measurement> getClusterMeasurementByID(int id)
        {
            List<Measurement> cluster = new List<Measurement>();
            int[] idCluster = algorithm.getClusteringID();
            for(int i=0;i<idCluster.Length;i++){
                if (idCluster[i] == id) cluster.Add(measurements[i]);
            }
            return cluster;
        }
        public List<CropMeasurement> getClusterCropsByID(int id)
        {
            List<CropMeasurement> cluster = new List<CropMeasurement>();
            int[] idCluster = algorithm.getClusteringID();
            for (int i = 0; i < idCluster.Length; i++)
            {
                if (idCluster[i] == id) cluster.Add(harvested[i]);
            }
            return cluster;
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

        public static double ParseDouble(string num)
        {
            string[] intDec = num.Split('.');
            double dnum = double.Parse(intDec[0]);
            if (intDec.Length == 2)
            {
                dnum += double.Parse(intDec[1]) / Math.Pow(10, intDec[1].Length);
            }
            return dnum;
        }
    }
}
