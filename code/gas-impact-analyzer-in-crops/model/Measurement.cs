using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Measurement
    {
        private string date;
        private string authority;
        private string stationName;
        private string technology;
        private double latitude;
        private double longitude;
        private string departmentCode;
        private string department;
        private string municipalityCode;
        private string municipality;
        private string stationType;
        private double exhibitionTime;
        private string variable;
        private string unit;
        private double concentration;

        public Measurement() {
        
        }
        public Measurement(string date, string authority, string stationName, string technology, double latitude, double longitude, string departmentCode, string department, string municipalityCode, string municipality, string stationType, double exhibitionTime, string variable, string unit, double concentration)
        {
            this.date = date;
            this.authority = authority;
            this.stationName = stationName;
            this.technology = technology;
            this.latitude = latitude;
            this.longitude = longitude;
            this.departmentCode = departmentCode;
            this.department = department;
            this.municipalityCode = municipalityCode;
            this.municipality = municipality;
            this.stationType = stationType;
            this.exhibitionTime = exhibitionTime;
            this.variable = variable;
            this.unit = unit;
            this.concentration = concentration;
        }
        public string Date { get => date; set => date = value; }
        public string Authority { get => authority; set => authority = value; }
        public string StationName { get => stationName; set => stationName = value; }
        public string Technology { get => technology; set => technology = value; }
        public double Latitude { get => latitude; set => latitude = value; }
        public double Longitude { get => longitude; set => longitude = value; }
        public string DepartmentCode { get => departmentCode; set => departmentCode = value; }
        public string Department { get => department; set => department = value; }
        public string MunicipalityCode { get => municipalityCode; set => municipalityCode = value; }
        public string Municipality { get => municipality; set => municipality = value; }
        public string StationType { get => stationType; set => stationType = value; }
        public double ExhibitionTime { get => exhibitionTime; set => exhibitionTime = value; }
        public string Variable { get => variable; set => variable = value; }
        public string Unit { get => unit; set => unit = value; }
        public double Concentration { get => concentration; set => concentration = value; }
    }
}
