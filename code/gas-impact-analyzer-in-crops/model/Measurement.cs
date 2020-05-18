using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Measurement
    {
        public string date{ get; set; }
        public string authority{ get; set; }
        public string stationName{ get; set; }
        public string technology{ get; set; }
        public double latitude{ get; set; }
        public double longitude{ get; set; }
        public string departmentCode{ get; set; }
        public string department{ get; set; }
        public string municipalityCode{ get; set; }
        public string municipality{ get; set; }
        public string stationType{ get; set; }
        public double exhibitionTime{ get; set; }
        public string variable{ get; set; }
        public string unit{ get; set; }
        public double concentration{ get; set; }

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

       
    }
}
