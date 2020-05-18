using System;
using System.Collections;
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
using LiveCharts.Configurations;
using LiveCharts.Defaults;
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
            dataManager.Measurements.Clear();

            Dictionary<string, string> filtros = new Dictionary<string, string>();

            filtros.Add("Nombre del municipio", "CALI");
            filtros.Add("Variable", gasesComboBox.Text);
            dataManager.filterDataForAir(filtros);

            filtros.Clear();

            filtros.Add("Nombre del municipio", "BUENAVENTURA");
            filtros.Add("Variable", gasesComboBox.Text);
            dataManager.filterDataForAir(filtros);

            filtros.Clear();

            filtros.Add("Nombre del municipio", "GUADALAJARA%20DE%20BUGA");
            filtros.Add("Variable", gasesComboBox.Text);
            dataManager.filterDataForAir(filtros);

            filtros.Clear();

            filtros.Add("Nombre del municipio", "CANDELARIA");
            filtros.Add("Variable", gasesComboBox.Text);
            dataManager.filterDataForAir(filtros);

            filtros.Clear();

            filtros.Add("Nombre del municipio", "JAMUNDÍ");
            filtros.Add("Variable", gasesComboBox.Text);
            dataManager.filterDataForAir(filtros);

            filtros.Clear();

            filtros.Add("Nombre del municipio", "PALMIRA");
            filtros.Add("Variable", gasesComboBox.Text);
            dataManager.filterDataForAir(filtros);

            filtros.Clear();

            filtros.Add("Nombre del municipio", "YUMBO");
            filtros.Add("Variable", gasesComboBox.Text);
            dataManager.filterDataForAir(filtros);

            filtros.Clear();



            cartesianChart1.Series.Clear();
            cartesianChart1.AxisX.Clear();
            Dictionary<string, List<MeasurementModel>> municipalities = new Dictionary<string, List<MeasurementModel>>();
            var initYear = initialDate.Value;
            var endYear = finalDate.Value;
            foreach (Measurement m in dataManager.Measurements)
            {
                int year = int.Parse(m.date.Split('/')[2]);
                if (year >= initYear && year <= endYear)
                {
                    if (!municipalities.ContainsKey(m.municipality))
                    {
                        municipalities.Add(m.municipality, new List<MeasurementModel>());
                    }

                    string[] date = m.date.Split('/');
                    municipalities[m.municipality].Add(new MeasurementModel(new DateTime(Convert.ToInt32(date[2]), Convert.ToInt32(date[1]), Convert.ToInt32(date[0])), m.concentration));
                }

            }

            var dateConfig = Mappers.Xy<MeasurementModel>()
                           .X(dayModel => dayModel.Date.Ticks)
                           .Y(dayModel => dayModel.Concentration);

            SeriesCollection sc = new SeriesCollection(dateConfig);

            foreach (string v in municipalities.Keys)
            {
                sc.Add(new LineSeries() { Title = v, Values = new ChartValues<MeasurementModel>(municipalities[v]) });
            }
            cartesianChart1.Series = sc;
            DateTime maxi = new DateTime((int)finalDate.Value, 12, 31);
            DateTime mini = new DateTime((int)initialDate.Value, 1, 1);
            TimeSpan ts = new TimeSpan(maxi.Ticks - mini.Ticks);
           
            cartesianChart1.AxisX = new AxesCollection
            {
                new Axis {
                Title = "Date",
                LabelFormatter = value => new DateTime((long)value).ToShortDateString()
                },
            };
            
        }

        public class MeasurementModel : IComparable<MeasurementModel>
        {
            public MeasurementModel(DateTime dateTime, double concentration)
            {
                Date = dateTime;
                Concentration = concentration;
            }

            public int CompareTo(MeasurementModel obj)
            {
                return DateTime.Compare(this.Date, obj.Date);
            }

            public DateTime Date { get; set; }
            public double Concentration { get; set; }
        }
    }
}
