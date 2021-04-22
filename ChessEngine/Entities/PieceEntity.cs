using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;


namespace ChessEngine.Entities
{
    public abstract class PieceEntity
    {
        // A variable all entities of type PieceEntity will containt
        protected Texture2D _entityTexture;
        // A variable which states the current position of the entity
        protected int[,] _boardPosition;

        /// <summary>
        /// BASE CONSTRUCTOR for entities of type PieceEntity
        /// </summary>
        public PieceEntity() 
        {
            // Initialise the _boardPosition so it can only contain 1 set of values for x and y
            _boardPosition = new int[1, 1];
        }

    }
}
