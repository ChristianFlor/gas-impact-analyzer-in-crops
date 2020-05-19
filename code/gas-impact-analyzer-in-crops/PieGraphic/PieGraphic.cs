using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using model;

namespace PieGraphic
{
    public partial class PieGraphic : Form
    {
        private DataManager dm;

        public PieGraphic()
        {
            InitializeComponent();
            dm = new DataManager();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            pieHarvested.Series.Clear();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("Municipios", citiesComboBox.Text);
            dictionary.Add("AÑO", yearComboBox.Text);
            

            dm.filterDataForHarvested(dictionary);
            showData();
            
            
        }

        private void showData() 
        {

            List<string> list = supportList();

            SeriesCollection sc = new SeriesCollection();
            PieSeries ps;

            CropMeasurement cm = dm.Harvested[0];

            foreach (string st in list)
            {

                ps = new PieSeries()
                {

                    Title = st,
                    Values = new ChartValues<ObservableValue> { new ObservableValue(cm.getTypeCrop(st)) },
                    DataLabels = true,

                };

                sc.Add(ps);
            }

            pieHarvested.Series = sc;
            
        
        }

        private List<string> supportList() 
        {

            List<string> list = new List<string>();

            list.Add("AlgodonA");
            list.Add("AlgodonB");
            list.Add("ArrozA");
            list.Add("ArrozB");
            list.Add("FrijolA");
            list.Add("FrijolB");
            list.Add("MaizTecnificadoA");
            list.Add("MaizTecnificadoB");
            list.Add("SorgoA");
            list.Add("SorgoB");
            list.Add("SoyaA");
            list.Add("SoyaB");
            list.Add("TabacoA");
            list.Add("TabacoB");
            list.Add("MaizTradicionalA");
            list.Add("MaizTradicionalB");


            return list;
        
        }
    }
}
