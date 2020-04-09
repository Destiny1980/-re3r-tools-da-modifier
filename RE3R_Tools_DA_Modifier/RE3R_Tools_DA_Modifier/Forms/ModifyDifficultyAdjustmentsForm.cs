using RE3R_Tools_DA_Library;
using RE3R_Tools_DA_Modifier.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RE3R_Tools_DA_Modifier.Forms
{
    public partial class ModifyDifficultyAdjustmentsForm : Form
    {
        private DifficultyAdjustment[] Adjustments;
        private ModifyDifficultyAdjustmentControl[] AdjustmentControls;

        public ModifyDifficultyAdjustmentsForm(DifficultyAdjustment[] daInfo)
        {
            InitializeComponent();

            Adjustments = daInfo;
            InitialiseDifficultyTabs();

            SaveButton.Click += (s, e) => {
                DialogResult = DialogResult.OK;
                WriteAdjustments();
                Close();
            };
            CancelButton.Click += (s, e) => Close();
        }

        private void InitialiseDifficultyTabs()
        {
            AdjustmentControls = new ModifyDifficultyAdjustmentControl[Adjustments.Length];
            DifficultiesTabControl.TabPages.Clear();

            for(int i = 0; i < Adjustments.Length; ++i)
            {
                TabPage page = CreateDifficultyTab(Adjustments[i]);
                AdjustmentControls[i] = new ModifyDifficultyAdjustmentControl(Adjustments[i]);
                AdjustmentControls[i].Dock = DockStyle.Fill;

                page.Controls.Add(AdjustmentControls[i]);
                DifficultiesTabControl.TabPages.Add(page);
            }
        }

        private TabPage CreateDifficultyTab(DifficultyAdjustment da)
        {
            TabPage difficultyPage = new TabPage($"Difficulty: {da.Difficulty.ToString()}");
            difficultyPage.Name = $"Difficulty: {da.Difficulty.ToString()} Page";

            return difficultyPage;
        }

        private void WriteAdjustments()
        {
            for(int i = 0; i < Adjustments.Length; ++i)
                Adjustments[i] = AdjustmentControls[i].GetAdjustment();
        }

        public DifficultyAdjustment[] GetAdjustments()
        {
            return Adjustments;
        }
    }
}
