namespace TestEnviroment.Bodys
{
    partial class PlayersForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbPlayer = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCopyMatchID = new System.Windows.Forms.Button();
            this.btnCopyAccountID = new System.Windows.Forms.Button();
            this.btnCopyName = new System.Windows.Forms.Button();
            this.listboxMatches = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.playerList = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statusStrip1);
            this.groupBox1.Controls.Add(this.gbPlayer);
            this.groupBox1.Controls.Add(this.playerList);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 428);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbMessage});
            this.statusStrip1.Location = new System.Drawing.Point(3, 403);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(350, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbMessage
            // 
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbMessage.Size = new System.Drawing.Size(25, 17);
            this.lbMessage.Text = "asd";
            // 
            // gbPlayer
            // 
            this.gbPlayer.Controls.Add(this.button2);
            this.gbPlayer.Controls.Add(this.button1);
            this.gbPlayer.Controls.Add(this.btnCopyMatchID);
            this.gbPlayer.Controls.Add(this.btnCopyAccountID);
            this.gbPlayer.Controls.Add(this.btnCopyName);
            this.gbPlayer.Controls.Add(this.listboxMatches);
            this.gbPlayer.Controls.Add(this.label5);
            this.gbPlayer.Controls.Add(this.lbID);
            this.gbPlayer.Controls.Add(this.label4);
            this.gbPlayer.Controls.Add(this.lbName);
            this.gbPlayer.Controls.Add(this.label1);
            this.gbPlayer.Enabled = false;
            this.gbPlayer.Location = new System.Drawing.Point(6, 46);
            this.gbPlayer.Name = "gbPlayer";
            this.gbPlayer.Size = new System.Drawing.Size(344, 354);
            this.gbPlayer.TabIndex = 1;
            this.gbPlayer.TabStop = false;
            this.gbPlayer.Text = "Select a player from the list above";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCopyMatchID
            // 
            this.btnCopyMatchID.Location = new System.Drawing.Point(263, 96);
            this.btnCopyMatchID.Name = "btnCopyMatchID";
            this.btnCopyMatchID.Size = new System.Drawing.Size(75, 23);
            this.btnCopyMatchID.TabIndex = 8;
            this.btnCopyMatchID.Text = "copy";
            this.btnCopyMatchID.UseVisualStyleBackColor = true;
            this.btnCopyMatchID.Click += new System.EventHandler(this.btnCopyMatchID_Click);
            // 
            // btnCopyAccountID
            // 
            this.btnCopyAccountID.Location = new System.Drawing.Point(263, 53);
            this.btnCopyAccountID.Name = "btnCopyAccountID";
            this.btnCopyAccountID.Size = new System.Drawing.Size(75, 23);
            this.btnCopyAccountID.TabIndex = 7;
            this.btnCopyAccountID.Text = "copy";
            this.btnCopyAccountID.UseVisualStyleBackColor = true;
            this.btnCopyAccountID.Click += new System.EventHandler(this.btnCopyAccountID_Click);
            // 
            // btnCopyName
            // 
            this.btnCopyName.Location = new System.Drawing.Point(263, 23);
            this.btnCopyName.Name = "btnCopyName";
            this.btnCopyName.Size = new System.Drawing.Size(75, 23);
            this.btnCopyName.TabIndex = 6;
            this.btnCopyName.Text = "copy";
            this.btnCopyName.UseVisualStyleBackColor = true;
            this.btnCopyName.Click += new System.EventHandler(this.btnCopyName_Click);
            // 
            // listboxMatches
            // 
            this.listboxMatches.FormattingEnabled = true;
            this.listboxMatches.Location = new System.Drawing.Point(9, 96);
            this.listboxMatches.Name = "listboxMatches";
            this.listboxMatches.Size = new System.Drawing.Size(248, 251);
            this.listboxMatches.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Matches List";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(6, 63);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(27, 13);
            this.lbID.TabIndex = 3;
            this.lbID.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Account ID";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(6, 33);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(27, 13);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Name";
            // 
            // playerList
            // 
            this.playerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerList.FormattingEnabled = true;
            this.playerList.Location = new System.Drawing.Point(6, 19);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(344, 21);
            this.playerList.TabIndex = 0;
            this.playerList.SelectedIndexChanged += new System.EventHandler(this.playerList_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "telemetry";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "PlayersForm";
            this.Size = new System.Drawing.Size(362, 434);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbPlayer.ResumeLayout(false);
            this.gbPlayer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbPlayer;
        private System.Windows.Forms.ComboBox playerList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnCopyMatchID;
        private System.Windows.Forms.Button btnCopyAccountID;
        private System.Windows.Forms.Button btnCopyName;
        private System.Windows.Forms.ListBox listboxMatches;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel lbMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
