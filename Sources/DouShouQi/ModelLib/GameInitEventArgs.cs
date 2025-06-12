using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DouShouQiModel
{
    /// <summary>
    /// Représente un événement qui se produit lors de l'initialisation du jeu
    /// </summary>
    public class GameInitEventArgs : EventArgs
    {
        public Board? Board { get; private set; }
        public List<bool>? ListAbilityIsActivate {  get; private set; }
        public GameInitEventArgs(Board board, List<bool> listAbilityIsActivate)
        {
            Board = board;
            ListAbilityIsActivate = listAbilityIsActivate;
        }
    }


}
