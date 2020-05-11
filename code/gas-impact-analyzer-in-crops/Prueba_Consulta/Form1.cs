using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SODA;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using heat_map;

namespace Prueba_Consulta
{
    public partial class Form1 : Form
    {

        private Dictionary<string, string> mapa;
        private HeatMap hm;
        string url = "";
        Medicion med;

        public Form1()
        {
            InitializeComponent();
            hm = new HeatMap();
        }

        public void readInfo()
        {
            mapa = new Dictionary<string, string>();
            dataGridView1.Columns.Clear();
            checkedListBox1.Items.Clear();

            string repository = repositoryUrl.Text;
            string id = datasetId.Text;
            url = repository + "/resource/" + id + ".json?";
            var client = new SodaClient(repository, "zzanGqreT6bAIRPuvhwn9yso3");
            var dataset = client.GetResource<Object>(id);
            foreach(var c in dataset.Columns)
            {
                checkedListBox1.Items.Add(c.Name, false);
                mapa.Add(c.Name, c.SodaFieldName);
                dataGridView1.Columns.Add(c.SodaFieldName, c.Name);
            }
            
           

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string url2 = url;
            string cadena;
            string[] valores = textBoxValor.Text.Split(',');
            var list = checkedListBox1.CheckedItems;

            for (int i = 0; i < list.Count; i++) {

                cadena = mapa[list[i].ToString()] + "=" + valores[i] + "&";
                url2 += cadena;
            
            }

            string datosCrudos = new WebClient().DownloadString(url2);

            JavaScriptSerializer js = new JavaScriptSerializer();
            Medicion[] mediciones = js.Deserialize<Medicion[]>(datosCrudos);

          
            
            
            foreach (Medicion m in mediciones) {

                dataGridView1.Rows.Add(m.fecha, m.autoridad_ambiental, m.nombre_de_la_estaci_n, m.tecnolog_a, m.latitud, m.longitud,
                    m.c_digo_del_departamento, m.departamento, m.c_digo_del_municipio, m.nombre_del_municipio, m.tipo_de_estaci_n, m.tiempo_de_exposici_n,
                    m.variable, m.unidades, m.concentraci_n);

            }

        }

  

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            readInfo();
        }

        private void heatMap_Click(object sender, EventArgs e)
        {
            hm.PaintHeatMap(heatMap);
            //textBoxValor.Text = $"Current directory is '{Environment.CurrentDirectory}'";
        }
    }
}
