using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using model;

namespace timeLine
{
    public partial class TimeLineForm : Form
    {
        private DataManager dataManager;

        public TimeLineForm(DataManager dm)
        {
            InitializeComponent();
            dataManager = dm;
            dm.addDataJustToTest_DeleteItAndAdaptTheChartToTheRealSituationAfterSeeingThisWorking();
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Concentracion (µg/m3)",
                LabelFormatter = value => value.ToString()
            });
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cartesianChart1.Series.Clear();
            List<string> xaxis = new List<string>();
            
            Dictionary<string, List<double>> municipalities = new Dictionary<string, List<double>>();
            var initYear = initialDate.Value;
            var endYear = finalDate.Value;
            foreach (Measurement m in dataManager.Measurements)
            {
                int year = int.Parse(m.Date.Split('/')[2]);
                if (year >= initYear && year <= endYear)
                {
                    if (!municipalities.ContainsKey(m.Municipality))
                    {
                        municipalities.Add(m.Municipality, new List<Double>());
                    }
                    municipalities[m.Municipality].Add(m.Concentration);
                }
                
            }

            SeriesCollection sc = new SeriesCollection();

            foreach (string v in municipalities.Keys)
            {
                sc.Add(new LineSeries() { Title = v, Values = new ChartValues<double>(municipalities[v])});
            }

            cartesianChart1.Series = sc;
        }
    }
}
