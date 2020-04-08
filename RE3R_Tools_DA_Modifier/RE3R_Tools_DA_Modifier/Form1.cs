using RE3R_Tools_DA_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RE3R_Tools_DA_Modifier
{
    public partial class Form1 : Form
    {
        private const string TargetDAFile = "gamerankparameterdata.user.2";
        private byte[] FileData;

        public Form1()
        {
            InitializeComponent();

            LoadFileBtn.Click += LoadFileBtn_Click;

        }

        private void DumpDataToConsole()
        {
            if(FileData != null)
            {
                RankAdjustmentParser parser = new RankAdjustmentParser(FileData);
                var daInfo = parser.GetDifficultyAdjustments();
                foreach(var info in daInfo)
                {
                    System.Diagnostics.Debug.WriteLine($"Difficulty {info.Difficulty}");
                    foreach(var rank in info.RankAdjustments)
                    {
                        System.Diagnostics.Debug.Write($"    {rank.Ranking} DmgTaken {rank.DamageTaken * 100}%  DmgDealt {rank.DamageDealt * 100}%");
                    }
                    System.Diagnostics.Debug.WriteLine("");
                }
            }
        }

        private void LoadFileBtn_Click(object sender, EventArgs e)
        {
            using(var dialog = new OpenFileDialog())
            {
                dialog.Title = "Select " + TargetDAFile;
                dialog.Filter = "RE3R Unpacked Files (*.user.2)|*.user.2";
                dialog.InitialDirectory = Application.ExecutablePath;
                DialogResult result = dialog.ShowDialog();
                if(result == DialogResult.OK)
                {
                    FileData = System.IO.File.ReadAllBytes(dialog.FileName);
                    DumpDataToConsole();
                }
            }
        }
    }
}
