using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_PARCAUTO
{
    public partial class Form1 : Form
    {
   
        public Parc p = new Parc();
        public List<Vehicul> vehiculs;
        AdaugareVehicul adaugareVehicul;

        public Form1()
        {
            vehiculs = new List<Vehicul>();
            p = new Parc(vehiculs);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehicul vehicul = new Vehicul();
            AdaugareVehicul adaugare = new AdaugareVehicul(vehicul);
            adaugare.ShowDialog();
                p = p + vehicul;
            listViewVehicule.Items.Clear();
            foreach (Vehicul v in vehiculs)
                {
                    ListViewItem listViewItem = new ListViewItem(v.ModelMasina);
                    listViewItem.SubItems.Add(v.AnFabricatie.ToString());
                    listViewItem.SubItems.Add(v.Pret.ToString());

                    listViewVehicule.Items.Add(listViewItem);
                    listViewItem.Tag = v;

                }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach(Vehicul v in vehiculs)
            {
                MessageBox.Show(v.ToString());
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = listViewVehicule.Items.Count - 1; i >= 0; i--)
            {
                if (listViewVehicule.Items[i].Selected)
                {
                    listViewVehicule.Items[i].Remove();
                    p.Vehicule.RemoveAt(i);
                }
            }
           
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.panel1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {



            //get the drawing context
            Graphics graphics = e.Graphics;
            //get the drawing area
            Rectangle clipRectangle = e.ClipRectangle;

            //determine the width of the bars
            var barWidth = clipRectangle.Width / p.Vehicule.Count;
            //compute the maximum bar height
            var maxBarHeight = clipRectangle.Height * 0.9;
            //compute the scaling factor based on the maximum value that we want to represent
            var scalingFactor = maxBarHeight / p.Vehicule.Max(x => x.Pret);

            Brush redBrush = new SolidBrush(Color.Blue);

            for (int i = 0; i < p.Vehicule.Count; i++)
            {
                var barHeight = p.Vehicule[i].Pret * scalingFactor;

                graphics.FillRectangle(
                    redBrush,
                    i * barWidth,
                    (float)(clipRectangle.Height - barHeight),
                    (float)(0.8 * barWidth),
                    (float)barHeight);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*txt)|*txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter stream = new StreamWriter(
                    saveFileDialog1.FileName);

                foreach (ListViewItem itm in listViewVehicule.Items)
                {
                    for(int i = 0; i < itm.SubItems.Count; i++)
                    {

                        stream.Write(itm.SubItems[i].Text + " ");

                    }

                    stream.WriteLine();

                }

                stream.Close();

            }


        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }
    }
}
