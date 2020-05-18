using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using model;

namespace BarGraphic
{
    public partial class BarGraph : Form
    {
        private double CO;
        private double O3;
        private double NO2;
        private double SO2;
        private double PM10;
        private double PM25;
        private DataManager dataManager;

        public BarGraph()
        {
            InitializeComponent();
            CO = 0;
            O3 = 0;
            NO2 = 0;
            SO2 = 0;
            PM10 = 0;
            PM25 = 0;
            dataManager = new DataManager();

            cartesianChart1.AxisX = new AxesCollection
            {
                new Axis {
                Title = "Pollutants",
                Labels = new[]{"CO", "O3", "NO2", "SO2", "PM10", "PM2.5" },
                LabelFormatter = value => value.ToString("N")

                },
            };

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            getAverageConcentration();

            cartesianChart1.Series.Clear();

            SeriesCollection sc = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = yearComboBox.Text,
                    Values = new ChartValues<double> { CO, O3, NO2, SO2, PM10, PM25 },
                    
                    
                },

               
            };

           

            cartesianChart1.Series = sc;

        }

        private void getAverageConcentration() 
        {

            dataManager.Measurements.Clear();

            Dictionary<string, string> dictionay = new Dictionary<string, string>();

            dictionay.Add("Nombre del municipio", citiesComboBox.Text);
            dictionay.Add("Variable", "CO");

            dataManager.filterDataForAir(dictionay);
            double sum = 0;
            int cont = 0;

            foreach(Measurement m in dataManager.Measurements)
            {

                if (m.Date.Contains(yearComboBox.Text))
                {

                    sum += m.Concentration;
                    cont++;
                
                }

            }

            //Console.WriteLine(sum + " " + cont);

            if(sum > 0)
                CO = sum/cont;


            //-----------------------------------------------------------
            
            dataManager.Measurements.Clear();
            dictionay.Clear();

            dictionay.Add("Nombre del municipio", citiesComboBox.Text);
            dictionay.Add("Variable", "O3");

            dataManager.filterDataForAir(dictionay);
            sum = 0;
            cont = 0;

            foreach (Measurement m in dataManager.Measurements)
            {

                if (m.Date.Contains(yearComboBox.Text))
                {

                    sum += m.Concentration;
                    cont++;

                }

            }
            //Console.WriteLine(sum + " " + cont);
            if (sum > 0)
                O3 = sum / cont;

            //-----------------------------------------------------------

            dataManager.Measurements.Clear();
            dictionay.Clear();

            dictionay.Add("Nombre del municipio", citiesComboBox.Text);
            dictionay.Add("Variable", "NO2");

            dataManager.filterDataForAir(dictionay);
            sum = 0;
            cont = 0;

            foreach (Measurement m in dataManager.Measurements)
            {

                if (m.Date.Contains(yearComboBox.Text))
                {

                    sum += m.Concentration;
                    cont++;

                }

            }
            //Console.WriteLine(sum + " " + cont);
            if (sum > 0)
                NO2 = sum / cont;

            //-----------------------------------------------------------

            dataManager.Measurements.Clear();
            dictionay.Clear();

            dictionay.Add("Nombre del municipio", citiesComboBox.Text);
            dictionay.Add("Variable", "SO2");

            dataManager.filterDataForAir(dictionay);
            sum = 0;
            cont = 0;

            foreach (Measurement m in dataManager.Measurements)
            {

                if (m.Date.Contains(yearComboBox.Text))
                {

                    sum += m.Concentration;
                    cont++;

                }

            }
            //Console.WriteLine(sum + " " + cont);
            if (sum > 0)
                SO2 = sum / cont;

            //-----------------------------------------------------------

            dataManager.Measurements.Clear();
            dictionay.Clear();

            dictionay.Add("Nombre del municipio", citiesComboBox.Text);
            dictionay.Add("Variable", "PM10");

            dataManager.filterDataForAir(dictionay);
            sum = 0;
            cont = 0;

            foreach (Measurement m in dataManager.Measurements)
            {

                if (m.Date.Contains(yearComboBox.Text))
                {

                    sum += m.Concentration;
                    cont++;

                }

            }
            //Console.WriteLine(sum + " " + cont);
            if (sum > 0)
                PM10 = sum / cont;

            //-----------------------------------------------------------

            dataManager.Measurements.Clear();
            dictionay.Clear();

            dictionay.Add("Nombre del municipio", citiesComboBox.Text);
            dictionay.Add("Variable", "PM2.5");

            dataManager.filterDataForAir(dictionay);
            sum = 0;
            cont = 0;

            foreach (Measurement m in dataManager.Measurements)
            {

                if (m.Date.Contains(yearComboBox.Text))
                {

                    sum += m.Concentration;
                    cont++;

                }

            }
            //Console.WriteLine(sum + " " + cont);
            if (sum > 0)
                PM25 = sum / cont;

            //Console.WriteLine("listo");

        }

    }
}
