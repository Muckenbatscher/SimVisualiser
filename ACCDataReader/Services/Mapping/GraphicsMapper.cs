using ACCDataReading.Enums;
using ACCDataReading.MemoryStructs;
using SimDataReadingCore.Enumerations;
using SimDataReadingCore.ModelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCDataReading.Services.Mapping
{
    internal static class GraphicsMapper
    {
        internal static GameState AddGraphicsInfo(this GameState gameState, Graphics? graphics)
        {
            if (gameState == null || graphics == null)
                return gameState;

            gameState.IsGameRunning = IsGameRunning(graphics.Value.Status, graphics.Value.Session);
            gameState.LapTimeDelta = graphics.Value.IDeltaLapTime / 1000D;
            gameState.Flag = GetCoreFlag(graphics.Value.Flag);
            return gameState;
        }

        internal static Flag GetCoreFlag(AC_FLAG_TYPE acFlag)
        {
            switch (acFlag)
            {
                case AC_FLAG_TYPE.AC_BLUE_FLAG:
                    return Flag.BlueFlag;
                case AC_FLAG_TYPE.AC_YELLOW_FLAG:
                    return Flag.YellowFlag;
                case AC_FLAG_TYPE.AC_BLACK_FLAG:
                    return Flag.BlackFlag;
                case AC_FLAG_TYPE.AC_WHITE_FLAG:
                    return Flag.WhiteFlag;
                case AC_FLAG_TYPE.AC_CHECKERED_FLAG:
                    return Flag.CheckeredFlag;
                case AC_FLAG_TYPE.AC_GREEN_FLAG:
                    return Flag.GreenFlag;
                case AC_FLAG_TYPE.AC_ORANGE_FLAG:
                    return Flag.OrangeFlag;

                default:
                    return Flag.None;
            }
        }

        internal static bool IsGameRunning(AC_STATUS status, AC_SESSION_TYPE sessionType)
        {
            return status == AC_STATUS.AC_LIVE && sessionType != AC_SESSION_TYPE.AC_UNKNOWN;
        }
    }
}
