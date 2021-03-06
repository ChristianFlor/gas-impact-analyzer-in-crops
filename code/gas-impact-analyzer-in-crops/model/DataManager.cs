﻿using SODA;
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
        private const string airQualityRepository = "https://www.Datos.gov.Co";
        private const string airQualityId = "ysq6-ri4e";
        private const string harvestRepository = "https://www.Datos.gov.Co";
        private const string harvestId = "3d2z-wkgw";
        private const string plantedRepository = "https://www.Datos.gov.Co";
        private const string plantedId = "vs5v-e66i";
        private string url;
        private List<Measurement> measurements;
        private List<CropMeasurement> harvested;
        private List<CropMeasurement> planted;
        private Dictionary<string, string> columnDeserialize;
        private Kmeans algorithm;

        public DataManager()
        {
            measurements = new List<Measurement>(1400000);
            harvested = new List<CropMeasurement>(1400000);
            planted = new List<CropMeasurement>(1400000);

        }

        public void initializeKmeans(string crop)
        {
            dataForKmeans();
            double[][] data = new double[harvested.Count][];
            for (int i = 0; i < harvested.Count; i++)
            {
                data[i] = new double[] { measurements[i].Concentration, harvested[i].getTypeCrop(crop)};

            }
            algorithm = new Kmeans(data, 5);
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
            int year = -1;
            for (int i = 0; i < list.Count; i++)
            {
                if (!list[i].Contains("$"))
                {
                    str = columnDeserialize[list[i]] + "=" + values[i] + "&";
                    url2 += str;
                }
                else {
                    year = i;
                }
            }
            url2 += "$limit=250000&";
            if (year > -1) {
                url2 += list[year] + "=" + values[year];
            }
            string rawData = new WebClient().DownloadString(url2);
            Console.WriteLine(url2);
            if (type.Equals("measurements"))
            {
                 string[] regs = rawData.Substring(1, rawData.Length - 2).Split('}');
                 foreach (string r in regs)
                 {
                     string s = r.Replace("\n", "").Replace("\"", "");
                     if (s.Length > 10)
                     {
                         try
                         {
                             string[] attrs = s.Substring(1).Split(',');
                             string date = attrs[0].Substring(7);
                             string authority = attrs[1].Split(':')[1];
                             string stationName = attrs[2].Split(':')[1];
                             string technology = attrs[3].Split(':')[1];
                             double latitude = ParseDouble(attrs[4].Split(':')[1]);
                             double longitude = ParseDouble(attrs[5].Split(':')[1]);
                             ;
                             string departmentCode = attrs[6].Split(':')[1];
                             string department = attrs[7].Split(':')[1];
                             string municipalityCode = attrs[8].Split(':')[1];
                             string municipality = attrs[9].Split(':')[1];
                             string stationType = attrs[10].Split(':')[1];
                             double exhibitionTime = ParseDouble(attrs[11].Split(':')[1]);
                             string variable = attrs[12].Split(':')[1];
                             string unit = attrs[13].Split(':')[1];
                             double concentration = ParseDouble(attrs[14].Split(':')[1]);
                             Measurement m = new Measurement(date, authority, stationName, technology, latitude,
                                 longitude,
                                 departmentCode, department, municipalityCode, municipality, stationType,
                                 exhibitionTime,
                                 variable, unit, concentration);
                             measurements.Add(m);
                         }
                         catch {

                         }
                     }
                 }
                Console.WriteLine("Measurements has " + measurements.Count() + " elements");
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

        public void dataForKmeans()
        {

            measurements.Clear();

            readInfo(airQualityRepository, airQualityId);

            List<string> list = new List<String>
            {
                "Nombre del municipio"
            };
            string[] values = new string[1];
            values[0] = "BUENAVENTURA"; query2(list, values, "measurements");
            values[0] = "GUADALAJARA%20DE%20BUGA"; query2(list, values, "measurements");
            values[0] = "CALI"; query2(list, values, "measurements");
            values[0] = "CANDELARIA"; query2(list, values, "measurements");
            values[0] = "JAMUNDÍ"; query2(list, values, "measurements");
            values[0] = "PALMIRA"; query2(list, values, "measurements");
            values[0] = "YUMBO"; query2(list, values, "measurements");

            harvested.Clear();

            readInfo(harvestRepository, harvestId);
            list = new List<String>(); list.Add("Municipios");
            values[0] = "Cali"; query2(list, values, "harvested");
            values[0] = "Palmira"; query2(list, values, "harvested");
            values[0] = "Candelaria"; query2(list, values, "harvested");
            values[0] = "Buga"; query2(list, values, "harvested");
            values[0] = "Buenaventura"; query2(list, values, "harvested");

            planted.Clear();

            readInfo(plantedRepository, plantedId);
            list = new List<String>(); list.Add("Municipios");
            values[0] = "Cali"; query2(list, values, "planted");
            values[0] = "Palmira"; query2(list, values, "planted");
            values[0] = "Candelaria"; query2(list, values, "planted");
            values[0] = "Buga"; query2(list, values, "planted");
            values[0] = "Buenaventura"; query2(list, values, "planted");

        }

        public void filterDataForAir(Dictionary<string, string> graphicQuery)
        {
            Console.WriteLine(measurements.Count()+"***");
            List<string> parametros = new List<string>();
            List<string> valores = new List<string>();

            foreach (KeyValuePair<string, string> pair in graphicQuery)
            {

                parametros.Add(pair.Key);
                valores.Add(pair.Value);

            }

            int m = valores.Count;
            string[] valores2 = new string[m];

            valores.CopyTo(valores2);

            readInfo(airQualityRepository, airQualityId);

            query(parametros, valores2, "measurements");


        }

        public void filterDataForHarvested(Dictionary<string, string> graphicQuery)
        {

            harvested.Clear();
            List<string> parametros = new List<string>();
            List<string> valores = new List<string>();

            foreach (KeyValuePair<string, string> pair in graphicQuery)
            {

                parametros.Add(pair.Key);
                valores.Add(pair.Value);

            }

            int m = valores.Count;
            string[] valores2 = new string[m];

            valores.CopyTo(valores2);

            readInfo(harvestRepository, harvestId);

            query(parametros, valores2, "harvested");


        }

        public void filterDataForPlanted(Dictionary<string, string> graphicQuery)
        {

            planted.Clear();
            List<string> parametros = new List<string>();
            List<string> valores = new List<string>();

            foreach (KeyValuePair<string, string> pair in graphicQuery)
            {

                parametros.Add(pair.Key);
                valores.Add(pair.Value);

            }

            int m = valores.Count;
            string[] valores2 = new string[m];

            valores.CopyTo(valores2);

            readInfo(plantedRepository, plantedId);

            query(parametros, valores2, "planted");


        }






        private void query2(List<string> list, string[] values, string type)
        {
            string url2 = url;
            string str;
            int year = -1;
            for (int i = 0; i < list.Count; i++)
            {
                if (!list[i].Contains("$"))
                {
                    str = columnDeserialize[list[i]] + "=" + values[i] + "&";
                    url2 += str;
                }
                else
                {
                    year = i;
                }
            }
            if (year > -1)
            {
                url2 += list[year] + "=" + values[year];
            }
            string rawData = new WebClient().DownloadString(url2);
            Console.WriteLine(url2);
            if (type.Equals("measurements"))
            {
                string[] regs = rawData.Substring(1, rawData.Length - 2).Split('}');
                foreach (string r in regs)
                {
                    string s = r.Replace("\n", "").Replace("\"", "");
                    if (s.Length > 10)
                    {
                        try
                        {
                            string[] attrs = s.Substring(1).Split(',');
                            string date = attrs[0].Substring(7);
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
                        catch { 
                            
                        }
                    }
                }
                Console.WriteLine("Measurements has " + measurements.Count() + " elements");
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
    }
}
