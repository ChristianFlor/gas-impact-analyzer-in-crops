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
            getAverageConcentration("CO");
            getAverageConcentration("O3");
            getAverageConcentration("NO2");
            getAverageConcentration("SO2");
            getAverageConcentration("PM10");
            getAverageConcentration("PM25");

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

        private void getAverageConcentration(string gas) 
        {

            dataManager.Measurements.Clear();

            Dictionary<string, string> dictionay = new Dictionary<string, string>();

            dictionay.Add("Nombre del municipio", citiesComboBox.Text);
            dictionay.Add("Variable", gas);

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

            if (sum > 0)
            {
                if(gas=="CO")
                    CO = sum / cont;
                else if (gas == "O3")
                    O3 = sum / cont;
                else if (gas == "NO2")
                    NO2 = sum / cont;
                else if (gas == "SO2")
                    SO2 = sum / cont;
                else if (gas == "PM10")
                    PM10 = sum / cont;
                else
                    PM25 = sum / cont;
            }
            

        }

    }
}
