using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_PARCAUTO
{
    public class Parc
    {

        private List<Vehicul> vehicule;

       public Parc() 
       {
            vehicule = new List<Vehicul>();
       }

        public Parc(List<Vehicul> vehiculs)
        {
            this.vehicule = vehiculs;
        }


        public List<Vehicul> Vehicule
        {
            get { return vehicule; }
            set
            {
                if (value != null)
                    vehicule = value;
            }
        }

        public static Parc operator +(Parc p, Vehicul v)
        {
            p.vehicule.Add(v);
            return p;
        }

    }
}
