using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_PARCAUTO 
{
    [Serializable]
    public class Vehicul 
    {

        private string modelMasina;
        private int anFabricatie;
        private float pret;

        public Vehicul(string modelMasina, int anFabricatie, float pret)
        {

            this.modelMasina = modelMasina;
            this.anFabricatie = anFabricatie;
            this.pret = pret;

        }

        public Vehicul()
        {
        }

        public override string ToString()
        {
            return string.Format(
                "Model Masina: {0}, An Fabricatie: {1}, Pret: {2}",
                ModelMasina, AnFabricatie, Pret);
        }

        public string ModelMasina
        {
            get { return modelMasina; }
            set { modelMasina = value; }
        }

        public int AnFabricatie
        {
            get { return anFabricatie; }
            set { anFabricatie = value; }
        }

        public float Pret
        {
            get { return pret; }
            set { pret = value; }
        }


    }
}
