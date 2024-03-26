using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2Bis_VictorPholien
{
    internal class Cocktail
    {
        private string _nom;
        private double _contenance;
        private Recette _recetteCocktail;

        public string Nom
        {
            get 
            { 
                return _nom; 
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
    }
}
