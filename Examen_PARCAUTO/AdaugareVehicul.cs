using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_PARCAUTO
{
    public partial class AdaugareVehicul : Form
    {

        public Vehicul vehicul = new Vehicul();

    

        public AdaugareVehicul(Vehicul vehicul)
        {
            this.vehicul = vehicul;
            
            InitializeComponent();
        }

        private void AdaugareVehicul_Load(object sender, EventArgs e)
        {

        }

        public void addCar()
        {
            vehicul.ModelMasina = inputModel.Text;
            vehicul.AnFabricatie = Convert.ToInt32(inputAnFabricatie.Text);
            vehicul.Pret = (float)Convert.ToDouble(inputPret.Text);
        }

        private void addCarBtn_Click(object sender, EventArgs e)
        {

            try
            {
                addCar();
                MessageBox.Show("S-a adaugat vehiculul");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                inputModel.Clear();
                inputAnFabricatie.Clear();
                inputPret.Clear();
            }

            this.Close();

        }
    }
}
