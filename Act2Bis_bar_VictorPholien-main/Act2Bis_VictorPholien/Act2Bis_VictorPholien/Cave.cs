using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2Bis_VictorPholien
{
    class Cave
    {
        private Bouteille[] _bouteilles;
        private int _index; // Pour suivre le nombre de bouteilles dans la cave

        public Bouteille[] Bouteilles
        {
            get { return _bouteilles; }
            set { _bouteilles = value; }
        }

        public Cave()
        {
            _bouteilles = new Bouteille[10]; // Initialise le tableau de bouteilles avec une taille de 10
            _index = 0; // Initialise l'index à 0
        }

        public virtual bool RemonterBouteille(Bouteille bouteille)
        {
            // Vérifie si la cave est pleine
            if (_index >= _bouteilles.Length)
            {
                Console.WriteLine("La cave est pleine, impossible d'ajouter une autre bouteille.");
                return false;
            }

            // Ajoute la bouteille au tableau
            _bouteilles[_index] = bouteille;
            _index++; // Incrémente l'index

            Console.WriteLine("Bouteille remontée avec succès de la cave.");
            return true;
        }

        public virtual bool AjouterBouteille()
        {
            // Vérifie si la cave est vide
            if (_index == 0)
            {
                Console.WriteLine("La cave est vide, impossible de remonter une bouteille.");
                return false;
            }

            // Retire la dernière bouteille ajoutée au tableau
            _index--;

            Console.WriteLine("Bouteille descendue avec succès dans la cave.");
            return true;
        }

        public virtual string AfficherInventaireCave()
        {
            string info = "L'inventaire de la cave : \n";
            for (int i = 0; i < _index; i++)
            {
                info += $"{i + 1}. {_bouteilles[i]}\n"; // Affiche chaque bouteille
            }
            return info;
        }
    }
}