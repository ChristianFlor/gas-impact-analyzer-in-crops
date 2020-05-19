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
    public class CropMeasurementTest
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
        public void CreateCropMeasurementTest()
        {
            string municipality = "Yumbo";
            int year = 2011;
            double algodonA = 4.3;
            double algodonB = 5.4;
            double arrozA = 6.5;
            double arrozB = 7.6;
            double frijolA = 8.7;
            double frijolB = 9.8;
            double maizTecA = 0.9;
            double maizTecB = 9.0;
            double sorgoA = 8.9;
            double sorgoB = 7.8;
            double soyaA = 6.7;
            double soyaB = 5.6;
            double tabacoA = 4.5;
            double tabacoB = 3.4;
            double maizTradA = 2.3;
            double maizTradB = 1.2;

            CropMeasurement cm = new CropMeasurement(municipality, year, algodonA, algodonB, arrozA, arrozB, frijolA, frijolB, maizTecA, maizTecB, sorgoA, sorgoB, soyaA, soyaB, tabacoA, tabacoB, maizTradA, maizTradB);

            Assert.AreEqual(municipality, cm.Municipios, "Either constructor or getter is not working properly");
            Assert.AreEqual(year, cm.A_o, "Either constructor or getter is not working properly");
            Assert.AreEqual(algodonA, cm.Algod_n_a, "Either constructor or getter is not working properly");
            Assert.AreEqual(algodonB, cm.Algod_n_b, "Either constructor or getter is not working properly");
            Assert.AreEqual(arrozA, cm.Arroz_a, "Either constructor or getter is not working properly");
            Assert.AreEqual(arrozB, cm.Arroz, "Either constructor or getter is not working properly");
            Assert.AreEqual(frijolA, cm.Frijol_a, "Either constructor or getter is not working properly");
            Assert.AreEqual(frijolB, cm.Frijol_b, "Either constructor or getter is not working properly");
            Assert.AreEqual(maizTecA, cm.Ma_z_tecnificado_a, "Either constructor or getter is not working properly");
            Assert.AreEqual(maizTecB, cm.Ma_z_tecnificado_b, "Either constructor or getter is not working properly");
            Assert.AreEqual(sorgoA, cm.Sorgo_a, "Either constructor or getter is not working properly");
            Assert.AreEqual(sorgoB, cm.Sorgo_b, "Either constructor or getter is not working properly");
            Assert.AreEqual(soyaA, cm.Soya_a, "Either constructor or getter is not working properly");
            Assert.AreEqual(soyaB, cm.Soya_b, "Either constructor or getter is not working properly");
            Assert.AreEqual(tabacoA, cm.Tabaco_a, "Either constructor or getter is not working properly");
            Assert.AreEqual(tabacoB, cm.Tabaco_b, "Either constructor or getter is not working properly");
            Assert.AreEqual(maizTradA, cm.Ma_z_tradicional_a, "Either constructor or getter is not working properly");
            Assert.AreEqual(maizTradB, cm.Ma_z_tradicional_b, "Either constructor or getter is not working properly");

            municipality = "Palmira";
            cm.Municipios = municipality;
            year = 2010;
            cm.A_o = year;
            algodonA = 1.2;
            cm.Algod_n_a = algodonA;
            algodonB = 2.3;
            cm.Algod_n_b = algodonB;
            arrozA = 3.4;
            cm.Arroz_a = arrozA;
            arrozB = 4.5;
            cm.Arroz = arrozB;
            frijolA = 5.6;
            cm.Frijol_a = frijolA;
            frijolB = 6.7;
            cm.Frijol_b = frijolB;
            maizTecA = 7.8;
            cm.Ma_z_tecnificado_a = maizTecA;
            maizTecB = 8.9;
            cm.Ma_z_tecnificado_b = maizTecB;
            sorgoA = 9.0;
            cm.Sorgo_a = sorgoA;
            sorgoB = 0.9;
            cm.Sorgo_b = sorgoB;
            soyaA = 9.8;
            cm.Soya_a = soyaA;
            soyaB = 8.7;
            cm.Soya_b = soyaB;
            tabacoA = 7.6;
            cm.Tabaco_a = tabacoA;
            tabacoB = 6.5;
            cm.Tabaco_b = tabacoB;
            maizTradA = 5.4;
            cm.Ma_z_tradicional_a = maizTradA;
            maizTradB = 4.3;
            cm.Ma_z_tradicional_b = maizTradB;

            Assert.AreEqual(municipality, cm.Municipios, "Setter is not working properly");
            Assert.AreEqual(year, cm.A_o, "Setter is not working properly");
            Assert.AreEqual(algodonA, cm.Algod_n_a, "Setter is not working properly");
            Assert.AreEqual(algodonB, cm.Algod_n_b, "Setter is not working properly");
            Assert.AreEqual(arrozA, cm.Arroz_a, "Setter is not working properly");
            Assert.AreEqual(arrozB, cm.Arroz, "Setter is not working properly");
            Assert.AreEqual(frijolA, cm.Frijol_a, "Setter is not working properly");
            Assert.AreEqual(frijolB, cm.Frijol_b, "Setter is not working properly");
            Assert.AreEqual(maizTecA, cm.Ma_z_tecnificado_a, "Setter is not working properly");
            Assert.AreEqual(maizTecB, cm.Ma_z_tecnificado_b, "Setter is not working properly");
            Assert.AreEqual(sorgoA, cm.Sorgo_a, "Setter is not working properly");
            Assert.AreEqual(sorgoB, cm.Sorgo_b, "Setter is not working properly");
            Assert.AreEqual(soyaA, cm.Soya_a, "Setter is not working properly");
            Assert.AreEqual(soyaB, cm.Soya_b, "Setter is not working properly");
            Assert.AreEqual(tabacoA, cm.Tabaco_a, "Setter is not working properly");
            Assert.AreEqual(tabacoB, cm.Tabaco_b, "Setter is not working properly");
            Assert.AreEqual(maizTradA, cm.Ma_z_tradicional_a, "Setter is not working properly");
            Assert.AreEqual(maizTradB, cm.Ma_z_tradicional_b, "Setter is not working properly");
        }
    }
}
