using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RE3R_Tools_DA_Library;

namespace RE3R_Tools_DA_Modifier.Controls
{
    public partial class ModifyRankAdjustmentControl : UserControl
    {
        private RankAdjustment AdjustmentInfo;
        public ModifyRankAdjustmentControl(RankAdjustment info)
        {
            InitializeComponent();

            AdjustmentInfo = info;
            InitialiseControls();
        }

        public RankAdjustment GetRankAdjustmentInfo()
        {
            AdjustmentInfo.DamageDealt = GetDamageValue(DamageDealtTextBox);
            AdjustmentInfo.DamageTaken = GetDamageValue(DamageTakenTextBox);

            return AdjustmentInfo;
        }

        private float GetDamageValue(TextBox textBox)
        {
            if (float.TryParse(textBox.Text, out float value))
                return value/100;

            return 1;
        }

        private void InitialiseControls()
        {
            RankTextBox.Text = AdjustmentInfo.Ranking.ToString();
            DamageDealtTextBox.Text = $"{AdjustmentInfo.DamageDealt * 100}";
            DamageTakenTextBox.Text = $"{AdjustmentInfo.DamageTaken * 100}";
        }
    }
}
