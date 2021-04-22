using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessEngine.Interfaces.Entities;

namespace ChessEngine.Interfaces
{
    public interface IChessFactory
    {
        /// <summary>
        /// METHOD: To make the board, which will contain references to all pieces on each position
        /// </summary>
        /// <returns></returns>
        IBoardEntity MakeBoard();
        /// <summary>
        /// METHOD: To make a game piece, each piece will store its own movement style/pattern
        /// </summary>
        /// <typeparam name="t"></typeparam>
        /// <returns></returns>
        IPieceEntity MakePiece<t>() where t : IPieceEntity, new();
    }
}
