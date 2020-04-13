using RE3R_Tools_DA_Library;
using RE3R_Tools_DA_Modifier.Controls;
using RE3R_Tools_DA_Modifier.Forms;
using System;
using System.Windows.Forms;

namespace RE3R_Tools_DA_Modifier
{
    public partial class MainWindow : Form
    {
        private const string TargetDAFile = "gamerankparameterdata.user.2";
        private byte[] FileData;
        private byte[] DataToSave;

        private DifficultyAdjustmentDisplayControl[] AdjustmentDisplays;

        public MainWindow()
        {
            InitializeComponent();

            LoadFileBtn.Click += LoadFileBtn_Click;
            InitialiseAdjustmentDisplayControls();

            ModifyDAButton.Click += DisplayModifyForm;
            SaveButton.Click += (s, e) => SaveFile();
            ResetToDefaultButton.Click += ResetToDefaultButton_Click;
        }

        private void ResetToDefaultButton_Click(object sender, EventArgs e)
        {
            RankAdjustmentParser parser = new RankAdjustmentParser(FileData);
            DataToSave = parser.BuildFileData(DifficultyAdjustment.DefaultDamageAdjustments);
            FileData = DataToSave;
            DisplayFileData();
        }

        private void DisplayModifyForm(object sender, EventArgs e)
        {
            RankAdjustmentParser parser = new RankAdjustmentParser(FileData);
            var daInfo = parser.GetDifficultyAdjustments();
            using (ModifyDifficultyAdjustmentsForm form = new ModifyDifficultyAdjustmentsForm(daInfo))
            {
                DialogResult result = form.ShowDialog();
                System.Diagnostics.Debug.WriteLine(result);
                if(result == DialogResult.OK)
                {
                    daInfo = form.GetAdjustments();

                    for (int i = 0; i < daInfo.Length && i < DifficultyInfoTabControl.TabPages.Count; ++i)
                    {
                        DifficultyInfoTabControl.TabPages[i].Text = daInfo[i].Difficulty.ToString();
                        AdjustmentDisplays[i].SetDifficultyAdjustmentInfo(daInfo[i]);
                    }

                    DataToSave = parser.BuildFileData(daInfo);
                    SaveButton.Enabled = true;
                }
            }
        }

        private void SaveFile()
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.InitialDirectory = Application.ExecutablePath;
                saveDialog.Title = "Save" + TargetDAFile;
                saveDialog.Filter = "RE3R Unpacked Files (*.user.2)|*.user.2";
                var saveResult = saveDialog.ShowDialog();
                if (saveResult == DialogResult.OK)
                {
                    System.IO.File.WriteAllBytes(saveDialog.FileName, DataToSave);
                }
            }
        }

        private void InitialiseAdjustmentDisplayControls()
        {
            AdjustmentDisplays = new DifficultyAdjustmentDisplayControl[DifficultyInfoTabControl.TabCount]; // 5 difficulties

            for(int i = 0; i < DifficultyInfoTabControl.TabCount; ++i)
            {
                AdjustmentDisplays[i] = new DifficultyAdjustmentDisplayControl();
                DifficultyInfoTabControl.TabPages[i].Controls.Add(AdjustmentDisplays[i]);
                AdjustmentDisplays[i].Dock = DockStyle.Fill;
            }
        }

        private void DumpDataToConsole()
        {
            if(FileData != null)
            {
                RankAdjustmentParser parser = new RankAdjustmentParser(FileData);
                var daInfo = parser.GetDifficultyAdjustments();
                foreach (var info in daInfo)
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
                if (result == DialogResult.OK)
                {
                    FileData = System.IO.File.ReadAllBytes(dialog.FileName);
                    DumpDataToConsole();
                    DisplayFileData();
                    ModifyDAButton.Enabled = true;
                    ResetToDefaultButton.Enabled = true;
                }
                else
                    ModifyDAButton.Enabled = false;
            }
        }

        private void DisplayFileData()
        {
            if (FileData == null)
                return;

            RankAdjustmentParser parser = new RankAdjustmentParser(FileData);
            var daInfo = parser.GetDifficultyAdjustments();

            for(int i = 0; i < daInfo.Length && i < DifficultyInfoTabControl.TabPages.Count; ++i)
            {
                DifficultyInfoTabControl.TabPages[i].Text = daInfo[i].Difficulty.ToString();
                AdjustmentDisplays[i].SetDifficultyAdjustmentInfo(daInfo[i]);
            }
        }
    }
}
