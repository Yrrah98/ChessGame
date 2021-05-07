using ChessEngine.Interfaces.Entities;
using ChessGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.CGEntities
{
    public class ChessBoard : IBoardEntity, IChessBoard
    {
        public IDictionary<String, IPieceEntity> CurrentGame { get; set; }
        
        /// <summary>
        /// CONSTRUCTOR for GameBoard class
        /// </summary>
        public ChessBoard()
        {
            // INSTANTIATE BOARD 
            
        }

        public void SetBoard(IDictionary<String, IPieceEntity> currentGame) 
        {
            this.CurrentGame = currentGame;
        }
    
    }

}
