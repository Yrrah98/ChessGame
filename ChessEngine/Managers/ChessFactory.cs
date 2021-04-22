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


            return null;
        }

        public IPieceEntity MakePiece<t>() where t : IPieceEntity, new() 
        {

            return null;
        }

    }
}
