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

        public IBoardEntity MakeBoard() 
        {

            char[] boardLetters = new char[8] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };


            for (int i = 0; i < 8; i++) 
            {

                for (int j = 0; j < 8; j++) 
                {
                    // Make game board using string + num
                }
            }

            return null;
        }

        public IPieceEntity MakePiece<t>() where t : IPieceEntity, new() 
        {

            return null;
        }

    }
}
