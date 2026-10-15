using JeuPersonnages.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuPersonnages.Modeles
{
    public class Paysan : IHumain
    {
        #region Attributs
        #endregion

        #region Constructeurs

        public Paysan()
        {
        }

        #endregion

        #region Propriétés
        #endregion

        #region Méthodes

        public void Marcher()
        {
            Console.WriteLine("Le paysan marche avec sa fourche sur l'épaule.");
        }

        #endregion
    }
}
