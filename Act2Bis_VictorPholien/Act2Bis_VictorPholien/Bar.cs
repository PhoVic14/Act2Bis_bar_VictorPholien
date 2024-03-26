using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2Bis_VictorPholien
{
    internal class Bar
    {
        private Bouteille[] _bouteilles;

     
        public Bouteille[] Bouteilles
        {
            get
            {
                return _bouteilles;
            }
            set
            {
                _bouteilles = value;
            }
        }

        public Bar()
        {
            _bouteilles = Bouteille;
        }

        public virtual bool PrendreBouteille()
        {

        }

        public virtual bool AjouterBouteille()
        {

        }


        public virtual string AfficherInventairebar()
        {
            string info = "L'inventaire :" + Bouteille;
            return info;
        }
    }
}
