using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System.Windows.Controls;
using model;
using System.Windows;

namespace StackedAreaGraphic
{
    public partial class StackedArea : Form
    {

        public DataManager dm;

        public StackedArea()
        {

            InitializeComponent();
            dm = new DataManager();
            

            
        }

      

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void difference_Click(object sender, EventArgs e)
        {
            cartesianChart1.Series.Clear();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("Municipios", citiesComboBox.Text);
            
            dm.filterDataForHarvested(dictionary);

            SeriesCollection harvestedSerie = new SeriesCollection();

            StackedAreaSeries hSerie = new StackedAreaSeries();
            StackedAreaSeries pSerie = new StackedAreaSeries();

            

            hSerie.Title = "Harvested";
            pSerie.Title = "Planted";

            ChartValues<ScatterPoint> cvalues = new ChartValues<ScatterPoint>();
            ScatterPoint pair;
            

            foreach (CropMeasurement cm in dm.Harvested)
            {
                if (cm.A_o >= 2011 && cm.A_o <= 2017) {

               

                    pair = new ScatterPoint(cm.A_o, cm.Ma_z_tecnificado_a);
                    cvalues.Add(pair);

                }
                
            
            }
            hSerie.Values = cvalues;
            hSerie.LineSmoothness = 0;

            dm.filterDataForPlanted(dictionary);

            ChartValues<ScatterPoint> cvalues2 = new ChartValues<ScatterPoint>();
            ScatterPoint pair2;

            foreach (CropMeasurement cm in dm.Planted)
            {

                if (cm.A_o >= 2011 && cm.A_o <= 2017)
                {

                    pair2 = new ScatterPoint(cm.A_o, cm.Ma_z_tecnificado_a);
                    cvalues2.Add(pair2);

                }

            }
            pSerie.Values = cvalues2;
            pSerie.LineSmoothness = 0;




            harvestedSerie.Add(hSerie);
            harvestedSerie.Add(pSerie);


            cartesianChart1.Series = harvestedSerie;

            
            

        }
    }
}
