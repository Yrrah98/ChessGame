using ChessEngine.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Interfaces
{
    public interface IChessBoard
    {

        void SetBoard(IDictionary<String, IPieceEntity> currentGame);
    }
}
