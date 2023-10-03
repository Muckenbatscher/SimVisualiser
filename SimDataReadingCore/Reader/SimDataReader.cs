using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimDataReadingCore.Events;

namespace SimDataReadingCore.Reader
{
    public abstract class SimDataReader
    {
        public event EventHandler<GameStateUpdateEventArgs>? GameStateUpdated;

        protected virtual void OnGameStateChange(GameStateUpdateEventArgs e)
        {
            GameStateUpdated?.Invoke(this, e);
        }
    }
}
