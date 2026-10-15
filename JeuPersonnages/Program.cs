using JeuPersonnages.Dependances;
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
            if (choix == "1")
            {
                personnage = new Guerrier();
            }
            else if (choix == "2")
            {
                personnage = new Magicien();
            }
            else if (choix == "3")
            {
                personnage = new Paysan();
            }
            else
            {
                Console.WriteLine("Ce choix n'existe pas.");
                Console.ReadLine();
                return;
            }

            // On fournit le personnage choisi au jeu.
            Jeu jeu = new Jeu(personnage);

            // Le jeu utilise le personnage reçu.
            jeu.Jouer();


            // Attendre avant de fermer la console.
            Console.ReadLine();
        }

        #endregion
    }
}
