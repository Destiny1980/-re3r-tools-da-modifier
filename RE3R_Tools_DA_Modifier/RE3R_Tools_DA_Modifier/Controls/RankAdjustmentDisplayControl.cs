using System.Windows.Forms;
using RE3R_Tools_DA_Library;

namespace RE3R_Tools_DA_Modifier.Controls
{
    public partial class RankAdjustmentDisplayControl : UserControl
    {
        private RankAdjustment AdjustmentInfo;
        public RankAdjustmentDisplayControl()
        {
            InitializeComponent();
        }

        public void SetRankAdjustmentInfo(RankAdjustment adjustment)
        {
            AdjustmentInfo = adjustment;
            DisplayAdjustmentInfo(AdjustmentInfo);
        }

        private void DisplayAdjustmentInfo(RankAdjustment info)
        {
            DamageDealtTextBox.Text = info.DamageDealt.ToString();
            DamageTakenTextBox.Text = info.DamageTaken.ToString();
            RankTextBox.Text = info.Ranking.ToString();

            AdjustmentInfoTextBox.Text = $"When the player's skill is around {info.Ranking} rank:\n" +
                $"\nPlayer does {info.DamageDealt*100}% damage." +
                $"\nPlayer takes {info.DamageTaken*100}% damage.";
        }
    }
}
