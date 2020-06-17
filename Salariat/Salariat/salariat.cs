using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salariat
{
    public class salariat
    {

        private int marca;
        private string nume;
        private int ore;
        private int salariu;

        public salariat() { }

        public salariat(int marca, string nume, int ore, int salariu)
        {
            this.marca = marca;
            this.Nume = nume;
            this.Ore = ore;
            this.Salariu = salariu;
        }

        public override string ToString()
        {
            return string.Format(
                "Marca: {0}, Nume: {1}, Ore: {2}, Salariu: {3} ",
                Marca, Nume, Ore, Salariu);
        }

        public int Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public int calculSalariu(salariat s)
        {
            return s.Ore * s.Salariu;
        }



        public string Nume { get => nume; set => nume = value; }
        public int Ore { get => ore; set => ore = value; }
        public int Salariu { get => salariu; set => salariu = value; }


    }

}
