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

        public static readonly DifficultyAdjustment[] DefaultDamageAdjustments = { 
            new DifficultyAdjustment() { 
                Difficulty = DifficultyMode.Assisted, 
                RankAdjustments = new RankAdjustment[] {
                    new RankAdjustment() {
                        Ranking = Rank.C,
                        DamageDealt = 1.8f,
                        DamageTaken = 0.7f
                    },
                    new RankAdjustment() {
                        Ranking = Rank.B,
                        DamageDealt = 1.6f,
                        DamageTaken = 0.7f
                    },
                    new RankAdjustment() {
                        Ranking = Rank.A,
                        DamageDealt = 1.4f,
                        DamageTaken = 0.8f
                    },
                    new RankAdjustment() {
                        Ranking = Rank.S,
                        DamageDealt = 1.2f,
                        DamageTaken = 0.8f
                    }
                }
            },
            new DifficultyAdjustment() {
                Difficulty = DifficultyMode.Standard,
                RankAdjustments = new RankAdjustment[] {
                    new RankAdjustment() {
                        Ranking = Rank.C,
                        DamageDealt = 1.1f,
                        DamageTaken = 0.9f
                    },
                    new RankAdjustment() {
                        Ranking = Rank.B,
                        DamageDealt = 1.0f,
                        DamageTaken = 1.0f
                    },
                    new RankAdjustment() {
                        Ranking = Rank.A,
                        DamageDealt = 0.9f,
                        DamageTaken = 1.2f
                    },
                    new RankAdjustment() {
                        Ranking = Rank.S,
                        DamageDealt = 0.8f,
                        DamageTaken = 1.6f
                    }
                }
            },
            new DifficultyAdjustment() {
                Difficulty = DifficultyMode.Hardcore,
                RankAdjustments = new RankAdjustment[] {
                    new RankAdjustment() {
                        Ranking = Rank.C,
                        DamageDealt = 0.7f,
                        DamageTaken = 2.0f
                    },
                    new RankAdjustment() {
                        Ranking = Rank.B,
                        DamageDealt = 0.65f,
                        DamageTaken = 2.8f
                    },
                    new RankAdjustment() {
                        Ranking = Rank.A,
                        DamageDealt = 0.9f,
                        DamageTaken = 3.25f
                    },
                    new RankAdjustment() {
                        Ranking = Rank.S,
                        DamageDealt = 0.85f,
                        DamageTaken = 3.3f
                    }
                }
            },
            new DifficultyAdjustment() {
                Difficulty = DifficultyMode.Nightmare,
                RankAdjustments = new RankAdjustment[] {
                    new RankAdjustment() {
                        Ranking = Rank.C,
                        DamageDealt = 0.8f,
                        DamageTaken = 3.35f
                    },
                    new RankAdjustment() {
                        Ranking = Rank.B,
                        DamageDealt = 0.75f,
                        DamageTaken = 3.4f
                    },
                    new RankAdjustment() {
                        Ranking = Rank.A,
                        DamageDealt = 0.7f,
                        DamageTaken = 3.45f
                    },
                    new RankAdjustment() {
                        Ranking = Rank.S,
                        DamageDealt = 0.6f,
                        DamageTaken = 3.5f
                    }
                }
            },
            new DifficultyAdjustment() {
                Difficulty = DifficultyMode.Inferno,
                RankAdjustments = new RankAdjustment[] {
                    new RankAdjustment() {
                        Ranking = Rank.C,
                        DamageDealt = 0.5f,
                        DamageTaken = 3.6f
                    },
                    new RankAdjustment() {
                        Ranking = Rank.B,
                        DamageDealt = 0.5f,
                        DamageTaken = 3.6f
                    },
                    new RankAdjustment() {
                        Ranking = Rank.A,
                        DamageDealt = 0.5f,
                        DamageTaken = 3.6f
                    },
                    new RankAdjustment() {
                        Ranking = Rank.S,
                        DamageDealt = 0.5f,
                        DamageTaken = 3.6f
                    }
                }
            }
        };
    }
}
