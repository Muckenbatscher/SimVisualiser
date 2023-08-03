using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCDataReader.Enums
{
    public enum AC_FLAG_TYPE
    {
        AC_NO_FLAG = 0,
        AC_BLUE_FLAG = 1,
        AC_YELLOW_FLAG = 2,
        AC_BLACK_FLAG = 3,
        AC_WHITE_FLAG = 4,
        AC_CHECKERED_FLAG = 5,
        AC_PENALTY_FLAG = 6,
        AC_GREEN_FLAG = 7,
        AC_ORANGE_FLAG = 8
    }

    public enum AC_PENALTY_TYPE
    {
        AC_NONE = 0,
        AC_DRIVETHROUGH_CUTTING = 1,
        AC_STOPANDGO_10_CUTTING = 2,
        AC_STOPANDGO_20_CUTTING = 3,
        AC_STOPANDGO_30_CUTTING = 4,
        AC_DISQUALIFIED_CUTTING = 5,
        AC_REMOVEBESTLAPTIME_CUTTING = 6,
        AC_DRIVETHROUGH_PITSPEEDING = 7,
        AC_STOPANDGO_10_PITSPEEDING = 8,
        AC_STOPANDGO_20_PITSPEEDING = 9,
        AC_STOPANDGO_30_PITSPEEDING = 10,
        AC_DISQUALIFIED_PITSPEEDING = 11,
        AC_REMOVEBESTLAPTIME_PITSPEEDING = 12,
        AC_DISQUALIFIED_IGNOREMANDATEDPIT = 13,
        AC_POSTRACETIME = 14,
        AC_DISQUALIFIED_TROLLING = 15,
        AC_DISQUALIFIED_PITENTRY = 16,
        AC_DISQUALIFIED_PITEXIT = 17,
        AC_DISQUALIFIED_WRONGWAY = 18,
        AC_DRIVETHROUGH_IGNOREDDRIVERSTINT = 19,
        AC_DISQUALIFIED_IGNOREDDRIVERSTINT = 20,
        AC_DISQUALIFIED_EXCEEDEDDRIVERSTINTLIMIT = 21
    }

    public enum AC_STATUS
    {
        AC_OFF = 0,
        AC_REPLAY = 1,
        AC_LIVE = 2,
        AC_PAUSE = 3
    }

    public enum AC_SESSION_TYPE
    {
        AC_UNKNOWN = -1,
        AC_PRACTICE = 0,
        AC_QUALIFY = 1,
        AC_RACE = 2,
        AC_HOTLAP = 3,
        AC_TIME_ATTACK = 4,
        AC_DRIFT = 5,
        AC_DRAG = 6,
        AC_HOTSTINT = 7,
        AC_HOTSTINTSUPERPOLE = 8
    }

    public enum AC_TRACK_GRIP_STATUS
    {
        AC_GREEN = 0,
        AC_FAST = 1,
        AC_OPTIMUM = 2,
        AC_GREASY = 3,
        AC_DAMP = 4,
        AC_WET = 5,
        AC_FLOODED = 6
    }

    public enum AC_RAIN_INTENSITY
    {
        AC_NO_RAIN = 0,
        AC_DRIZZLE = 1,
        AC_LIGHT_RAIN = 2,
        AC_MEDIUM_RAIN = 3,
        AC_HEAVY_RAIN = 4,
        AC_THUNDERSTORM = 5
    }
}
