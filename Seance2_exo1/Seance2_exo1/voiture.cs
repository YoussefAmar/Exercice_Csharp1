using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance2_exo1
{
    class voiture
    {
        public int numchassis;

        public string marque;

        public string etat ="à l'arrêt";

        public voiture(int numchassis, string marque)
        {
            this.numchassis = numchassis;
            this.marque = marque;

        }

        public void demarre()
        {
            etat = "en marche";

        }

    }
}
