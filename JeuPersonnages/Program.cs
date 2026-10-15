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
            // Création des trois personnages.
            Guerrier guerrier = new Guerrier();
            Magicien magicien = new Magicien();
            Paysan paysan = new Paysan();

            // Chaque personnage marche à sa manière.
            guerrier.Marcher();
            magicien.Marcher();
            paysan.Marcher();

            // Attendre avant de fermer la console.
            Console.ReadLine();
        }

        #endregion
    }
}
