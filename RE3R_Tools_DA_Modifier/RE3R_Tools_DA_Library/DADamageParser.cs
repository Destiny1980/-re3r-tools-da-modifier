using System;

namespace RE3R_Tools_DA_Library
{
    public class DADamageParser
    {
        private byte[] Data;
        private const int DAMAGE_TAKEN_OFFSET = 0x7E0;
        private const int DAMAGE_DEALT_OFFSET = 0x834;
        private const int BYTES_PER_VALUE = 4;
        private const int RANK_COUNT = 20; // 0 ~ 19
        private readonly float[] DEFAULT_DAMAGE_DEALT = { 
            1.8f, 1.6f, 1.4f, 1.2f, 1.1f,
            1.0f, 0.9f, 0.8f, 0.7f, 0.65f,
            0.9f, 0.85f, 0.8f, 0.75f, 0.7f,
            0.6f, 0.5f, 0.5f, 0.5f, 0.5f
        };
        private readonly float[] DEFAULT_DAMAGE_TAKEN = {
            0.7f, 0.7f, 0.8f, 0.8f, 0.9f,
            1.0f, 1.2f, 1.6f, 2.0f, 2.8f,
            3.25f, 3.3f, 3.35f, 3.4f, 3.45f,
            3.5f, 3.6f, 3.6f, 3.6f, 3.6f
        };

        public DADamageParser(byte[] data)
        {
            Data = data;
        }

        public byte[] GetData()
        {
            return Data;
        }

        public void SetDamageTaken(float[] values)
        {
            SetDamageValues(DAMAGE_TAKEN_OFFSET, values);
        }

        public void SetDamageDealt(float[] values)
        {
            SetDamageValues(DAMAGE_DEALT_OFFSET, values);
        }

        private void SetDamageValues(int offsetStart, float[] values)
        {
            for (int i = 0; i < RANK_COUNT; ++i)
            {
                int offset = offsetStart + i * BYTES_PER_VALUE;
                var bytes = BitConverter.GetBytes(values[i]);
                bytes.CopyTo(Data, offset);
            }
        }

        public float[] GetDamageTaken()
        {
            return GetDamageValues(DAMAGE_TAKEN_OFFSET);
        }

        public float[] GetDamageDealt()
        {
            return GetDamageValues(DAMAGE_DEALT_OFFSET);
        }

        private float[] GetDamageValues(int offsetStart)
        {
            float[] values = new float[RANK_COUNT];
            for (int i = 0; i < RANK_COUNT; ++i)
            {
                int offset = offsetStart + i * BYTES_PER_VALUE;
                values[i] = BitConverter.ToSingle(Data, offset);
            }

            return values;
        }

        public float[] GetDefaultDamageDealt()
        {
            return DEFAULT_DAMAGE_DEALT;
        }

        public float[] GetDefaultDamageTaken()
        {
            return DEFAULT_DAMAGE_TAKEN;
        }
    }
}
