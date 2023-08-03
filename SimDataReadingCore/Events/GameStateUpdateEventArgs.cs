using SimDataReadingCore.ModelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDataReadingCore.Events
{
    public class GameStateUpdateEventArgs : EventArgs
    {
        public GameState GameState { get; set; }

        public GameStateUpdateEventArgs(GameState gameState)
        {
            GameState = gameState;
        }
    }
}
