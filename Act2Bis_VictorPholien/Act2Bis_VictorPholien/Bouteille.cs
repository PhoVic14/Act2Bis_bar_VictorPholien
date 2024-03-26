using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2Bis_VictorPholien
{
    public class Bouteille
    {
        private Liquide _contenu;
        private double _contenance;

        public Liquide Liquide
        { 
            get 
            { 
                return _contenu; 
            } 
            set
            {
                _contenu = value;
            }
        }
        public double Contenance
        { 
            get 
            {
                return _contenance; 
            }
            set
            {
                _contenance = value;
            }
        }

        public virtual bool Verser()
        {

        }

        public virtual bool Jeter()
        {

        }

    }
}
