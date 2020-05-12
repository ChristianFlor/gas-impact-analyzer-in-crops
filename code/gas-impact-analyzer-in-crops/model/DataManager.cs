using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static int[] Cluster(double[][] rawData, int numClusters)
        {
            double[][] data = Normalized(rawData);
            bool changed = true; bool success = true;
            int[] clustering = InitClustering(data.Length, numClusters, 0);
            double[][] means = Allocate(numClusters, data[0].Length);
            int maxCount = data.Length * 10;
            int ct = 0;
            while (changed == true && success == true && ct < maxCount)
            {
                ++ct;
                success = UpdateMeans(data, clustering, means);
                changed = UpdateClustering(data, clustering, means);
            }
            return clustering;
        }
        private static double[][] Normalized(double[][] rawData)
        {
            double[][] result = new double[rawData.Length][];
            for (int i = 0; i < rawData.Length; ++i)
            {
                result[i] = new double[rawData[i].Length];
                Array.Copy(rawData[i], result[i], rawData[i].Length);
            }

            for (int j = 0; j < result[0].Length; ++j)
            {
                double colSum = 0.0;
                for (int i = 0; i < result.Length; ++i)
                    colSum += result[i][j];
                double mean = colSum / result.Length;
                double sum = 0.0;
                for (int i = 0; i < result.Length; ++i)
                    sum += (result[i][j] - mean) * (result[i][j] - mean);
                double sd = sum / result.Length;
                for (int i = 0; i < result.Length; ++i)
                    result[i][j] = (result[i][j] - mean) / sd;
            }
            return result;
        }
        private static int[] InitClustering(int numTuples, int numClusters, int seed)
        {
            Random random = new Random(seed);
            int[] clustering = new int[numTuples];
            for (int i = 0; i < numClusters; ++i)
                clustering[i] = i;
            for (int i = numClusters; i < clustering.Length; ++i)
                clustering[i] = random.Next(0, numClusters);
            return clustering;
        }
        private static bool UpdateMeans(double[][] data, int[] clustering, double[][] means)
        {
            int numClusters = means.Length;
            int[] clusterCounts = new int[numClusters];
            for (int i = 0; i < data.Length; ++i)
            {
                int cluster = clustering[i];
                ++clusterCounts[cluster];
            }

            for (int k = 0; k < numClusters; ++k)
                if (clusterCounts[k] == 0)
                    return false;

            for (int k = 0; k < means.Length; ++k)
                for (int j = 0; j < means[k].Length; ++j)
                    means[k][j] = 0.0;

            for (int i = 0; i < data.Length; ++i)
            {
                int cluster = clustering[i];
                for (int j = 0; j < data[i].Length; ++j)
                    means[cluster][j] += data[i][j]; // accumulate sum
            }

            for (int k = 0; k < means.Length; ++k)
                for (int j = 0; j < means[k].Length; ++j)
                    means[k][j] /= clusterCounts[k]; // danger of div by 0
            return true;
        }
        private static double[][] Allocate(int numClusters, int numColumns)
        {
            double[][] result = new double[numClusters][];
            for (int k = 0; k < numClusters; ++k)
                result[k] = new double[numColumns];
            return result;
        }
        private static bool UpdateClustering(double[][] data, int[] clustering, double[][] means)
        {
            int numClusters = means.Length;
            bool changed = false;

            int[] newClustering = new int[clustering.Length];
            Array.Copy(clustering, newClustering, clustering.Length);

            double[] distances = new double[numClusters];

            for (int i = 0; i < data.Length; ++i)
            {
                for (int k = 0; k < numClusters; ++k)
                    distances[k] = Distance(data[i], means[k]);

                int newClusterID = MinIndex(distances);
                if (newClusterID != newClustering[i])
                {
                    changed = true;
                    newClustering[i] = newClusterID;
                }
            }

            if (changed == false)
                return false;

            int[] clusterCounts = new int[numClusters];
            for (int i = 0; i < data.Length; ++i)
            {
                int cluster = newClustering[i];
                ++clusterCounts[cluster];
            }

            for (int k = 0; k < numClusters; ++k)
                if (clusterCounts[k] == 0)
                    return false;

            Array.Copy(newClustering, clustering, newClustering.Length);
            return true; // no zero-counts and at least one change
        }
        private static double Distance(double[] tuple, double[] mean)
        {
            double sumSquaredDiffs = 0.0;
            for (int j = 0; j < tuple.Length; ++j)
                sumSquaredDiffs += Math.Pow((tuple[j] - mean[j]), 2);
            return Math.Sqrt(sumSquaredDiffs);
        }
        private static int MinIndex(double[] distances)
        {
            int indexOfMin = 0;
            double smallDist = distances[0];
            for (int k = 0; k < distances.Length; ++k)
            {
                if (distances[k] < smallDist)
                {
                    smallDist = distances[k];
                    indexOfMin = k;
                }
            }
            return indexOfMin;
        }
        static void ShowData(double[][] data, int decimals,
          bool indices, bool newLine)
        {
            for (int i = 0; i < data.Length; ++i)
            {
                if (indices) Console.Write(i.ToString().PadLeft(3) + " ");
                for (int j = 0; j < data[i].Length; ++j)
                {
                    if (data[i][j] >= 0.0) Console.Write(" ");
                    Console.Write(data[i][j].ToString("F" + decimals) + " ");
                }
                Console.WriteLine("");
            }
            if (newLine) Console.WriteLine("");
        }

        static void ShowVector(int[] vector, bool newLine)
        {
            for (int i = 0; i < vector.Length; ++i)
                Console.Write(vector[i] + " ");
            if (newLine) Console.WriteLine("\n");
        }

        static void ShowClustered(double[][] data, int[] clustering,
          int numClusters, int decimals)
        {
            for (int k = 0; k < numClusters; ++k)
            {
                Console.WriteLine("===================");
                for (int i = 0; i < data.Length; ++i)
                {
                    int clusterID = clustering[i];
                    if (clusterID != k) continue;
                    Console.Write(i.ToString().PadLeft(3) + " ");
                    for (int j = 0; j < data[i].Length; ++j)
                    {
                        if (data[i][j] >= 0.0) Console.Write(" ");
                        Console.Write(data[i][j].ToString("F" + decimals) + " ");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("===================");
            } // k
        }
    }
}
t