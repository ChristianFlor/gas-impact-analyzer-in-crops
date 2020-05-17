using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using model;

namespace UnitaryTests
{
    /// <summary>
    /// Descripción resumida de UnitTest1
    /// </summary>
    [TestClass]
    public class MeasurementTest
    {

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

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
            string muni = "12321";
            string munic = "somewhere";
            string type = "arigato";
            double time = 777.7;
            string vari = "var";
            string units = "T/#$&\"!=\"";
            double conc = 9283.424;

            Measurement m = new Measurement(date, authority, station, tech, lat, longg, codedept, dept, muni, munic, type, time, vari, units, conc);

            Assert.AreEqual(date, m.Date, "Either constructor or getter is not working properly");
            Assert.AreEqual(authority, m.Authority, "Either constructor or getter is not working properly");
            Assert.AreEqual(station, m.StationName, "Either constructor or getter is not working properly");
            Assert.AreEqual(tech, m.Technology, "Either constructor or getter is not working properly");
            Assert.AreEqual(lat, m.Latitude, "Either constructor or getter is not working properly");
            Assert.AreEqual(longg, m.Longitude, "Either constructor or getter is not working properly");
            Assert.AreEqual(codedept, m.DepartmentCode, "Either constructor or getter is not working properly");
            Assert.AreEqual(dept, m.Department, "Either constructor or getter is not working properly");
            Assert.AreEqual(muni, m.MunicipalityCode, "Either constructor or getter is not working properly");
            Assert.AreEqual(munic, m.Municipality, "Either constructor or getter is not working properly");
            Assert.AreEqual(type, m.StationType, "Either constructor or getter is not working properly");
            Assert.AreEqual(time, m.ExhibitionTime, "Either constructor or getter is not working properly");
            Assert.AreEqual(vari, m.Variable, "Either constructor or getter is not working properly");
            Assert.AreEqual(units, m.Unit, "Either constructor or getter is not working properly");
            Assert.AreEqual(conc, m.Concentration, "Either constructor or getter is not working properly");

            date = "3/6/2019";
            m.Date = date;
            authority = "___";
            m.Authority = authority;
            station = "alfa1";
            m.StationName = station;
            tech = "manual";
            m.Technology = tech;
            lat = 4321.5;
            m.Latitude = lat;
            longg = 9876.1; ;
            m.Longitude = longg;
            codedept = "321";
            m.DepartmentCode = codedept;
            dept = "cauca";
            m.Department = dept;
            muni = "32123";
            m.MunicipalityCode = muni;
            munic = "anywhere";
            m.Municipality = munic;
            type = "type";
            m.StationType = type;
            time = 867.5;
            m.ExhibitionTime = time;
            vari = "varrr";
            m.Variable = vari;
            units = "____T/#$&\"!=\"____";
            m.Unit = units;
            conc = 42214.64689024;
            m.Concentration = conc;

            Assert.AreEqual(date, m.Date);
            Assert.AreEqual(authority, m.Authority, "Setter is not working properly");
            Assert.AreEqual(station, m.StationName, "Setter is not working properly");
            Assert.AreEqual(tech, m.Technology, "Setter is not working properly");
            Assert.AreEqual(lat, m.Latitude, "Setter is not working properly");
            Assert.AreEqual(longg, m.Longitude, "Setter is not working properly");
            Assert.AreEqual(codedept, m.DepartmentCode, "Setter is not working properly");
            Assert.AreEqual(dept, m.Department, "Setter is not working properly");
            Assert.AreEqual(muni, m.MunicipalityCode, "Setter is not working properly");
            Assert.AreEqual(munic, m.Municipality, "Setter is not working properly");
            Assert.AreEqual(type, m.StationType, "Setter is not working properly");
            Assert.AreEqual(time, m.ExhibitionTime, "Setter is not working properly");
            Assert.AreEqual(vari, m.Variable, "Setter is not working properly");
            Assert.AreEqual(units, m.Unit, "Setter is not working properly");
            Assert.AreEqual(conc, m.Concentration, "Setter is not working properly");
        }
    }
}
