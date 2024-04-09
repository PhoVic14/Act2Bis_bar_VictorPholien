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
            get { return _nom; }
        }

        public double Contenance
        {
            get { return _contenance; }
            set { _contenance = value; }
        }

        public Cocktail(string nom, Recette recetteCocktail)
        {
            _nom = nom;
            _recetteCocktail = recetteCocktail;
            _contenance = 0; // Initialise la contenance à zéro
        }

        public double ContenanceActuelle()
        {
            double contenanceActuelle = 0;

            foreach (Ingredient ingredient in _recetteCocktail.Ingredients)
            {
                // Calcul de la contenance actuelle en fonction de la quantité de chaque ingrédient dans la recette
                contenanceActuelle += ingredient.Quantite * _contenance;
            }

            return contenanceActuelle;
        }


        public string AfficherRecette()
        {
            string recette = $"Recette du cocktail {_nom} :\n";

            foreach (Ingredient ingredient in _recetteCocktail.Ingredients)
            {
                recette += $"{ingredient.Nom} : {ingredient.Quantite} cl\n"; // Affiche chaque ingrédient et sa quantité
            }

            return recette;
        }
    }
}
