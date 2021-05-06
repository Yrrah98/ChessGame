using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine.Interfaces.Entities
{
    public interface IBoardEntity
    {

        /// <summary>
        /// PROPERTY: GameBoard, a dictionary where each position on the board is a key and may have a single 
        /// piece entity as a value;
        /// </summary>
        IDictionary<String, IPieceEntity> CurrentGame { get; set; }
    }
}
