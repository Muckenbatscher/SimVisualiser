using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDataReadingCore.Events
{
    public abstract class SimDataReader
    {
        public event EventHandler<GameStateUpdateEventArgs> GameStateUpdated;

        protected virtual void OnGameStateChange(GameStateUpdateEventArgs e)
        {
            GameStateUpdated?.Invoke(this, e);
        }
    }
}
