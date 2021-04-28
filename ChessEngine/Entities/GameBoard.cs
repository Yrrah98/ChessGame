using ChessEngine.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine.Entities
{
    public class GameBoard : IBoardEntity
    {

        public IDictionary<int[,], IPieceEntity> CurrentGame { get; set; }


        /// <summary>
        /// CONSTRUCTOR for GameBoard class
        /// </summary>
        public GameBoard() 
        {
            // INSTANTIATE BOARD 
        }
    }
}
