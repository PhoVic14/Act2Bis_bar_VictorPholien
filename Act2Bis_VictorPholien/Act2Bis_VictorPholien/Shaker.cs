using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2Bis_VictorPholien
{
    internal class Shaker
    {
        private double _contenanceMax;
        private Portion[] _contenu;
        private bool _propre;

        public double ContenanceMax
        {
            get 
            { 
                return ContenanceMax; 
            }
        }


        public Portion[] Contenu
        {
            get 
            { 
                return Contenu; 
            }
            set 
            { 
                Contenu = value; 
            }
        }

        public int Propre
        {
            get 
            { 
                return Propre; 
            }
            set 
            { 
                Propre = value; 
            }
        }



    }
}
