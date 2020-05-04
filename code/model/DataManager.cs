using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    class DataManager
    {
        private string url;
        private List<Measurement> measurements;
        private List<CropMeasurement> harvested;
        private List<CropMeasurement> planted;
        private Dictionary<string, string> columnDeserialize;

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
    }
}
