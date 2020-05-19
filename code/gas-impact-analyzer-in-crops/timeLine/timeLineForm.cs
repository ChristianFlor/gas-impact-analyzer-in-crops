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

            filtros.Add("Nombre del municipio", municipalityComboBox.Text);
            filtros.Add("Tecnología", "Automática");
            string month = "" + (int)monthSelector.Value;
            if (month.Length == 1) {
                month = "0" + month;
            }
            filtros.Add("$where", "contains(Fecha,%27" + month + "/" + (int)yearSelector.Value + "%27)");
            filtros.Add("Variable", gasComboBox.Text);
            dataManager.filterDataForAir(filtros);

            cartesianChart1.Series.Clear();
            cartesianChart1.AxisX.Clear();
            List<MeasurementModel> mm = new List<MeasurementModel>();
            foreach (Measurement m in dataManager.Measurements)
            {
                string[] splt = m.Date.Split(' ');
                string[] date = splt[0].Split('/');
                string[] time = splt[1].Split(' ');
                string[] hour = time[0].Split(':');
                if (splt[2].Equals("p.") && !hour[0].Equals("12"))
                {
                    hour[0] = (Convert.ToInt32(hour[0]) + 12) + "";
                }
                mm.Add(new MeasurementModel(new DateTime(Convert.ToInt32(date[2]), Convert.ToInt32(date[1]), Convert.ToInt32(date[0]), Convert.ToInt32(hour[0]), Convert.ToInt32(hour[1]), 0), m.Concentration));
            }

            var dateConfig = Mappers.Xy<MeasurementModel>()
                           .X(dayModel => dayModel.Date.Ticks)
                           .Y(dayModel => dayModel.Concentration);
            mm.Sort();
            SeriesCollection sc = new SeriesCollection(dateConfig);
            sc.Add(new LineSeries() { Title = gasComboBox.Text, Values = new ChartValues<MeasurementModel>(mm) });
            cartesianChart1.Series = sc;
           
            cartesianChart1.AxisX = new AxesCollection
            {
                new Axis {
                Title = "Date",
                LabelFormatter = (value) => 
                {
                    DateTime dt = new DateTime((long)value);
                    return dt.Day +"/"+ dt.Month +"/"+ dt.Year +" "+ dt.Hour + ":" + dt.Minute;
                }
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
