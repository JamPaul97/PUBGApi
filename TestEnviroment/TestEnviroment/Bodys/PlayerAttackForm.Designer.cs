namespace TestEnviroment.Bodys
{
    partial class PlayerAttackForm
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
            this.weapongb = new System.Windows.Forms.GroupBox();
            this.vehiclegb = new System.Windows.Forms.GroupBox();
            this.lblAttackID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblfireWeaponStackCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAttackType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTimeStamp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chargb
            // 
            this.chargb.Location = new System.Drawing.Point(3, 3);
            this.chargb.Name = "chargb";
            this.chargb.Size = new System.Drawing.Size(368, 131);
            this.chargb.TabIndex = 14;
            this.chargb.TabStop = false;
            this.chargb.Text = "Attacker";
            // 
            // weapongb
            // 
            this.weapongb.Location = new System.Drawing.Point(3, 140);
            this.weapongb.Name = "weapongb";
            this.weapongb.Size = new System.Drawing.Size(368, 98);
            this.weapongb.TabIndex = 15;
            this.weapongb.TabStop = false;
            this.weapongb.Text = "Weapon";
            // 
            // vehiclegb
            // 
            this.vehiclegb.Location = new System.Drawing.Point(3, 244);
            this.vehiclegb.Name = "vehiclegb";
            this.vehiclegb.Size = new System.Drawing.Size(368, 45);
            this.vehiclegb.TabIndex = 16;
            this.vehiclegb.TabStop = false;
            this.vehiclegb.Text = "Vehicle";
            // 
            // lblAttackID
            // 
            this.lblAttackID.AutoSize = true;
            this.lblAttackID.Location = new System.Drawing.Point(3, 309);
            this.lblAttackID.Name = "lblAttackID";
            this.lblAttackID.Size = new System.Drawing.Size(54, 13);
            this.lblAttackID.TabIndex = 25;
            this.lblAttackID.Text = "$attackID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(3, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "AttackID";
            // 
            // lblfireWeaponStackCount
            // 
            this.lblfireWeaponStackCount.AutoSize = true;
            this.lblfireWeaponStackCount.Location = new System.Drawing.Point(99, 309);
            this.lblfireWeaponStackCount.Name = "lblfireWeaponStackCount";
            this.lblfireWeaponStackCount.Size = new System.Drawing.Size(124, 13);
            this.lblfireWeaponStackCount.TabIndex = 27;
            this.lblfireWeaponStackCount.Text = "$fireWeaponStackCount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(99, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "FireWeaponStackCount";
            // 
            // lblAttackType
            // 
            this.lblAttackType.AutoSize = true;
            this.lblAttackType.Location = new System.Drawing.Point(283, 309);
            this.lblAttackType.Name = "lblAttackType";
            this.lblAttackType.Size = new System.Drawing.Size(67, 13);
            this.lblAttackType.TabIndex = 29;
            this.lblAttackType.Text = "$attackType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(283, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Attack Type";
            // 
            // lblTimeStamp
            // 
            this.lblTimeStamp.AutoSize = true;
            this.lblTimeStamp.Location = new System.Drawing.Point(140, 349);
            this.lblTimeStamp.Name = "lblTimeStamp";
            this.lblTimeStamp.Size = new System.Drawing.Size(60, 13);
            this.lblTimeStamp.TabIndex = 31;
            this.lblTimeStamp.Text = "$timestamp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(140, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Timestamp";
            // 
            // PlayerAttackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTimeStamp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAttackType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblfireWeaponStackCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAttackID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vehiclegb);
            this.Controls.Add(this.weapongb);
            this.Controls.Add(this.chargb);
            this.Name = "PlayerAttackForm";
            this.Size = new System.Drawing.Size(376, 371);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox chargb;
        private System.Windows.Forms.GroupBox weapongb;
        private System.Windows.Forms.GroupBox vehiclegb;
        private System.Windows.Forms.Label lblAttackID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblfireWeaponStackCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAttackType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTimeStamp;
        private System.Windows.Forms.Label label4;
    }
}
