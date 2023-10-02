using ACCDataReading.MemoryStructs;
using SimDataReadingCore.ModelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCDataReading.Services.Mapping
{
    internal static class PhysicsMapper
    {
        internal static GameState AddPhysicsInfo(this GameState gameState, Physics? physics)
        {
            if (gameState == null || physics == null)
                return gameState;

            gameState.CurrentRPM = physics.Value.Rpms;
            gameState.TCActive = physics.Value.TC > 0;
            gameState.ABSActive = physics.Value.Abs > 0;
            return gameState;
        }
    }
}
