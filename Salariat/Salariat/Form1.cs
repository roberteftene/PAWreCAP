using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salariat
{
    public partial class Form1 : Form
    {
        public firma f = new firma();
        public List<salariat> salariati;

        public Form1()
        {
            salariati = new List<salariat>();
            f = new firma(salariati);
            salariati.Add(new salariat(111, "Cezin", 40, 20));
            salariati.Add(new salariat(512, "Robert", 10, 5));
            salariati.Add(new salariat(755, "Madalin", 30, 2));
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void adaugaSalariatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salariat salariat = new salariat();
            AdaugareSalariat adaugare = new AdaugareSalariat(salariat);
            adaugare.ShowDialog();
            f = f + salariat;
            listView1.Items.Clear();
            foreach(salariat s in salariati)
            {
                ListViewItem itm = new ListViewItem(s.Marca.ToString());
                itm.SubItems.Add(s.Nume);
                itm.SubItems.Add(s.Ore.ToString());
                itm.SubItems.Add(s.Salariu.ToString());
                itm.Tag = s;
                listView1.Items.Add(itm);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (salariat s in salariati)
            {
                ListViewItem itm = new ListViewItem(s.Marca.ToString());
                itm.SubItems.Add(s.Nume);
                itm.SubItems.Add(s.Ore.ToString());
                itm.SubItems.Add(s.Salariu.ToString());
                itm.Tag = s;
                listView1.Items.Add(itm);
            }
            this.panel1.Hide();
            toolStripStatusLabel1.Text = f.fondSalarii(f).ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //get the drawing context
            Graphics graphics = e.Graphics;
            //get the drawing area
            Rectangle clipRectangle = e.ClipRectangle;

            //determine the width of the bars
            var barWidth = clipRectangle.Width / f.Salariati.Count;
            //compute the maximum bar height
            var maxBarHeight = clipRectangle.Height * 0.9;
            //compute the scaling factor based on the maximum value that we want to represent
            var scalingFactor = maxBarHeight / f.Salariati.Max(x => x.calculSalariu(x));

            Brush redBrush = new SolidBrush(Color.Blue);

            for (int i = 0; i < f.Salariati.Count; i++)
            {
                var sal = f.Salariati[i].calculSalariu(f.Salariati[i]);
                var barHeight = sal * scalingFactor;

                graphics.FillRectangle(
                    redBrush,
                    i * barWidth,
                    (float)(clipRectangle.Height - barHeight),
                    (float)(0.8 * barWidth),
                    (float)barHeight);
            }

        }

        private void afiseazaGraficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Show();
        }

        private void deleteDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void deleteDataToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected)
                {
                    listView1.Items[i].Remove();
                    f.Salariati.RemoveAt(i);
                }
            }
        }

        private void mofidyDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int contor = 0;
            foreach (ListViewItem itm in listView1.Items)
            {
                contor++;
                if (itm.Selected)
                {
                    int marca = Convert.ToInt32(itm.SubItems[0].Text);
                    string nume = itm.SubItems[1].Text;
                    int nrOre = Convert.ToInt32(itm.SubItems[2].Text);
                    int salariu = Convert.ToInt32(itm.SubItems[3].Text);
                    f.Salariati.RemoveAt(contor - 1);
                    salariat s = new salariat(marca, nume, nrOre, salariu);
                    MofificareSalariat frm = new MofificareSalariat(s, f);
                    frm.ShowDialog();
                    break;

                }
            }
          

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
