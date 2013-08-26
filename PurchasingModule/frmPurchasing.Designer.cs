namespace PurchasingModule
{
    partial class frmPurchasing 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchasing));
            this.stsPurchasing = new System.Windows.Forms.StatusStrip();
            this.tsCurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvPurchasing = new System.Windows.Forms.DataGridView();
            this.stcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stunitcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stentrydate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stlastmodified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stmodifiedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPicture = new System.Windows.Forms.PictureBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.stsPurchasing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchasing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // stsPurchasing
            // 
            this.stsPurchasing.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCurrentUser});
            this.stsPurchasing.Location = new System.Drawing.Point(0, 420);
            this.stsPurchasing.Name = "stsPurchasing";
            this.stsPurchasing.Size = new System.Drawing.Size(844, 22);
            this.stsPurchasing.TabIndex = 0;
            this.stsPurchasing.Text = "statusStrip1";
            // 
            // tsCurrentUser
            // 
            this.tsCurrentUser.Name = "tsCurrentUser";
            this.tsCurrentUser.Size = new System.Drawing.Size(69, 17);
            this.tsCurrentUser.Text = "Logged In:  ";
            // 
            // dgvPurchasing
            // 
            this.dgvPurchasing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchasing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stcode,
            this.stname,
            this.stqty,
            this.stunit,
            this.stunitcost,
            this.stentrydate,
            this.stlastmodified,
            this.stmodifiedby});
            this.dgvPurchasing.Location = new System.Drawing.Point(12, 109);
            this.dgvPurchasing.Name = "dgvPurchasing";
            this.dgvPurchasing.Size = new System.Drawing.Size(820, 308);
            this.dgvPurchasing.TabIndex = 1;
            // 
            // stcode
            // 
            this.stcode.HeaderText = "Item Code";
            this.stcode.Name = "stcode";
            this.stcode.ReadOnly = true;
            // 
            // stname
            // 
            this.stname.HeaderText = "Item Name";
            this.stname.Name = "stname";
            this.stname.ReadOnly = true;
            // 
            // stqty
            // 
            this.stqty.HeaderText = "Quantity";
            this.stqty.Name = "stqty";
            this.stqty.ReadOnly = true;
            // 
            // stunit
            // 
            this.stunit.HeaderText = "Unit";
            this.stunit.Name = "stunit";
            this.stunit.ReadOnly = true;
            // 
            // stunitcost
            // 
            this.stunitcost.HeaderText = "Unit Cost";
            this.stunitcost.Name = "stunitcost";
            this.stunitcost.ReadOnly = true;
            // 
            // stentrydate
            // 
            this.stentrydate.HeaderText = "Date Entered";
            this.stentrydate.Name = "stentrydate";
            this.stentrydate.ReadOnly = true;
            // 
            // stlastmodified
            // 
            this.stlastmodified.HeaderText = "Last Modified";
            this.stlastmodified.Name = "stlastmodified";
            this.stlastmodified.ReadOnly = true;
            // 
            // stmodifiedby
            // 
            this.stmodifiedby.HeaderText = "Modified By";
            this.stmodifiedby.Name = "stmodifiedby";
            this.stmodifiedby.ReadOnly = true;
            // 
            // ItemPicture
            // 
            this.ItemPicture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ItemPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ItemPicture.Location = new System.Drawing.Point(12, 12);
            this.ItemPicture.Name = "ItemPicture";
            this.ItemPicture.Size = new System.Drawing.Size(123, 91);
            this.ItemPicture.TabIndex = 2;
            this.ItemPicture.TabStop = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(141, 12);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(150, 91);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "ADD NEW ITEM";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(297, 12);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(150, 91);
            this.btnDeleteItem.TabIndex = 3;
            this.btnDeleteItem.Text = "DELETE ITEM";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            // 
            // frmPurchasing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 442);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.ItemPicture);
            this.Controls.Add(this.dgvPurchasing);
            this.Controls.Add(this.stsPurchasing);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(860, 480);
            this.Name = "frmPurchasing";
            this.Text = "Purchasing";
            this.stsPurchasing.ResumeLayout(false);
            this.stsPurchasing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchasing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stsPurchasing;
        private System.Windows.Forms.ToolStripStatusLabel tsCurrentUser;
        private System.Windows.Forms.DataGridView dgvPurchasing;
        private System.Windows.Forms.DataGridViewTextBoxColumn stcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn stname;
        private System.Windows.Forms.DataGridViewTextBoxColumn stqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn stunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn stunitcost;
        private System.Windows.Forms.DataGridViewTextBoxColumn stentrydate;
        private System.Windows.Forms.DataGridViewTextBoxColumn stlastmodified;
        private System.Windows.Forms.DataGridViewTextBoxColumn stmodifiedby;
        private System.Windows.Forms.PictureBox ItemPicture;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDeleteItem;

    }
}

