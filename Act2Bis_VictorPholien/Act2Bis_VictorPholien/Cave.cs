using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2Bis_VictorPholien
{
     class Cave
    {
        private NbBouteille[] _bouteilles;

        public NbBouteille[] Bouteille
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

        public virtual bool RemonterBouteille()
        {

        }

        public virtual bool AjouterBouteille()
        {

        }

        public virtual string AfficherInventaireCave()
        {
            string info = "L'inventaire :" + Bouteille;
            return info;
        }
    }
}
