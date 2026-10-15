using JeuPersonnages.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuPersonnages.Dependances
{
    public class Jeu
    {
    #region Attributs

    private IHumain personnage;

    #endregion

    #region Constructeurs

    public Jeu(IHumain unPersonnage)
    {
        this.personnage = unPersonnage;
    }

    #endregion

    #region Propriétés
    #endregion

    #region Méthodes

    public void Jouer()
    {
        Console.WriteLine("Le jeu commence !");
        this.personnage.Marcher();
    }

    #endregion
}
}
