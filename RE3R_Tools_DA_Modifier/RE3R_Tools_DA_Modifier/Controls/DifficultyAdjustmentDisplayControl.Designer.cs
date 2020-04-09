namespace RE3R_Tools_DA_Modifier.Controls
{
    partial class DifficultyAdjustmentDisplayControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RankLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RankAdjustmentControl1 = new RE3R_Tools_DA_Modifier.Controls.RankAdjustmentDisplayControl();
            this.RankAdjustmentControl2 = new RE3R_Tools_DA_Modifier.Controls.RankAdjustmentDisplayControl();
            this.RankAdjustmentControl3 = new RE3R_Tools_DA_Modifier.Controls.RankAdjustmentDisplayControl();
            this.RankAdjustmentControl4 = new RE3R_Tools_DA_Modifier.Controls.RankAdjustmentDisplayControl();
            this.RankLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RankLayoutPanel
            // 
            this.RankLayoutPanel.AutoScroll = true;
            this.RankLayoutPanel.Controls.Add(this.RankAdjustmentControl1);
            this.RankLayoutPanel.Controls.Add(this.RankAdjustmentControl2);
            this.RankLayoutPanel.Controls.Add(this.RankAdjustmentControl3);
            this.RankLayoutPanel.Controls.Add(this.RankAdjustmentControl4);
            this.RankLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RankLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.RankLayoutPanel.Name = "RankLayoutPanel";
            this.RankLayoutPanel.Size = new System.Drawing.Size(874, 302);
            this.RankLayoutPanel.TabIndex = 1;
            // 
            // RankAdjustmentControl1
            // 
            this.RankAdjustmentControl1.Location = new System.Drawing.Point(3, 3);
            this.RankAdjustmentControl1.Name = "RankAdjustmentControl1";
            this.RankAdjustmentControl1.Size = new System.Drawing.Size(213, 293);
            this.RankAdjustmentControl1.TabIndex = 0;
            // 
            // RankAdjustmentControl2
            // 
            this.RankAdjustmentControl2.Location = new System.Drawing.Point(222, 3);
            this.RankAdjustmentControl2.Name = "RankAdjustmentControl2";
            this.RankAdjustmentControl2.Size = new System.Drawing.Size(211, 293);
            this.RankAdjustmentControl2.TabIndex = 1;
            // 
            // RankAdjustmentControl3
            // 
            this.RankAdjustmentControl3.Location = new System.Drawing.Point(439, 3);
            this.RankAdjustmentControl3.Name = "RankAdjustmentControl3";
            this.RankAdjustmentControl3.Size = new System.Drawing.Size(210, 293);
            this.RankAdjustmentControl3.TabIndex = 2;
            // 
            // RankAdjustmentControl4
            // 
            this.RankAdjustmentControl4.Location = new System.Drawing.Point(655, 3);
            this.RankAdjustmentControl4.Name = "RankAdjustmentControl4";
            this.RankAdjustmentControl4.Size = new System.Drawing.Size(210, 293);
            this.RankAdjustmentControl4.TabIndex = 3;
            // 
            // DifficultyAdjustmentDisplayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RankLayoutPanel);
            this.Name = "DifficultyAdjustmentDisplayControl";
            this.Size = new System.Drawing.Size(874, 302);
            this.RankLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel RankLayoutPanel;
        private RankAdjustmentDisplayControl RankAdjustmentControl1;
        private RankAdjustmentDisplayControl RankAdjustmentControl2;
        private RankAdjustmentDisplayControl RankAdjustmentControl3;
        private RankAdjustmentDisplayControl RankAdjustmentControl4;
    }
}
