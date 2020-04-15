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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.LoadFileBtn = new System.Windows.Forms.Button();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.ResetToDefaultButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.displayDADamageGrid1 = new RE3R_Tools_DA_Modifier.Controls.DisplayDADamageGrid();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.OptionsGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.OptionsGroupBox.Controls.Add(this.ResetToDefaultButton);
            this.OptionsGroupBox.Controls.Add(this.SaveButton);
            this.OptionsGroupBox.Controls.Add(this.LoadFileBtn);
            this.OptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.OptionsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(744, 73);
            this.OptionsGroupBox.TabIndex = 2;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            // 
            // ResetToDefaultButton
            // 
            this.ResetToDefaultButton.Enabled = false;
            this.ResetToDefaultButton.Location = new System.Drawing.Point(395, 20);
            this.ResetToDefaultButton.Name = "ResetToDefaultButton";
            this.ResetToDefaultButton.Size = new System.Drawing.Size(106, 47);
            this.ResetToDefaultButton.TabIndex = 3;
            this.ResetToDefaultButton.Text = "Reset to Default";
            this.ResetToDefaultButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(235, 19);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(112, 47);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save DA File";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.displayDADamageGrid1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 338);
            this.panel1.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(437, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 338);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // displayDADamageGrid1
            // 
            this.displayDADamageGrid1.Dock = System.Windows.Forms.DockStyle.Left;
            this.displayDADamageGrid1.Location = new System.Drawing.Point(0, 0);
            this.displayDADamageGrid1.Name = "displayDADamageGrid1";
            this.displayDADamageGrid1.Size = new System.Drawing.Size(437, 338);
            this.displayDADamageGrid1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(440, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(304, 338);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OptionsGroupBox);
            this.Name = "MainWindow";
            this.Text = "Resident Evil 3 Remake: Difficulty Adjustment (Damage) by Moehammered";
            this.OptionsGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadFileBtn;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ResetToDefaultButton;
        private System.Windows.Forms.Splitter splitter1;
        private Controls.DisplayDADamageGrid displayDADamageGrid1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

