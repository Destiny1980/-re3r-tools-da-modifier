﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RE3R_Tools_DA_Library
{
    public class RankAdjustmentParser
    {
        private byte[] Data;
        private const string RankAdjustmentFileName = "gamerankparameterdata.user.2";
        private const int DAMAGE_TAKEN_OFFSET_START = 0x7E0;
        private const int DAMAGE_DEALT_OFFSET_START = 0x834;
        private const int BYTES_PER_VALUE = 4;
        private const int BYTES_PER_DIFFICULTY = BYTES_PER_VALUE * 4;

        public RankAdjustmentParser(byte[] data)
        {
            Data = data;
        }

        public DifficultyAdjustment[] GetDifficultyAdjustments()
        {
            //1 per difficulty mode
            DifficultyAdjustment[] daInfo = new DifficultyAdjustment[5];
            for(int i = 0; i < daInfo.Length; ++i)
            {
                daInfo[i] = new DifficultyAdjustment();
                daInfo[i].Difficulty = (DifficultyMode)i;
                daInfo[i].RankAdjustments = new RankAdjustment[4]; //C, B, A, S ranks (4 total)

                for(int k = 0; k < daInfo[i].RankAdjustments.Length; ++k)
                {
                    RankAdjustment raInfo = new RankAdjustment();
                    raInfo.Ranking = (Rank)k;
                    raInfo.DamageTaken = GetDifficultyDamageTakenValue(daInfo[i].Difficulty, raInfo.Ranking);
                    raInfo.DamageDealt = GetDifficultyDamageDealtValue(daInfo[i].Difficulty, raInfo.Ranking);
                    daInfo[i].RankAdjustments[k] = raInfo;
                }
            }

            return daInfo;
        }

        private float GetDifficultyDamageDealtValue(DifficultyMode mode, Rank ranking)
        {
            int dmgDealtOffset = GetDamageDealtOffset(mode);

            int valueOffset = BYTES_PER_VALUE * (int)ranking;

            return BitConverter.ToSingle(Data, dmgDealtOffset + valueOffset);
        }

        private float GetDifficultyDamageTakenValue(DifficultyMode mode, Rank ranking)
        {
            int dmgTakenOffset = GetDamageTakenOffset(mode);

            int valueOffset = BYTES_PER_VALUE * (int)ranking;

            return BitConverter.ToSingle(Data, dmgTakenOffset + valueOffset);
        }

        private int GetDamageTakenOffset(DifficultyMode mode)
        {
            return DAMAGE_TAKEN_OFFSET_START + (int)mode * BYTES_PER_DIFFICULTY;
        }

        private int GetDamageDealtOffset(DifficultyMode mode)
        {
            return DAMAGE_DEALT_OFFSET_START + (int)mode * BYTES_PER_DIFFICULTY;
        }
    }
}
