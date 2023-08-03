using ACCDataReader.MemoryStructs;
using SimDataReadingCore.ModelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCDataReader.Services.Mapping
{
    internal static class StaticsMapper
    {
        internal static GameState AddStaticsInfo(this GameState gameState, Statics? statics)
        {
            if (gameState == null || statics == null)
                return null;

            gameState.MaxRPM = statics.Value.MaxRpm;
            return gameState;
        }
    }
}
