using RE3R_Tools_DA_Library;
using System;
using System.Windows.Forms;

namespace RE3R_Tools_DA_Modifier
{
    public partial class MainWindow : Form
    {
        private const string TargetDAFile = "gamerankparameterdata.user.2";
        private DADamageParser DA_Parser;

        public MainWindow()
        {
            InitializeComponent();

            LoadFileBtn.Click += LoadFileBtn_Click;
            SaveButton.Click += (s, e) => SaveFile();
            ResetToDefaultButton.Click += ResetToDefaultButton_Click;
        }

        private void ResetToDefaultButton_Click(object sender, EventArgs e)
        {
            displayDADamageGrid1.ResetToDefault();
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
                    var data = displayDADamageGrid1.GetDataToSave();
                    System.IO.File.WriteAllBytes(saveDialog.FileName, data);
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
                    byte[] data = System.IO.File.ReadAllBytes(dialog.FileName);
                    ResetToDefaultButton.Enabled = true;
                    DisplayFileData(data);
                }
            }
        }

        private void DisplayFileData(byte[] fileData)
        {
            if (fileData == null)
                return;

            DADamageParser daParser = new DADamageParser(fileData);
            foreach (var value in daParser.GetDamageTaken())
                System.Diagnostics.Debug.WriteLine(value);

            displayDADamageGrid1.ParseFileData(fileData);
            SaveButton.Enabled = true;
        }
    }
}
