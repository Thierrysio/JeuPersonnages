using JeuPersonnages.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuPersonnages.Modeles
{
    public class Magicien : IHumain
    {
        #region Attributs
        #endregion

        #region Constructeurs

        public Magicien()
        {
        }

        #endregion

        #region Propriétés
        #endregion

        #region Méthodes

        public void Marcher()
        {
            Console.WriteLine("Le magicien marche en s'appuyant sur son bâton.");
        }

        #endregion
    }

}
