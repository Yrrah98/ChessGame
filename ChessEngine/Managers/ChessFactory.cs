using ChessEngine.Entities;
using ChessEngine.Interfaces;
using ChessEngine.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine.Managers
{
    public class ChessFactory :IChessFactory
    {

        /// <summary>
        /// CONSTRUCTOR for ChessFactory 
        /// </summary>
        public ChessFactory() 
        {
            // DO NOTHING
        }

        public IBoardEntity MakeBoard<t>() where t : IBoardEntity, new() 
        {

            char[] boardLetters = new char[8] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };

            IDictionary<String, IPieceEntity> board = new Dictionary<String, IPieceEntity>();

            for (int i = 0; i < 8; i++) 
            {

                for (int j = 0; j < 8; j++) 
                {
                    // Make game board using string + num
                    board.Add(boardLetters[i] + j.ToString(), null);
                }
            }

            IBoardEntity chessBoard = new t();


            


            return null;
        }

        public IPieceEntity MakePiece<t>() where t : IPieceEntity, new() 
        {

            return null;
        }

    }
}
