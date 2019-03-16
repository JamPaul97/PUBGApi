namespace TestEnviroment.Bodys
{
    partial class PlayersPossitionForm
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
            this.chargb = new System.Windows.Forms.GroupBox();
            this.vehiclegb = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label14 = new System.Windows.Forms.Label();
            this.lblEllapseTime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblalivePlayers = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTimestamp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chargb
            // 
            this.chargb.Location = new System.Drawing.Point(3, 3);
            this.chargb.Name = "chargb";
            this.chargb.Size = new System.Drawing.Size(368, 131);
            this.chargb.TabIndex = 13;
            this.chargb.TabStop = false;
            this.chargb.Text = "Character";
            // 
            // vehiclegb
            // 
            this.vehiclegb.Location = new System.Drawing.Point(3, 140);
            this.vehiclegb.Name = "vehiclegb";
            this.vehiclegb.Size = new System.Drawing.Size(368, 57);
            this.vehiclegb.TabIndex = 14;
            this.vehiclegb.TabStop = false;
            this.vehiclegb.Text = "Vehicle";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(9, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "Elapsed Time";
            // 
            // lblEllapseTime
            // 
            this.lblEllapseTime.AutoSize = true;
            this.lblEllapseTime.Location = new System.Drawing.Point(9, 217);
            this.lblEllapseTime.Name = "lblEllapseTime";
            this.lblEllapseTime.Size = new System.Drawing.Size(77, 13);
            this.lblEllapseTime.TabIndex = 22;
            this.lblEllapseTime.Text = "$Elapsed Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(134, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Alive Players";
            // 
            // lblalivePlayers
            // 
            this.lblalivePlayers.AutoSize = true;
            this.lblalivePlayers.Location = new System.Drawing.Point(134, 217);
            this.lblalivePlayers.Name = "lblalivePlayers";
            this.lblalivePlayers.Size = new System.Drawing.Size(73, 13);
            this.lblalivePlayers.TabIndex = 24;
            this.lblalivePlayers.Text = "$Alive Players";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(244, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Timestamp";
            // 
            // lblTimestamp
            // 
            this.lblTimestamp.AutoSize = true;
            this.lblTimestamp.Location = new System.Drawing.Point(244, 217);
            this.lblTimestamp.Name = "lblTimestamp";
            this.lblTimestamp.Size = new System.Drawing.Size(60, 13);
            this.lblTimestamp.TabIndex = 26;
            this.lblTimestamp.Text = "$timestamp";
            // 
            // PlayersPossition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTimestamp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblalivePlayers);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblEllapseTime);
            this.Controls.Add(this.vehiclegb);
            this.Controls.Add(this.chargb);
            this.Name = "PlayersPossition";
            this.Size = new System.Drawing.Size(376, 235);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox chargb;
        private System.Windows.Forms.GroupBox vehiclegb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblEllapseTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblalivePlayers;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTimestamp;
    }
}
