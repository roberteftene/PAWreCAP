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
    public partial class MofificareSalariat : Form
    {
        private salariat s = new salariat();
        private firma f = new firma();

        public MofificareSalariat()
        {
            InitializeComponent();
        }

        public MofificareSalariat(salariat s, firma f)
        {
            this.s = s;
            this.f = f;
            InitializeComponent();
        }

        public void getData()
        {
            inputMarca.Text = s.Marca.ToString();
            inputNume.Text = s.Nume;
            inputNrOre.Text = s.Ore.ToString();
            inputSalariu.Text = s.Salariu.ToString();
            
        }

        private void MofificareSalariat_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int marca = Convert.ToInt32(inputMarca.Text);
                string nume = inputNume.Text;
                int nrOre = Convert.ToInt32(inputNrOre.Text);
                int salariu = Convert.ToInt32(inputSalariu.Text);
                salariat s = new salariat(marca, nume, nrOre, salariu);
                f = f + s;
                MessageBox.Show("Succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                inputMarca.Clear();
                inputNume.Clear();
                inputNrOre.Clear();
                inputSalariu.Clear();
            }
            this.Close();
        }
    }
}
