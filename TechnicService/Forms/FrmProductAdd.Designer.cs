
namespace TechnicService.Forms
{
    partial class FrmProductAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductAdd));
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSalesPrice = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdd = new DevExpress.XtraEditors.TextEdit();
            this.btnProductAdd = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbrand = new DevExpress.XtraEditors.TextEdit();
            this.txtPurchase = new DevExpress.XtraEditors.TextEdit();
            this.txtStock = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.cbxCategory = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalesPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCategory.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(441, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "*Ürün Adı";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(441, 186);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "*Marka";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(441, 230);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "*Alış Fiyatı";
            // 
            // txtSalesPrice
            // 
            this.txtSalesPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSalesPrice.Location = new System.Drawing.Point(536, 271);
            this.txtSalesPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSalesPrice.Name = "txtSalesPrice";
            this.txtSalesPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSalesPrice.Properties.Appearance.Options.UseFont = true;
            this.txtSalesPrice.Properties.BeepOnError = false;
            this.txtSalesPrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtSalesPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSalesPrice.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtSalesPrice.Properties.MaskSettings.Set("mask", "c");
            this.txtSalesPrice.Size = new System.Drawing.Size(387, 28);
            this.txtSalesPrice.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(441, 274);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "*Satış Fiyat";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(441, 315);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "*Adet ";
            // 
            // txtAdd
            // 
            this.txtAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdd.Location = new System.Drawing.Point(536, 89);
            this.txtAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdd.Properties.Appearance.Options.UseFont = true;
            this.txtAdd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtAdd.Size = new System.Drawing.Size(387, 28);
            this.txtAdd.TabIndex = 33;
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductAdd.Appearance.BackColor = System.Drawing.Color.Lime;
            this.btnProductAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProductAdd.Appearance.Options.UseBackColor = true;
            this.btnProductAdd.Appearance.Options.UseFont = true;
            this.btnProductAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProductAdd.ImageOptions.Image")));
            this.btnProductAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnProductAdd.Location = new System.Drawing.Point(614, 414);
            this.btnProductAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(203, 59);
            this.btnProductAdd.TabIndex = 32;
            this.btnProductAdd.Text = "Ekle";
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(441, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "*Kategori";
            // 
            // txtbrand
            // 
            this.txtbrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbrand.Location = new System.Drawing.Point(536, 183);
            this.txtbrand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbrand.Properties.Appearance.Options.UseFont = true;
            this.txtbrand.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtbrand.Size = new System.Drawing.Size(387, 28);
            this.txtbrand.TabIndex = 36;
            // 
            // txtPurchase
            // 
            this.txtPurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPurchase.Location = new System.Drawing.Point(536, 227);
            this.txtPurchase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPurchase.Name = "txtPurchase";
            this.txtPurchase.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPurchase.Properties.Appearance.Options.UseFont = true;
            this.txtPurchase.Properties.BeepOnError = false;
            this.txtPurchase.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtPurchase.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPurchase.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtPurchase.Properties.MaskSettings.Set("mask", "c");
            this.txtPurchase.Size = new System.Drawing.Size(387, 28);
            this.txtPurchase.TabIndex = 37;
            // 
            // txtStock
            // 
            this.txtStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStock.Location = new System.Drawing.Point(536, 312);
            this.txtStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStock.Name = "txtStock";
            this.txtStock.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStock.Properties.Appearance.Options.UseFont = true;
            this.txtStock.Properties.BeepOnError = false;
            this.txtStock.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtStock.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtStock.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtStock.Properties.MaskSettings.Set("mask", "d");
            this.txtStock.Size = new System.Drawing.Size(387, 28);
            this.txtStock.TabIndex = 38;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(38, 59);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(356, 414);
            this.pictureEdit1.TabIndex = 39;
            // 
            // cbxCategory
            // 
            this.cbxCategory.Location = new System.Drawing.Point(663, 130);
            this.cbxCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxCategory.Properties.Appearance.Options.UseFont = true;
            this.cbxCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxCategory.Properties.DisplayMember = "Name";
            this.cbxCategory.Properties.NullText = "Kategori Seçiniz";
            this.cbxCategory.Properties.ValueMember = "Id";
            this.cbxCategory.Size = new System.Drawing.Size(387, 28);
            this.cbxCategory.TabIndex = 40;
            // 
            // FrmProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1276, 632);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPurchase);
            this.Controls.Add(this.txtbrand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.btnProductAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSalesPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmProductAdd";
            this.Load += new System.EventHandler(this.FrmProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSalesPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCategory.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txtSalesPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtAdd;
        private DevExpress.XtraEditors.SimpleButton btnProductAdd;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtbrand;
        private DevExpress.XtraEditors.TextEdit txtPurchase;
        private DevExpress.XtraEditors.TextEdit txtStock;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LookUpEdit cbxCategory;
    }
}