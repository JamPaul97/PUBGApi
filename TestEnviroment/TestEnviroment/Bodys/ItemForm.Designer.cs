namespace TestEnviroment.Bodys
{
    partial class ItemForm
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
            this.label14 = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStackCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsubCategory = new System.Windows.Forms.Label();
            this.attachedItems = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = "ItemID";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(3, 17);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(44, 13);
            this.lblItemID.TabIndex = 24;
            this.lblItemID.Text = "$ItemID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(127, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Stack Count";
            // 
            // lblStackCount
            // 
            this.lblStackCount.AutoSize = true;
            this.lblStackCount.Location = new System.Drawing.Point(127, 17);
            this.lblStackCount.Name = "lblStackCount";
            this.lblStackCount.Size = new System.Drawing.Size(67, 13);
            this.lblStackCount.TabIndex = 26;
            this.lblStackCount.Text = "$stackCount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(247, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Category";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(247, 17);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(55, 13);
            this.lblCategory.TabIndex = 28;
            this.lblCategory.Text = "$Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(247, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "subCategory";
            // 
            // lblsubCategory
            // 
            this.lblsubCategory.AutoSize = true;
            this.lblsubCategory.Location = new System.Drawing.Point(247, 69);
            this.lblsubCategory.Name = "lblsubCategory";
            this.lblsubCategory.Size = new System.Drawing.Size(72, 13);
            this.lblsubCategory.TabIndex = 30;
            this.lblsubCategory.Text = "$subCategory";
            // 
            // attachedItems
            // 
            this.attachedItems.FormattingEnabled = true;
            this.attachedItems.Location = new System.Drawing.Point(6, 63);
            this.attachedItems.Name = "attachedItems";
            this.attachedItems.Size = new System.Drawing.Size(222, 21);
            this.attachedItems.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(3, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Attacked Items";
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.attachedItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblsubCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStackCount);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblItemID);
            this.Name = "ItemForm";
            this.Size = new System.Drawing.Size(350, 87);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStackCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsubCategory;
        private System.Windows.Forms.ComboBox attachedItems;
        private System.Windows.Forms.Label label4;
    }
}
