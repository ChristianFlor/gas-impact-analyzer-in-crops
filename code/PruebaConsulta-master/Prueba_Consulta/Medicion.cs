using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Consulta
{
    public class Medicion
    {
        
        public string fecha { get; set; }
        public string autoridad_ambiental { get; set; }
        public string nombre_de_la_estaci_n { get; set; }
        public string tecnolog_a { get; set; }
        public double latitud { get; set; }
        public double longitud { get; set; }
        public string c_digo_del_departamento { get; set; }
        public string departamento { get; set; }
        public int c_digo_del_municipio { get; set; }
        public string nombre_del_municipio { get; set; }
        public string tipo_de_estaci_n { get; set; }
        public double tiempo_de_exposici_n { get; set; }
        public string variable { get; set; }
        public string unidades { get; set; }
        public double concentraci_n { get; set; }
        

        

        public Medicion() {
        
        }
        /*
        public Medicion(string fecha, string autoridad, string nombre_estacion, string tecnologia, double latitud, double longitud,
            string codeDepartamento, string departamento, int codeMunicipio, string nombreMunicipio, string tipoEstacion,
            double tiempoExposicion, string variable, string variables, string unidades, double concentracion)
        {

            this.fecha = fecha;
            this.autoridad_ambiental = autoridad;
            this.nombre_de_la_estaci_n = nombre_estacion;
            this.tecnolog_a = tecnologia;
            this.latitud = latitud;
            this.longitud = longitud;
            this.c_digo_del_departamento = codeDepartamento;
            this.departamento = departamento;
            this.c_digo_del_municipio = codeMunicipio;
            this.nombre_del_municipio = nombreMunicipio;
            this.tipo_de_estaci_n = tipoEstacion;
            this.tiempo_de_exposici_n = tiempoExposicion;
            this.variable = variable;
            this.unidades = unidades;
            this.concentraci_n = concentracion;

        }
        */
    } 
}
