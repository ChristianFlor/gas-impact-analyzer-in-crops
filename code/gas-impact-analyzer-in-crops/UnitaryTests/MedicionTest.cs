using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using Microsoft.Analytics.UnitTest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prueba_Consulta;

namespace UnitaryTests
{
    [TestClass]
    public class MedicionTest
    {

        [TestMethod]
        public void CreateMedicionTest()
        {
            string date = "7/5/2020";
            string authority = "cvc";
            string station = "boyaca_1";
            string tech = "automatica";
            double lat = 1234.5;
            double longg = 6789.1; ;
            string codedept = "123";
            string dept = "valle";
            int muni = 12321;
            string munic = "somewhere";
            string type = "arigato";
            double time = 777.7;
            string vari = "var";
            string units = "T/#$&\"!=\"";
            double conc = 9283.424;

            Medicion m = new Medicion(date,authority, station,tech,lat,longg,codedept,dept,muni,munic,type,time,vari,units,conc);

            Assert.AreEqual(date, m.fecha, "Either constructor or getter is not working properly");
            Assert.AreEqual(authority, m.autoridad_ambiental, "Either constructor or getter is not working properly");
            Assert.AreEqual(station, m.nombre_de_la_estaci_n, "Either constructor or getter is not working properly");
            Assert.AreEqual(tech, m.tecnolog_a, "Either constructor or getter is not working properly");
            Assert.AreEqual(lat, m.latitud, "Either constructor or getter is not working properly");
            Assert.AreEqual(longg, m.longitud, "Either constructor or getter is not working properly");
            Assert.AreEqual(codedept, m.c_digo_del_departamento, "Either constructor or getter is not working properly");
            Assert.AreEqual(dept, m.departamento, "Either constructor or getter is not working properly");
            Assert.AreEqual(muni, m.c_digo_del_municipio, "Either constructor or getter is not working properly");
            Assert.AreEqual(munic, m.nombre_del_municipio, "Either constructor or getter is not working properly");
            Assert.AreEqual(type, m.tipo_de_estaci_n, "Either constructor or getter is not working properly");
            Assert.AreEqual(time, m.tiempo_de_exposici_n, "Either constructor or getter is not working properly");
            Assert.AreEqual(vari, m.variable, "Either constructor or getter is not working properly");
            Assert.AreEqual(units, m.unidades, "Either constructor or getter is not working properly");
            Assert.AreEqual(conc, m.concentraci_n, "Either constructor or getter is not working properly");

            date = "3/6/2019";
            m.fecha = date;
            authority = "___";
            m.autoridad_ambiental = authority;
            station = "alfa1";
            m.nombre_de_la_estaci_n = station;
            tech = "manual";
            m.tecnolog_a = tech;
            lat = 4321.5;
            m.latitud = lat;
            longg = 9876.1; ;
            m.longitud = longg;
            codedept = "321";
            m.c_digo_del_departamento = codedept;
            dept = "cauca";
            m.departamento = dept;
            muni = 32123;
            m.c_digo_del_municipio = muni;
            munic = "anywhere";
            m.nombre_del_municipio = munic;
            type = "type";
            m.tipo_de_estaci_n = type;
            time = 867.5;
            m.tiempo_de_exposici_n = time;
            vari = "varrr";
            m.variable = vari;
            units = "____T/#$&\"!=\"____";
            m.unidades = units;
            conc = 42214.64689024;
            m.concentraci_n = conc;

            Assert.AreEqual(date, m.fecha);
            Assert.AreEqual(authority, m.autoridad_ambiental, "Setter is not working properly");
            Assert.AreEqual(station, m.nombre_de_la_estaci_n, "Setter is not working properly");
            Assert.AreEqual(tech, m.tecnolog_a, "Setter is not working properly");
            Assert.AreEqual(lat, m.latitud, "Setter is not working properly");
            Assert.AreEqual(longg, m.longitud, "Setter is not working properly");
            Assert.AreEqual(codedept, m.c_digo_del_departamento, "Setter is not working properly");
            Assert.AreEqual(dept, m.departamento, "Setter is not working properly");
            Assert.AreEqual(muni, m.c_digo_del_municipio, "Setter is not working properly");
            Assert.AreEqual(munic, m.nombre_del_municipio, "Setter is not working properly");
            Assert.AreEqual(type, m.tipo_de_estaci_n, "Setter is not working properly");
            Assert.AreEqual(time, m.tiempo_de_exposici_n, "Setter is not working properly");
            Assert.AreEqual(vari, m.variable, "Setter is not working properly");
            Assert.AreEqual(units, m.unidades, "Setter is not working properly");
            Assert.AreEqual(conc, m.concentraci_n, "Setter is not working properly");
        }
    }
}
