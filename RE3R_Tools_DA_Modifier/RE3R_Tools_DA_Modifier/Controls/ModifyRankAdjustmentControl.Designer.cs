namespace RE3R_Tools_DA_Modifier.Controls
{
    partial class ModifyRankAdjustmentControl
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
            System.Windows.Forms.Label RankLabel;
            System.Windows.Forms.Label DamageDealtLabel;
            System.Windows.Forms.Label DamageTakenLabel;
            this.RankTextBox = new System.Windows.Forms.TextBox();
            this.DamageDealtTextBox = new System.Windows.Forms.TextBox();
            this.DamageTakenTextBox = new System.Windows.Forms.TextBox();
            RankLabel = new System.Windows.Forms.Label();
            DamageDealtLabel = new System.Windows.Forms.Label();
            DamageTakenLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RankLabel
            // 
            RankLabel.AutoSize = true;
            RankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            RankLabel.Location = new System.Drawing.Point(14, 16);
            RankLabel.Name = "RankLabel";
            RankLabel.Size = new System.Drawing.Size(55, 20);
            RankLabel.TabIndex = 0;
            RankLabel.Text = "Rank: ";
            // 
            // DamageDealtLabel
            // 
            DamageDealtLabel.AutoSize = true;
            DamageDealtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DamageDealtLabel.Location = new System.Drawing.Point(14, 45);
            DamageDealtLabel.Name = "DamageDealtLabel";
            DamageDealtLabel.Size = new System.Drawing.Size(148, 20);
            DamageDealtLabel.TabIndex = 1;
            DamageDealtLabel.Text = "Damage Dealt (%): ";
            // 
            // DamageTakenLabel
            // 
            DamageTakenLabel.AutoSize = true;
            DamageTakenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DamageTakenLabel.Location = new System.Drawing.Point(246, 45);
            DamageTakenLabel.Name = "DamageTakenLabel";
            DamageTakenLabel.Size = new System.Drawing.Size(150, 20);
            DamageTakenLabel.TabIndex = 2;
            DamageTakenLabel.Text = "Damage Taken (%):";
            // 
            // RankTextBox
            // 
            this.RankTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RankTextBox.Location = new System.Drawing.Point(67, 13);
            this.RankTextBox.MaxLength = 10;
            this.RankTextBox.Name = "RankTextBox";
            this.RankTextBox.ReadOnly = true;
            this.RankTextBox.Size = new System.Drawing.Size(67, 26);
            this.RankTextBox.TabIndex = 3;
            this.RankTextBox.Text = "S";
            this.RankTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DamageDealtTextBox
            // 
            this.DamageDealtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DamageDealtTextBox.Location = new System.Drawing.Point(168, 42);
            this.DamageDealtTextBox.MaxLength = 6;
            this.DamageDealtTextBox.Name = "DamageDealtTextBox";
            this.DamageDealtTextBox.Size = new System.Drawing.Size(69, 26);
            this.DamageDealtTextBox.TabIndex = 4;
            this.DamageDealtTextBox.Text = "100";
            // 
            // DamageTakenTextBox
            // 
            this.DamageTakenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DamageTakenTextBox.Location = new System.Drawing.Point(402, 42);
            this.DamageTakenTextBox.MaxLength = 6;
            this.DamageTakenTextBox.Name = "DamageTakenTextBox";
            this.DamageTakenTextBox.Size = new System.Drawing.Size(69, 26);
            this.DamageTakenTextBox.TabIndex = 5;
            this.DamageTakenTextBox.Text = "100";
            // 
            // ModifyRankAdjustmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DamageTakenTextBox);
            this.Controls.Add(this.DamageDealtTextBox);
            this.Controls.Add(this.RankTextBox);
            this.Controls.Add(DamageTakenLabel);
            this.Controls.Add(DamageDealtLabel);
            this.Controls.Add(RankLabel);
            this.Name = "ModifyRankAdjustmentControl";
            this.Size = new System.Drawing.Size(488, 79);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox RankTextBox;
        private System.Windows.Forms.TextBox DamageDealtTextBox;
        private System.Windows.Forms.TextBox DamageTakenTextBox;
    }
}
