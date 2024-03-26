using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2Bis_VictorPholien
{
    class Portion
    {
        private Liquide _contenu;
        private double _quantite;

        public Portion (Liquide contenu, double quantite)
        {
            _contenu = contenu;
            _quantite = quantite;
        }
        public Liquide contenu 
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
       

    }
}
