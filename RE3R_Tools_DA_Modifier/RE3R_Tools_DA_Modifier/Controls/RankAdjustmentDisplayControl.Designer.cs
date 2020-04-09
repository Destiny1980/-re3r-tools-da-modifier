namespace RE3R_Tools_DA_Modifier.Controls
{
    partial class RankAdjustmentDisplayControl
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
            System.Windows.Forms.Label DamageDealtLabel;
            System.Windows.Forms.Label DamageTakenLabel;
            System.Windows.Forms.Label RankLabel;
            System.Windows.Forms.GroupBox RankGroupBox;
            System.Windows.Forms.GroupBox DamageGroupBox;
            this.RankTextBox = new System.Windows.Forms.TextBox();
            this.DamageDealtTextBox = new System.Windows.Forms.TextBox();
            this.DamageTakenTextBox = new System.Windows.Forms.TextBox();
            this.AdjustmentInfoTextBox = new System.Windows.Forms.RichTextBox();
            DamageDealtLabel = new System.Windows.Forms.Label();
            DamageTakenLabel = new System.Windows.Forms.Label();
            RankLabel = new System.Windows.Forms.Label();
            RankGroupBox = new System.Windows.Forms.GroupBox();
            DamageGroupBox = new System.Windows.Forms.GroupBox();
            RankGroupBox.SuspendLayout();
            DamageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DamageDealtLabel
            // 
            DamageDealtLabel.AutoSize = true;
            DamageDealtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DamageDealtLabel.Location = new System.Drawing.Point(6, 22);
            DamageDealtLabel.Name = "DamageDealtLabel";
            DamageDealtLabel.Size = new System.Drawing.Size(129, 20);
            DamageDealtLabel.TabIndex = 0;
            DamageDealtLabel.Text = "Damage Dealt:";
            // 
            // DamageTakenLabel
            // 
            DamageTakenLabel.AutoSize = true;
            DamageTakenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DamageTakenLabel.Location = new System.Drawing.Point(6, 51);
            DamageTakenLabel.Name = "DamageTakenLabel";
            DamageTakenLabel.Size = new System.Drawing.Size(135, 20);
            DamageTakenLabel.TabIndex = 2;
            DamageTakenLabel.Text = "Damage Taken:";
            // 
            // RankLabel
            // 
            RankLabel.AutoSize = true;
            RankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            RankLabel.Location = new System.Drawing.Point(6, 16);
            RankLabel.Name = "RankLabel";
            RankLabel.Size = new System.Drawing.Size(63, 24);
            RankLabel.TabIndex = 4;
            RankLabel.Text = "Rank:";
            // 
            // RankGroupBox
            // 
            RankGroupBox.Controls.Add(this.RankTextBox);
            RankGroupBox.Controls.Add(RankLabel);
            RankGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            RankGroupBox.Location = new System.Drawing.Point(0, 0);
            RankGroupBox.Name = "RankGroupBox";
            RankGroupBox.Size = new System.Drawing.Size(220, 54);
            RankGroupBox.TabIndex = 6;
            RankGroupBox.TabStop = false;
            RankGroupBox.Text = "Player Performance";
            // 
            // RankTextBox
            // 
            this.RankTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RankTextBox.Location = new System.Drawing.Point(75, 13);
            this.RankTextBox.MaxLength = 10;
            this.RankTextBox.Name = "RankTextBox";
            this.RankTextBox.ReadOnly = true;
            this.RankTextBox.Size = new System.Drawing.Size(54, 29);
            this.RankTextBox.TabIndex = 5;
            this.RankTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DamageGroupBox
            // 
            DamageGroupBox.Controls.Add(DamageDealtLabel);
            DamageGroupBox.Controls.Add(this.DamageDealtTextBox);
            DamageGroupBox.Controls.Add(this.DamageTakenTextBox);
            DamageGroupBox.Controls.Add(DamageTakenLabel);
            DamageGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            DamageGroupBox.Location = new System.Drawing.Point(0, 54);
            DamageGroupBox.Name = "DamageGroupBox";
            DamageGroupBox.Size = new System.Drawing.Size(220, 82);
            DamageGroupBox.TabIndex = 7;
            DamageGroupBox.TabStop = false;
            DamageGroupBox.Text = "Damage Modification";
            // 
            // DamageDealtTextBox
            // 
            this.DamageDealtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DamageDealtTextBox.Location = new System.Drawing.Point(141, 19);
            this.DamageDealtTextBox.MaxLength = 10;
            this.DamageDealtTextBox.Name = "DamageDealtTextBox";
            this.DamageDealtTextBox.ReadOnly = true;
            this.DamageDealtTextBox.Size = new System.Drawing.Size(61, 26);
            this.DamageDealtTextBox.TabIndex = 1;
            // 
            // DamageTakenTextBox
            // 
            this.DamageTakenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DamageTakenTextBox.Location = new System.Drawing.Point(141, 48);
            this.DamageTakenTextBox.MaxLength = 10;
            this.DamageTakenTextBox.Name = "DamageTakenTextBox";
            this.DamageTakenTextBox.ReadOnly = true;
            this.DamageTakenTextBox.Size = new System.Drawing.Size(61, 26);
            this.DamageTakenTextBox.TabIndex = 3;
            // 
            // AdjustmentInfoTextBox
            // 
            this.AdjustmentInfoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdjustmentInfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdjustmentInfoTextBox.Location = new System.Drawing.Point(0, 136);
            this.AdjustmentInfoTextBox.MaxLength = 5000;
            this.AdjustmentInfoTextBox.Name = "AdjustmentInfoTextBox";
            this.AdjustmentInfoTextBox.ReadOnly = true;
            this.AdjustmentInfoTextBox.Size = new System.Drawing.Size(220, 98);
            this.AdjustmentInfoTextBox.TabIndex = 8;
            this.AdjustmentInfoTextBox.Text = "";
            // 
            // RankAdjustmentDisplayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AdjustmentInfoTextBox);
            this.Controls.Add(DamageGroupBox);
            this.Controls.Add(RankGroupBox);
            this.Name = "RankAdjustmentDisplayControl";
            this.Size = new System.Drawing.Size(220, 234);
            RankGroupBox.ResumeLayout(false);
            RankGroupBox.PerformLayout();
            DamageGroupBox.ResumeLayout(false);
            DamageGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox DamageDealtTextBox;
        private System.Windows.Forms.TextBox DamageTakenTextBox;
        private System.Windows.Forms.TextBox RankTextBox;
        private System.Windows.Forms.RichTextBox AdjustmentInfoTextBox;
    }
}
