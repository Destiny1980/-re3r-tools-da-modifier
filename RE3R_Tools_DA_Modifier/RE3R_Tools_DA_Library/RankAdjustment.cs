namespace RE3R_Tools_DA_Library
{
    public enum Rank
    {
        C,
        B,
        A,
        S
    }

    public struct RankAdjustment
    {
        public Rank Ranking;
        public float DamageTaken;
        public float DamageDealt;
    }
}
