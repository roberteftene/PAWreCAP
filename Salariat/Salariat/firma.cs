using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salariat
{
    public class firma
    {
        private List<salariat> salariati;

        public firma()
        {
            this.Salariati = new List<salariat>();
        }

        public firma(List<salariat> salariati)
        {
            this.salariati = salariati;
        }

        public int fondSalarii(firma f)
        {
            int suma = 0;
            foreach(salariat s in f.salariati)
            {
                suma += s.calculSalariu(s);
            }
            return suma;
        }

        public static firma operator +(firma f, salariat s)
        {
            f.salariati.Add(s);
            return f;
        }
        public salariat this[int index]
        {
            get
            {
                return this.salariati[index];
            }
        }

        internal List<salariat> Salariati { get => salariati; set => salariati = value; }
    }
}
