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
    public partial class DifficultyAdjustmentDisplayControl : UserControl
    {
        private DifficultyAdjustment AdjustmentInfo;
        public DifficultyAdjustmentDisplayControl()
        {
            InitializeComponent();
        }

        public void SetDifficultyAdjustmentInfo(DifficultyAdjustment adjustment)
        {
            AdjustmentInfo = adjustment;
            DisplayAdjustmentInfo(AdjustmentInfo);
        }

        private void DisplayAdjustmentInfo(DifficultyAdjustment info)
        {
            RankAdjustmentControl1.SetRankAdjustmentInfo(info.RankAdjustments[0]);
            RankAdjustmentControl2.SetRankAdjustmentInfo(info.RankAdjustments[1]);
            RankAdjustmentControl3.SetRankAdjustmentInfo(info.RankAdjustments[2]);
            RankAdjustmentControl4.SetRankAdjustmentInfo(info.RankAdjustments[3]);
        }
    }
}
