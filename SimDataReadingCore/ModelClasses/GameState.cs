using SimDataReadingCore.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDataReadingCore.ModelClasses
{
    public class GameState
    {
        public bool IsGameRunning { get; set; }

        public Flag Flag { get; set; }

        public int CurrentRPM { get; set; }
        public int MaxRPM { get; set; }
        public double RPMPercentage 
        {
            get
            {
                if (MaxRPM == 0)
                    return 0;
                double rawCalc = (double)CurrentRPM / MaxRPM;
                return Math.Clamp(rawCalc, 0, 1);
            }
        }

        public bool TCActive { get; set; }
        public bool ABSActive { get; set; }

        public TimeSpan LapTimeDelta { get; set; }

        public GameState(bool gameRunning, Flag flag, int currentRPM, int maxRPM, bool tCActive, bool aBSActive, TimeSpan lapTimeDelta) : this()
        {
            IsGameRunning = gameRunning;
            Flag = flag;
            CurrentRPM = currentRPM;
            MaxRPM = maxRPM;
            TCActive = tCActive;
            ABSActive = aBSActive;
            LapTimeDelta = lapTimeDelta;
        }

        public GameState()
        {
            
        }
    }
}
