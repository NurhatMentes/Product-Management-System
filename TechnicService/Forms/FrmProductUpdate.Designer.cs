
namespace TechnicService.Forms
{
    partial class FrmProductUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductUpdate));
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.txtStock = new DevExpress.XtraEditors.TextEdit();
            this.txtPurchase = new DevExpress.XtraEditors.TextEdit();
            this.txtbrand = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.btnProductUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.txtSalesPrice = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxProduct = new DevExpress.XtraEditors.LookUpEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalesPrice.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(75, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "*Kategori";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(78, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 46;
            this.label7.Text = "*Adet ";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(73, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 24);
            this.label8.TabIndex = 45;
            this.label8.Text = "*Satış Fiyat($)";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(75, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 24);
            this.label9.TabIndex = 43;
            this.label9.Text = "*Alış Fiyatı($)";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(75, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 24);
            this.label10.TabIndex = 42;
            this.label10.Text = "*Marka";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(75, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 41;
            this.label6.Text = "*Ürün Adı";
            // 
            // cbxCategory
            // 
            this.cbxCategory.Location = new System.Drawing.Point(225, 181);
            this.cbxCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxCategory.Properties.Appearance.Options.UseFont = true;
            this.cbxCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxCategory.Properties.DisplayMember = "Name";
            this.cbxCategory.Properties.NullText = "Kategori Seçiniz";
            this.cbxCategory.Properties.ValueMember = "Id";
            this.cbxCategory.Size = new System.Drawing.Size(548, 30);
            this.cbxCategory.TabIndex = 54;
            // 
            // txtStock
            // 
            this.txtStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStock.Location = new System.Drawing.Point(225, 388);
            this.txtStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStock.Name = "txtStock";
            this.txtStock.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStock.Properties.Appearance.Options.UseFont = true;
            this.txtStock.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtStock.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtStock.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtStock.Properties.MaskSettings.Set("mask", "d");
            this.txtStock.Size = new System.Drawing.Size(548, 32);
            this.txtStock.TabIndex = 52;
            // 
            // txtPurchase
            // 
            this.txtPurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPurchase.Location = new System.Drawing.Point(225, 282);
            this.txtPurchase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPurchase.Name = "txtPurchase";
            this.txtPurchase.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPurchase.Properties.Appearance.Options.UseFont = true;
            this.txtPurchase.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtPurchase.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPurchase.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtPurchase.Properties.MaskSettings.Set("mask", "c");
            this.txtPurchase.Properties.MaskSettings.Set("culture", "es-US");
            this.txtPurchase.Size = new System.Drawing.Size(548, 32);
            this.txtPurchase.TabIndex = 51;
            // 
            // txtbrand
            // 
            this.txtbrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbrand.Location = new System.Drawing.Point(225, 231);
            this.txtbrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbrand.Properties.Appearance.Options.UseFont = true;
            this.txtbrand.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtbrand.Size = new System.Drawing.Size(548, 32);
            this.txtbrand.TabIndex = 50;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(225, 130);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtName.Size = new System.Drawing.Size(548, 32);
            this.txtName.TabIndex = 48;
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductUpdate.Appearance.BackColor = System.Drawing.Color.Lime;
            this.btnProductUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProductUpdate.Appearance.Options.UseBackColor = true;
            this.btnProductUpdate.Appearance.Options.UseFont = true;
            this.btnProductUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProductUpdate.ImageOptions.Image")));
            this.btnProductUpdate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnProductUpdate.Location = new System.Drawing.Point(313, 500);
            this.btnProductUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(508, 73);
            this.btnProductUpdate.TabIndex = 47;
            this.btnProductUpdate.Text = "Güncelle";
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // txtSalesPrice
            // 
            this.txtSalesPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSalesPrice.Location = new System.Drawing.Point(225, 336);
            this.txtSalesPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalesPrice.Name = "txtSalesPrice";
            this.txtSalesPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSalesPrice.Properties.Appearance.Options.UseFont = true;
            this.txtSalesPrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtSalesPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSalesPrice.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtSalesPrice.Properties.MaskSettings.Set("mask", "c");
            this.txtSalesPrice.Properties.MaskSettings.Set("culture", "en-US");
            this.txtSalesPrice.Size = new System.Drawing.Size(548, 32);
            this.txtSalesPrice.TabIndex = 44;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxCustomer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxProduct);
            this.groupBox1.Controls.Add(this.cbxCategory);
            this.groupBox1.Controls.Add(this.btnProductUpdate);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPurchase);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtbrand);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSalesPrice);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(679, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1008, 597);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(75, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 58;
            this.label3.Text = "*Cari ";
            // 
            // cbxCustomer
            // 
            this.cbxCustomer.Location = new System.Drawing.Point(225, 81);
            this.cbxCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxCustomer.Name = "cbxCustomer";
            this.cbxCustomer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxCustomer.Properties.Appearance.Options.UseFont = true;
            this.cbxCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxCustomer.Properties.DisplayMember = "UnvanAd";
            this.cbxCustomer.Properties.NullText = "Cari Seçiniz";
            this.cbxCustomer.Properties.ValueMember = "ÖzelKod";
            this.cbxCustomer.Size = new System.Drawing.Size(548, 30);
            this.cbxCustomer.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(75, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 56;
            this.label2.Text = "*Ürün";
            // 
            // cbxProduct
            // 
            this.cbxProduct.Location = new System.Drawing.Point(224, 30);
            this.cbxProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxProduct.Name = "cbxProduct";
            this.cbxProduct.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxProduct.Properties.Appearance.Options.UseFont = true;
            this.cbxProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxProduct.Properties.DisplayMember = "Name";
            this.cbxProduct.Properties.NullText = "Ürün Seçiniz";
            this.cbxProduct.Properties.ValueMember = "Id";
            this.cbxProduct.Size = new System.Drawing.Size(548, 30);
            this.cbxProduct.TabIndex = 55;
            this.cbxProduct.EditValueChanged += new System.EventHandler(this.cbxProduct_EditValueChanged);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(67, 192);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(590, 408);
            this.pictureEdit1.TabIndex = 53;
            // 
            // FrmProductUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(207)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1701, 778);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmProductUpdate";
            this.Text = "Ürün Güncelleme";
            this.Load += new System.EventHandler(this.FrmProductUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbxCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalesPrice.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit cbxCategory;
        private DevExpress.XtraEditors.TextEdit txtStock;
        private DevExpress.XtraEditors.TextEdit txtPurchase;
        private DevExpress.XtraEditors.TextEdit txtbrand;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.SimpleButton btnProductUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txtSalesPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit cbxProduct;
        private DevExpress.XtraEditors.LookUpEdit cbxCustomer;
        private System.Windows.Forms.Label label3;
    }
}