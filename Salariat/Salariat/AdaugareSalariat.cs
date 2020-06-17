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
    public partial class AdaugareSalariat : Form
    {
        public salariat salariat = new salariat();

        public AdaugareSalariat(salariat salariat)
        {
            this.salariat = salariat;
            InitializeComponent();
        }

        public void addSalariat()
        {

            salariat.Marca = Convert.ToInt32(inputMarca.Text);
            salariat.Nume = inputNume.Text;
            salariat.Ore = Convert.ToInt32(inputNrOre.Text);
            salariat.Salariu = Convert.ToInt32(inputSalariu.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                addSalariat();
                MessageBox.Show("Salariat adaugat!");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                inputMarca.Clear();
                inputNume.Clear();
                inputNrOre.Clear();
                inputSalariu.Clear();
            }

            this.Close();

        }

       

        private void AdaugareSalariat_Load(object sender, EventArgs e)
        {

        }
    }
}
