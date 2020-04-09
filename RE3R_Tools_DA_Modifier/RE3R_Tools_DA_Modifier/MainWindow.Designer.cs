namespace RE3R_Tools_DA_Modifier
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadFileBtn = new System.Windows.Forms.Button();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DifficultyInfoTabControl = new System.Windows.Forms.TabControl();
            this.AssistedTab = new System.Windows.Forms.TabPage();
            this.StandardTab = new System.Windows.Forms.TabPage();
            this.HardcoreTab = new System.Windows.Forms.TabPage();
            this.NightmareTab = new System.Windows.Forms.TabPage();
            this.InfernoTab = new System.Windows.Forms.TabPage();
            this.OptionsGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.DifficultyInfoTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadFileBtn
            // 
            this.LoadFileBtn.Location = new System.Drawing.Point(12, 19);
            this.LoadFileBtn.Name = "LoadFileBtn";
            this.LoadFileBtn.Size = new System.Drawing.Size(172, 48);
            this.LoadFileBtn.TabIndex = 0;
            this.LoadFileBtn.Text = "Load DA File";
            this.LoadFileBtn.UseVisualStyleBackColor = true;
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.Controls.Add(this.LoadFileBtn);
            this.OptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.OptionsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(882, 73);
            this.OptionsGroupBox.TabIndex = 2;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DifficultyInfoTabControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 338);
            this.panel1.TabIndex = 3;
            // 
            // DifficultyInfoTabControl
            // 
            this.DifficultyInfoTabControl.Controls.Add(this.AssistedTab);
            this.DifficultyInfoTabControl.Controls.Add(this.StandardTab);
            this.DifficultyInfoTabControl.Controls.Add(this.HardcoreTab);
            this.DifficultyInfoTabControl.Controls.Add(this.NightmareTab);
            this.DifficultyInfoTabControl.Controls.Add(this.InfernoTab);
            this.DifficultyInfoTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DifficultyInfoTabControl.Location = new System.Drawing.Point(0, 0);
            this.DifficultyInfoTabControl.Name = "DifficultyInfoTabControl";
            this.DifficultyInfoTabControl.SelectedIndex = 0;
            this.DifficultyInfoTabControl.Size = new System.Drawing.Size(882, 338);
            this.DifficultyInfoTabControl.TabIndex = 0;
            // 
            // AssistedTab
            // 
            this.AssistedTab.Location = new System.Drawing.Point(4, 22);
            this.AssistedTab.Name = "AssistedTab";
            this.AssistedTab.Padding = new System.Windows.Forms.Padding(3);
            this.AssistedTab.Size = new System.Drawing.Size(874, 312);
            this.AssistedTab.TabIndex = 0;
            this.AssistedTab.Text = "Assisted Difficulty";
            this.AssistedTab.UseVisualStyleBackColor = true;
            // 
            // StandardTab
            // 
            this.StandardTab.Location = new System.Drawing.Point(4, 22);
            this.StandardTab.Name = "StandardTab";
            this.StandardTab.Padding = new System.Windows.Forms.Padding(3);
            this.StandardTab.Size = new System.Drawing.Size(874, 312);
            this.StandardTab.TabIndex = 1;
            this.StandardTab.Text = "Standard Difficulty";
            this.StandardTab.UseVisualStyleBackColor = true;
            // 
            // HardcoreTab
            // 
            this.HardcoreTab.Location = new System.Drawing.Point(4, 22);
            this.HardcoreTab.Name = "HardcoreTab";
            this.HardcoreTab.Size = new System.Drawing.Size(874, 312);
            this.HardcoreTab.TabIndex = 2;
            this.HardcoreTab.Text = "Hardcore Difficulty";
            this.HardcoreTab.UseVisualStyleBackColor = true;
            // 
            // NightmareTab
            // 
            this.NightmareTab.Location = new System.Drawing.Point(4, 22);
            this.NightmareTab.Name = "NightmareTab";
            this.NightmareTab.Size = new System.Drawing.Size(874, 312);
            this.NightmareTab.TabIndex = 3;
            this.NightmareTab.Text = "Nightmare Difficulty";
            this.NightmareTab.UseVisualStyleBackColor = true;
            // 
            // InfernoTab
            // 
            this.InfernoTab.Location = new System.Drawing.Point(4, 22);
            this.InfernoTab.Name = "InfernoTab";
            this.InfernoTab.Size = new System.Drawing.Size(874, 312);
            this.InfernoTab.TabIndex = 4;
            this.InfernoTab.Text = "Inferno Difficulty";
            this.InfernoTab.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OptionsGroupBox);
            this.Name = "MainWindow";
            this.Text = "Resident Evil 3 Remake: Difficulty Adjustment (Damage)";
            this.OptionsGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.DifficultyInfoTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadFileBtn;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl DifficultyInfoTabControl;
        private System.Windows.Forms.TabPage AssistedTab;
        private System.Windows.Forms.TabPage StandardTab;
        private System.Windows.Forms.TabPage HardcoreTab;
        private System.Windows.Forms.TabPage NightmareTab;
        private System.Windows.Forms.TabPage InfernoTab;
    }
}

