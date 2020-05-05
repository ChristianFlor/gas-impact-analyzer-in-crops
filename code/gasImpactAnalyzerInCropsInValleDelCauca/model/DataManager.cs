using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class DataManager
    {
        private string url;
        private List<Measurement> measurements;
        private List<CropMeasurement> harvested;
        private List<CropMeasurement> planted;
        private Dictionary<string, string> columnDeserialize {get; }

        public DataManager() { measurements = new List<Measurement>(); }

        public void readInfo(string repositoryUrl, string datasetId)
        {

        }

        public void query(string[] values)
        {

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
