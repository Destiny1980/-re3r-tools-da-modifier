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
    public partial class ModifyDifficultyAdjustmentControl : UserControl
    {
        private DifficultyAdjustment Adjustment;
        private ModifyRankAdjustmentControl[] RankModifiers;

        public ModifyDifficultyAdjustmentControl(DifficultyAdjustment adjustment)
        {
            InitializeComponent();
            Adjustment = adjustment;
            InitialiseTabControl();
        }

        private void InitialiseTabControl()
        {
            RankModifiers = new ModifyRankAdjustmentControl[Adjustment.RankAdjustments.Length];
            RankAdjustment[] ranks = Adjustment.RankAdjustments;

            RanksTabControl.TabPages.Clear();

            for(int i = 0; i < ranks.Length; ++i)
            {
                TabPage rankPage = CreateRankTab(ranks[i]);
                RankModifiers[i] = new ModifyRankAdjustmentControl(ranks[i]);
                RankModifiers[i].Dock = DockStyle.Fill;

                rankPage.Controls.Add(RankModifiers[i]);
                RanksTabControl.TabPages.Add(rankPage);
            }
        }

        private TabPage CreateRankTab(RankAdjustment ra)
        {
            TabPage rankPage = new TabPage($"Rank {ra.Ranking.ToString()}");
            rankPage.Name = $"Rank {ra.Ranking.ToString()} Page";

            return rankPage;
        }

        public DifficultyAdjustment GetAdjustment()
        {
            for(int i = 0; i < RankModifiers.Length; ++i)
                Adjustment.RankAdjustments[i] = RankModifiers[i].GetRankAdjustmentInfo();

            return Adjustment;
        }
    }
}
