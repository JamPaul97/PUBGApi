namespace TestEnviroment
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApiKey = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sTournament = new System.Windows.Forms.RadioButton();
            this.sxBox = new System.Windows.Forms.RadioButton();
            this.sKakao = new System.Windows.Forms.RadioButton();
            this.sPSN = new System.Windows.Forms.RadioButton();
            this.sSteam = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rTournament = new System.Windows.Forms.RadioButton();
            this.rSEA = new System.Windows.Forms.RadioButton();
            this.rSA = new System.Windows.Forms.RadioButton();
            this.rRU = new System.Windows.Forms.RadioButton();
            this.rOC = new System.Windows.Forms.RadioButton();
            this.rNA = new System.Windows.Forms.RadioButton();
            this.rKRJP = new System.Windows.Forms.RadioButton();
            this.rKakao = new System.Windows.Forms.RadioButton();
            this.rJP = new System.Windows.Forms.RadioButton();
            this.rEU = new System.Windows.Forms.RadioButton();
            this.rAS = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.result1 = new System.Windows.Forms.Splitter();
            this.result2 = new System.Windows.Forms.Splitter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 486);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1018, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(190, 462);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "API key";
            // 
            // txtApiKey
            // 
            this.txtApiKey.Location = new System.Drawing.Point(16, 79);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.PasswordChar = '*';
            this.txtApiKey.Size = new System.Drawing.Size(155, 20);
            this.txtApiKey.TabIndex = 5;
            this.txtApiKey.Text = resources.GetString("txtApiKey.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Shard";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sTournament);
            this.panel1.Controls.Add(this.sxBox);
            this.panel1.Controls.Add(this.sKakao);
            this.panel1.Controls.Add(this.sPSN);
            this.panel1.Controls.Add(this.sSteam);
            this.panel1.Location = new System.Drawing.Point(16, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 91);
            this.panel1.TabIndex = 7;
            // 
            // sTournament
            // 
            this.sTournament.AutoSize = true;
            this.sTournament.Location = new System.Drawing.Point(65, 37);
            this.sTournament.Name = "sTournament";
            this.sTournament.Size = new System.Drawing.Size(82, 17);
            this.sTournament.TabIndex = 4;
            this.sTournament.Text = "Tournament";
            this.sTournament.UseVisualStyleBackColor = true;
            // 
            // sxBox
            // 
            this.sxBox.AutoSize = true;
            this.sxBox.Location = new System.Drawing.Point(3, 72);
            this.sxBox.Name = "sxBox";
            this.sxBox.Size = new System.Drawing.Size(48, 17);
            this.sxBox.TabIndex = 3;
            this.sxBox.Text = "xBox";
            this.sxBox.UseVisualStyleBackColor = true;
            // 
            // sKakao
            // 
            this.sKakao.AutoSize = true;
            this.sKakao.Location = new System.Drawing.Point(3, 49);
            this.sKakao.Name = "sKakao";
            this.sKakao.Size = new System.Drawing.Size(56, 17);
            this.sKakao.TabIndex = 2;
            this.sKakao.Text = "Kakao";
            this.sKakao.UseVisualStyleBackColor = true;
            // 
            // sPSN
            // 
            this.sPSN.AutoSize = true;
            this.sPSN.Location = new System.Drawing.Point(3, 26);
            this.sPSN.Name = "sPSN";
            this.sPSN.Size = new System.Drawing.Size(47, 17);
            this.sPSN.TabIndex = 1;
            this.sPSN.Text = "PSN";
            this.sPSN.UseVisualStyleBackColor = true;
            // 
            // sSteam
            // 
            this.sSteam.AutoSize = true;
            this.sSteam.Checked = true;
            this.sSteam.Location = new System.Drawing.Point(3, 3);
            this.sSteam.Name = "sSteam";
            this.sSteam.Size = new System.Drawing.Size(55, 17);
            this.sSteam.TabIndex = 0;
            this.sSteam.TabStop = true;
            this.sSteam.Text = "Steam";
            this.sSteam.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rTournament);
            this.panel2.Controls.Add(this.rSEA);
            this.panel2.Controls.Add(this.rSA);
            this.panel2.Controls.Add(this.rRU);
            this.panel2.Controls.Add(this.rOC);
            this.panel2.Controls.Add(this.rNA);
            this.panel2.Controls.Add(this.rKRJP);
            this.panel2.Controls.Add(this.rKakao);
            this.panel2.Controls.Add(this.rJP);
            this.panel2.Controls.Add(this.rEU);
            this.panel2.Controls.Add(this.rAS);
            this.panel2.Location = new System.Drawing.Point(16, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 194);
            this.panel2.TabIndex = 9;
            // 
            // rTournament
            // 
            this.rTournament.AutoSize = true;
            this.rTournament.Location = new System.Drawing.Point(70, 84);
            this.rTournament.Name = "rTournament";
            this.rTournament.Size = new System.Drawing.Size(82, 17);
            this.rTournament.TabIndex = 10;
            this.rTournament.Text = "Tournament";
            this.rTournament.UseVisualStyleBackColor = true;
            // 
            // rSEA
            // 
            this.rSEA.AutoSize = true;
            this.rSEA.Location = new System.Drawing.Point(79, 26);
            this.rSEA.Name = "rSEA";
            this.rSEA.Size = new System.Drawing.Size(65, 17);
            this.rSEA.TabIndex = 9;
            this.rSEA.Text = "S.E.Asia";
            this.rSEA.UseVisualStyleBackColor = true;
            // 
            // rSA
            // 
            this.rSA.AutoSize = true;
            this.rSA.Location = new System.Drawing.Point(79, 3);
            this.rSA.Name = "rSA";
            this.rSA.Size = new System.Drawing.Size(73, 17);
            this.rSA.TabIndex = 8;
            this.rSA.Text = "S.America";
            this.rSA.UseVisualStyleBackColor = true;
            // 
            // rRU
            // 
            this.rRU.AutoSize = true;
            this.rRU.Location = new System.Drawing.Point(3, 164);
            this.rRU.Name = "rRU";
            this.rRU.Size = new System.Drawing.Size(57, 17);
            this.rRU.TabIndex = 7;
            this.rRU.Text = "Russia";
            this.rRU.UseVisualStyleBackColor = true;
            // 
            // rOC
            // 
            this.rOC.AutoSize = true;
            this.rOC.Location = new System.Drawing.Point(3, 141);
            this.rOC.Name = "rOC";
            this.rOC.Size = new System.Drawing.Size(65, 17);
            this.rOC.TabIndex = 6;
            this.rOC.Text = "Oceania";
            this.rOC.UseVisualStyleBackColor = true;
            // 
            // rNA
            // 
            this.rNA.AutoSize = true;
            this.rNA.Location = new System.Drawing.Point(3, 118);
            this.rNA.Name = "rNA";
            this.rNA.Size = new System.Drawing.Size(74, 17);
            this.rNA.TabIndex = 5;
            this.rNA.Text = "N.America";
            this.rNA.UseVisualStyleBackColor = true;
            // 
            // rKRJP
            // 
            this.rKRJP.AutoSize = true;
            this.rKRJP.Location = new System.Drawing.Point(3, 95);
            this.rKRJP.Name = "rKRJP";
            this.rKRJP.Size = new System.Drawing.Size(46, 17);
            this.rKRJP.TabIndex = 4;
            this.rKRJP.Text = "KrJp";
            this.rKRJP.UseVisualStyleBackColor = true;
            // 
            // rKakao
            // 
            this.rKakao.AutoSize = true;
            this.rKakao.Location = new System.Drawing.Point(3, 72);
            this.rKakao.Name = "rKakao";
            this.rKakao.Size = new System.Drawing.Size(56, 17);
            this.rKakao.TabIndex = 3;
            this.rKakao.Text = "Kakao";
            this.rKakao.UseVisualStyleBackColor = true;
            // 
            // rJP
            // 
            this.rJP.AutoSize = true;
            this.rJP.Location = new System.Drawing.Point(3, 49);
            this.rJP.Name = "rJP";
            this.rJP.Size = new System.Drawing.Size(54, 17);
            this.rJP.TabIndex = 2;
            this.rJP.Text = "Japan";
            this.rJP.UseVisualStyleBackColor = true;
            // 
            // rEU
            // 
            this.rEU.AutoSize = true;
            this.rEU.Checked = true;
            this.rEU.Location = new System.Drawing.Point(3, 26);
            this.rEU.Name = "rEU";
            this.rEU.Size = new System.Drawing.Size(59, 17);
            this.rEU.TabIndex = 1;
            this.rEU.TabStop = true;
            this.rEU.Text = "Europe";
            this.rEU.UseVisualStyleBackColor = true;
            // 
            // rAS
            // 
            this.rAS.AutoSize = true;
            this.rAS.Location = new System.Drawing.Point(3, 3);
            this.rAS.Name = "rAS";
            this.rAS.Size = new System.Drawing.Size(45, 17);
            this.rAS.TabIndex = 0;
            this.rAS.Text = "Asia";
            this.rAS.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Region";
            // 
            // result1
            // 
            this.result1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.result1.Location = new System.Drawing.Point(190, 24);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(269, 462);
            this.result1.TabIndex = 10;
            this.result1.TabStop = false;
            // 
            // result2
            // 
            this.result2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result2.Cursor = System.Windows.Forms.Cursors.Default;
            this.result2.Location = new System.Drawing.Point(459, 24);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(341, 462);
            this.result2.TabIndex = 11;
            this.result2.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchPlayerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 26);
            // 
            // searchPlayerToolStripMenuItem
            // 
            this.searchPlayerToolStripMenuItem.Name = "searchPlayerToolStripMenuItem";
            this.searchPlayerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchPlayerToolStripMenuItem.Text = "SearchPlayer";
            this.searchPlayerToolStripMenuItem.Click += new System.EventHandler(this.searchPlayerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 508);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApiKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Test PUBGApi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtApiKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton sTournament;
        private System.Windows.Forms.RadioButton sxBox;
        private System.Windows.Forms.RadioButton sKakao;
        private System.Windows.Forms.RadioButton sPSN;
        private System.Windows.Forms.RadioButton sSteam;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rTournament;
        private System.Windows.Forms.RadioButton rSEA;
        private System.Windows.Forms.RadioButton rSA;
        private System.Windows.Forms.RadioButton rRU;
        private System.Windows.Forms.RadioButton rOC;
        private System.Windows.Forms.RadioButton rNA;
        private System.Windows.Forms.RadioButton rKRJP;
        private System.Windows.Forms.RadioButton rKakao;
        private System.Windows.Forms.RadioButton rJP;
        private System.Windows.Forms.RadioButton rEU;
        private System.Windows.Forms.RadioButton rAS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.Splitter result1;
        private System.Windows.Forms.Splitter result2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchPlayerToolStripMenuItem;
    }
}

