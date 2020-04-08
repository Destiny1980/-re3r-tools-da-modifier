using System;
using System.Collections.Generic;
using System.Text;

namespace RE3R_Tools_DA_Library
{
    public enum DifficultyMode
    {
        Assisted,
        Standard,
        Hardcore,
        Nightmare,
        Inferno
    }

    public struct DifficultyAdjustment
    {
        public DifficultyMode Difficulty;
        public RankAdjustment[] RankAdjustments;
    }
}
