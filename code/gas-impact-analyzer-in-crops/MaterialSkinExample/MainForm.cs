using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using MaterialSkin;
using MaterialSkin.Controls;
using model;
using System;
using System.Text;
using System.Windows.Forms;
using timeLine;
using System.Linq;
using System.Windows.Media;
using System.Collections.Generic;
namespace MaterialSkinExample
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private DataManager dataManager;
        public MainForm()
        {

            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;

            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManager.EnforceBackcolorOnAllComponents = true;

            // MaterialSkinManager properties
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);

            // Add dummy data to the listview
            seedListView();
            materialCheckedListBox1.Items.Add("Item1", false);
            materialCheckedListBox1.Items.Add("Item2", true);
            materialCheckedListBox1.Items.Add("Item3", true);
            materialCheckedListBox1.Items.Add("Item4", false);
            materialCheckedListBox1.Items.Add("Item5", true);
            materialCheckedListBox1.Items.Add("Item6", false);
            materialCheckedListBox1.Items.Add("Item7", false);

            dataManager = new DataManager(); //load it once

            loadChild(tabTimeline, new TimeLineForm(dataManager));

        }

        private void seedListView()
        {
            //Define
            var data = new[]
            {
                new []{"Lollipop", "392", "0.2", "0"},
                new []{"KitKat", "518", "26.0", "7"},
                new []{"Ice cream sandwich", "237", "9.0", "4.3"},
                new []{"Jelly Bean", "375", "0.0", "0.0"},
                new []{"Honeycomb", "408", "3.2", "6.5"}
            };

            //Add
            foreach (string[] version in data)
            {
                var item = new ListViewItem(version);
                materialListView1.Items.Add(item);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
            updateColor();
        }

        private int colorSchemeIndex;

        private void MaterialButton1_Click(object sender, EventArgs e)
        {
            colorSchemeIndex++;
            if (colorSchemeIndex > 2)
                colorSchemeIndex = 0;
            updateColor();
        }

        private void updateColor()
        {
            //These are just example color schemes
            switch (colorSchemeIndex)
            {
                case 0:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal500 : Primary.Indigo500,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal700 : Primary.Indigo700,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal200 : Primary.Indigo100,
                        Accent.Pink200,
                        TextShade.WHITE);
                    break;

                case 1:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Green600,
                        Primary.Green700,
                        Primary.Green200,
                        Accent.Red100,
                        TextShade.WHITE);
                    break;

                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.BlueGrey800,
                        Primary.BlueGrey900,
                        Primary.BlueGrey500,
                        Accent.LightBlue200,
                        TextShade.WHITE);
                    break;
            }
            Invalidate();
        }
        public void initializeAlgorithm(string crop)
        {
            dataManager.initializeKmeans(crop);
            SeriesCollection sc = new SeriesCollection()
            {
                new ScatterSeries
                {
                    Title = "Cluster A",
                    Values = new ChartValues<ObservablePoint>(),

                },
                new ScatterSeries
                {
                    Title = "Cluster B",
                    Values = new ChartValues<ObservablePoint>(),
                    PointGeometry = DefaultGeometries.Diamond
                },
                new ScatterSeries
                {
                    Title = "Cluster C",
                    Values = new ChartValues<ObservablePoint>(),
                    PointGeometry = DefaultGeometries.Triangle,
                    StrokeThickness = 2,
                    Fill = Brushes.Transparent
                },
                new ScatterSeries
                {
                    Title = "Cluster D",
                    Values = new ChartValues<ObservablePoint>(),
                    PointGeometry = DefaultGeometries.Cross,
                    StrokeThickness = 2,
                    Fill = Brushes.Transparent

                },
                new ScatterSeries
                {
                    Title = "Cluster E",
                    Values = new ChartValues<ObservablePoint>(),
                    PointGeometry = DefaultGeometries.Square
                }
            };
            int index = 0;
            foreach (var series in sc)
            {
                List<Measurement> meas = dataManager.getClusterMeasurementByID(index);
                List<CropMeasurement> crops = dataManager.getClusterCropsByID(index);
                for (int i=0; i<crops.Count;i++)
                {
                    ObservablePoint p = new ObservablePoint(meas[i].Concentration, crops[i].getTypeCrop(crop));
                    series.Values.Add(p);


                }
                index++;
            }

            KmeansChart.Series = sc;
            KmeansChart.LegendLocation = LegendLocation.Bottom;
        }
        private void ChartOnDataClick(object sender, ChartPoint p)
        {
            var asPixels = KmeansChart.Base.ConvertToPixels(p.AsPoint());
            /*
             ObservablePoint point = new ObservablePoint(p.X, p.Y);
             int index = p.SeriesView.Values.IndexOf(p.AsPoint());
             string title = p.SeriesView.Title;

             Console.WriteLine(index + "  " + dataManager.getClusterByID(0).Count + "   " + p.SeriesView.Values.Count);
             Measurement meas;
             if (title=="Cluster A")
             {
                meas = dataManager.getClusterByID(0)[index];
             }
             else if (title == "Cluster B")
             {
                  meas = dataManager.getClusterByID(1)[index];
             }
             else if (title == "Cluster C")
             {
                  meas = dataManager.getClusterByID(2)[index];
             }
            else  if (title == "Cluster D")
             {
                  meas = dataManager.getClusterByID(3)[index];
             }
             else
             {
                  meas = dataManager.getClusterByID(4)[index];
             }
             MessageBox.Show(meas.Municipality);
             labelInfo.Text = meas.Municipality;*/

        }


        private void materialSwitch4_CheckedChanged(object sender, EventArgs e)
        {
            DrawerUseColors = materialSwitch4.Checked;
        }

        private void MaterialSwitch5_CheckedChanged(object sender, EventArgs e)
        {
            DrawerHighlightWithAccent = materialSwitch5.Checked;
        }

        private void MaterialSwitch6_CheckedChanged(object sender, EventArgs e)
        {
            DrawerBackgroundWithAccent = materialSwitch6.Checked;
        }

        private void materialSwitch8_CheckedChanged(object sender, EventArgs e)
        {
            DrawerShowIconsWhenHidden = materialSwitch8.Checked;
        }

        private void MaterialButton3_Click(object sender, EventArgs e)
        {
            var builder = new StringBuilder("Batch operation report:\n\n");
            var random = new Random();
            var result = 0;

            for (int i = 0; i < 200; i++)
            {
                result = random.Next(1000);

                if (result < 950)
                {
                    builder.AppendFormat(" - Task {0}: Operation completed sucessfully.\n", i);
                }
                else
                {
                    builder.AppendFormat(" - Task {0}: Operation failed! A very very very very very very very very very very very very serious error has occured during this sub-operation. The errorcode is: {1}).\n", i, result);
                }
            }

            var batchOperationResults = builder.ToString();
            var mresult = MaterialMessageBox.Show(batchOperationResults, "Batch Operation");

        }

        private void materialButton9_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }


        private void loadChild(TabPage parent, Form childForm)
        {
            if (parent.Controls.Count > 0)
            {
                parent.Controls.RemoveAt(0);
            }
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            parent.Controls.Add(childForm);
            parent.Tag = childForm;
            childForm.Show();
        }

        private void viewClusters_Click(object sender, EventArgs e) { 

            string item = cropsItems.SelectedItem.ToString();
            if(item!=""){
                 Console.WriteLine(item);
                initializeAlgorithm(item);
            }
        }
    }
}