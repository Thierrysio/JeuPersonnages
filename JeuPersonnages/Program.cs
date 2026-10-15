using JeuPersonnages.Interfaces;
using JeuPersonnages.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuPersonnages
{
    internal class Program
    {
        #region Attributs
        
        #endregion

        #region Constructeurs
        #endregion

        #region Propriétés
        #endregion

        #region Méthodes
        static void Main(string[] args)
        {
            // Déclaration d'une variable de type IHumain.
            IHumain personnage;
            // Affichage du menu de choix du personnage.
            Console.WriteLine("=== CHOIX DU PERSONNAGE ===");
            Console.WriteLine("1 - Guerrier");
            Console.WriteLine("2 - Magicien");
            Console.WriteLine("3 - Paysan");
            Console.Write("Votre choix : ");
            string choix = Console.ReadLine();
            // Création des trois personnages.
            personnage = new Guerrier();
            personnage = new Magicien();
            personnage = new Paysan();

            // Chaque personnage marche à sa manière.
            personnage.Marcher();
            personnage.Marcher();
            personnage.Marcher();

            // Attendre avant de fermer la console.
            Console.ReadLine();
        }

        #endregion
    }
}
