
namespace TechnicService.Forms
{
    partial class FrmExpenses
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
            DevExpress.XtraPrinting.BarCode.Interleaved2of5Generator ınterleaved2of5Generator1 = new DevExpress.XtraPrinting.BarCode.Interleaved2of5Generator();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExpenses));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.checkSale = new DevExpress.XtraEditors.CheckEdit();
            this.txtprice = new DevExpress.XtraEditors.TextEdit();
            this.txtquantity = new DevExpress.XtraEditors.TextEdit();
            this.txtBrand = new DevExpress.XtraEditors.TextEdit();
            this.txtProductName = new DevExpress.XtraEditors.TextEdit();
            this.txtBarcode = new DevExpress.XtraEditors.TextEdit();
            this.barCodeControl1 = new DevExpress.XtraEditors.BarCodeControl();
            this.spinSale = new DevExpress.XtraEditors.SpinEdit();
            this.btnSell = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.checkSale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(863, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(863, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(863, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(863, 400);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Satış Fiyatı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(864, 347);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Satış Adedi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(863, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ürün Barkod";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStock.Location = new System.Drawing.Point(997, 303);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(34, 25);
            this.lblStock.TabIndex = 13;
            this.lblStock.Text = "00";
            // 
            // checkSale
            // 
            this.checkSale.Location = new System.Drawing.Point(868, 452);
            this.checkSale.Margin = new System.Windows.Forms.Padding(4);
            this.checkSale.Name = "checkSale";
            this.checkSale.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkSale.Properties.Appearance.Options.UseFont = true;
            this.checkSale.Properties.Caption = "İndirim Uygula";
            this.checkSale.Size = new System.Drawing.Size(189, 28);
            this.checkSale.TabIndex = 14;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(1003, 396);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtprice.Name = "txtprice";
            this.txtprice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtprice.Properties.Appearance.Options.UseFont = true;
            this.txtprice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtprice.Properties.MaskSettings.Set("mask", "c");
            this.txtprice.Size = new System.Drawing.Size(116, 30);
            this.txtprice.TabIndex = 12;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(1004, 343);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtquantity.Properties.Appearance.Options.UseFont = true;
            this.txtquantity.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtquantity.Properties.MaskSettings.Set("mask", "d");
            this.txtquantity.Size = new System.Drawing.Size(116, 30);
            this.txtquantity.TabIndex = 11;
            // 
            // txtBrand
            // 
            this.txtBrand.Enabled = false;
            this.txtBrand.Location = new System.Drawing.Point(1003, 252);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBrand.Properties.Appearance.Options.UseFont = true;
            this.txtBrand.Size = new System.Drawing.Size(352, 30);
            this.txtBrand.TabIndex = 9;
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Location = new System.Drawing.Point(1003, 202);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductName.Properties.Appearance.Options.UseFont = true;
            this.txtProductName.Size = new System.Drawing.Size(352, 30);
            this.txtProductName.TabIndex = 8;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(1003, 154);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarcode.Properties.Appearance.Options.UseFont = true;
            this.txtBarcode.Size = new System.Drawing.Size(352, 30);
            this.txtBarcode.TabIndex = 7;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            // 
            // barCodeControl1
            // 
            this.barCodeControl1.Location = new System.Drawing.Point(1003, 133);
            this.barCodeControl1.Margin = new System.Windows.Forms.Padding(4);
            this.barCodeControl1.Name = "barCodeControl1";
            this.barCodeControl1.Padding = new System.Windows.Forms.Padding(13, 2, 13, 0);
            this.barCodeControl1.Size = new System.Drawing.Size(352, 53);
            ınterleaved2of5Generator1.WideNarrowRatio = 3F;
            this.barCodeControl1.Symbology = ınterleaved2of5Generator1;
            this.barCodeControl1.TabIndex = 15;
            this.barCodeControl1.Visible = false;
            // 
            // spinSale
            // 
            this.spinSale.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinSale.Location = new System.Drawing.Point(1069, 450);
            this.spinSale.Margin = new System.Windows.Forms.Padding(4);
            this.spinSale.Name = "spinSale";
            this.spinSale.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinSale.Properties.MaskSettings.Set("mask", "P");
            this.spinSale.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinSale.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinSale.Size = new System.Drawing.Size(112, 24);
            this.spinSale.TabIndex = 16;
            // 
            // btnSell
            // 
            this.btnSell.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSell.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSell.Appearance.Options.UseBackColor = true;
            this.btnSell.Appearance.Options.UseFont = true;
            this.btnSell.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSell.ImageOptions.Image")));
            this.btnSell.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSell.Location = new System.Drawing.Point(979, 514);
            this.btnSell.Margin = new System.Windows.Forms.Padding(4);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(329, 79);
            this.btnSell.TabIndex = 17;
            this.btnSell.Text = "Satış Yap";
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 142);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(842, 370);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FrmExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1789, 778);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.spinSale);
            this.Controls.Add(this.checkSale);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barCodeControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Satış";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmExpenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkSale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtBarcode;
        private DevExpress.XtraEditors.TextEdit txtProductName;
        private DevExpress.XtraEditors.TextEdit txtBrand;
        private DevExpress.XtraEditors.TextEdit txtquantity;
        private DevExpress.XtraEditors.TextEdit txtprice;
        private System.Windows.Forms.Label lblStock;
        private DevExpress.XtraEditors.CheckEdit checkSale;
        private DevExpress.XtraEditors.BarCodeControl barCodeControl1;
        private DevExpress.XtraEditors.SpinEdit spinSale;
        private DevExpress.XtraEditors.SimpleButton btnSell;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}