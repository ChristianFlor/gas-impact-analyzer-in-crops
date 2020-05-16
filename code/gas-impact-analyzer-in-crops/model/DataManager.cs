using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using SODA;
using Newtonsoft.Json;
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

        public DataManager()
        {
            measurements = new List<Measurement>();
            harvested = new List<CropMeasurement>();
            planted = new List<CropMeasurement>();
            readInfo(airQualityRepository, airQualityId);
            List<string> list = new List<String>();
            list.Add("Nombre del municipio");
            string[] values = new string[1];
            values[0] = "BUENAVENTURA"; query(list, values, "measurements");
            values[0] = "CALI"; query(list, values, "measurements");
            values[0] = "CANDELARIA"; query(list, values, "measurements");
            values[0] = "PALMIRA"; query(list, values, "measurements");
            values[0] = "GUADALAJARA DE BUGA"; query(list, values, "measurements");
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

            if (type.Equals("measurements"))
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                Measurement[] data = js.Deserialize<Measurement[]>(rawData);
                foreach (Measurement m in data)
                {
                    measurements.Add(m);
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

        public void setUrl(string url)
        {
            this.url = url;
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

        public List<Measurement> Measurements {
            get 
            {
                return measurements;
            }
            set 
            {
                measurements = value;
            }
        }
       
    }
}
