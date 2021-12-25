
namespace TechnicService.Forms
{
    partial class FrmCustomerUpdate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAdress = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chcxStatus = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnUpdateCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.txtDistrict = new DevExpress.XtraEditors.TextEdit();
            this.txtProvince = new DevExpress.XtraEditors.TextEdit();
            this.cbxCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.txtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.txtWebsite = new DevExpress.XtraEditors.TextEdit();
            this.txtTaxNo = new DevExpress.XtraEditors.TextEdit();
            this.txtTaxAdministration = new DevExpress.XtraEditors.TextEdit();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistrict.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProvince.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxAdministration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDistrict);
            this.groupBox1.Controls.Add(this.txtProvince);
            this.groupBox1.Controls.Add(this.txtAdress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(457, 434);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 259);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adres Bilgileri";
            // 
            // txtAdress
            // 
            this.txtAdress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdress.Location = new System.Drawing.Point(263, 102);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(516, 146);
            this.txtAdress.TabIndex = 48;
            this.txtAdress.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(182, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 24);
            this.label1.TabIndex = 50;
            this.label1.Text = "İlçe";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(182, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 24);
            this.label8.TabIndex = 46;
            this.label8.Text = "Adres";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(182, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 24);
            this.label7.TabIndex = 47;
            this.label7.Text = "Şehir";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chcxStatus);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbxCustomer);
            this.groupBox2.Controls.Add(this.txtFirstName);
            this.groupBox2.Controls.Add(this.txtWebsite);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTaxNo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtTaxAdministration);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtMail);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtLastName);
            this.groupBox2.Location = new System.Drawing.Point(457, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(912, 416);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cari Bilgi";
            // 
            // chcxStatus
            // 
            this.chcxStatus.AutoSize = true;
            this.chcxStatus.Location = new System.Drawing.Point(475, 366);
            this.chcxStatus.Name = "chcxStatus";
            this.chcxStatus.Size = new System.Drawing.Size(18, 17);
            this.chcxStatus.TabIndex = 58;
            this.chcxStatus.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(410, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 57;
            this.label2.Text = "Bloke";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(113, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Web Sitesi";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(113, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 48);
            this.label10.TabIndex = 25;
            this.label10.Text = "Vergi Daire No\r\n/TC Kimlik No";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(113, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 24);
            this.label9.TabIndex = 26;
            this.label9.Text = "*Mail";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(113, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 24);
            this.label11.TabIndex = 21;
            this.label11.Text = "*Ünvanı (adı)";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(113, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 24);
            this.label12.TabIndex = 23;
            this.label12.Text = "Ünvanı (soyadı)";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(113, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 24);
            this.label13.TabIndex = 25;
            this.label13.Text = "*Telefon";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(113, 269);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 24);
            this.label14.TabIndex = 36;
            this.label14.Text = "Vergi Dairesi";
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.AllowDrop = true;
            this.btnUpdateCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateCustomer.Appearance.BackColor = System.Drawing.Color.White;
            this.btnUpdateCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateCustomer.Appearance.Options.UseBackColor = true;
            this.btnUpdateCustomer.Appearance.Options.UseFont = true;
            this.btnUpdateCustomer.ImageOptions.Image = global::TechnicService.Properties.Resources.recurrence_32x322;
            this.btnUpdateCustomer.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(457, 687);
            this.btnUpdateCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(728, 53);
            this.btnUpdateCustomer.TabIndex = 55;
            this.btnUpdateCustomer.Text = "Güncelle";
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click_1);
            // 
            // txtDistrict
            // 
            this.txtDistrict.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDistrict.Location = new System.Drawing.Point(263, 66);
            this.txtDistrict.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDistrict.Properties.Appearance.Options.UseFont = true;
            this.txtDistrict.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtDistrict.Size = new System.Drawing.Size(516, 32);
            this.txtDistrict.TabIndex = 51;
            // 
            // txtProvince
            // 
            this.txtProvince.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProvince.Location = new System.Drawing.Point(263, 26);
            this.txtProvince.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProvince.Properties.Appearance.Options.UseFont = true;
            this.txtProvince.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtProvince.Size = new System.Drawing.Size(516, 32);
            this.txtProvince.TabIndex = 43;
            // 
            // cbxCustomer
            // 
            this.cbxCustomer.Location = new System.Drawing.Point(263, 37);
            this.cbxCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxCustomer.Name = "cbxCustomer";
            this.cbxCustomer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxCustomer.Properties.Appearance.Options.UseFont = true;
            this.cbxCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxCustomer.Properties.DisplayMember = "UnvanAd";
            this.cbxCustomer.Properties.NullText = "Cari Seçiniz";
            this.cbxCustomer.Properties.ValueMember = "ÖzelKod";
            this.cbxCustomer.Size = new System.Drawing.Size(516, 30);
            this.cbxCustomer.TabIndex = 56;
            this.cbxCustomer.EditValueChanged += new System.EventHandler(this.cbxCustomer_EditValueChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.Location = new System.Drawing.Point(263, 78);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirstName.Properties.Appearance.Options.UseFont = true;
            this.txtFirstName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtFirstName.Size = new System.Drawing.Size(516, 32);
            this.txtFirstName.TabIndex = 35;
            // 
            // txtWebsite
            // 
            this.txtWebsite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWebsite.Location = new System.Drawing.Point(263, 225);
            this.txtWebsite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtWebsite.Properties.Appearance.Options.UseFont = true;
            this.txtWebsite.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtWebsite.Size = new System.Drawing.Size(516, 32);
            this.txtWebsite.TabIndex = 42;
            // 
            // txtTaxNo
            // 
            this.txtTaxNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTaxNo.Location = new System.Drawing.Point(263, 303);
            this.txtTaxNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaxNo.Name = "txtTaxNo";
            this.txtTaxNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTaxNo.Properties.Appearance.Options.UseFont = true;
            this.txtTaxNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtTaxNo.Size = new System.Drawing.Size(516, 32);
            this.txtTaxNo.TabIndex = 22;
            // 
            // txtTaxAdministration
            // 
            this.txtTaxAdministration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTaxAdministration.Location = new System.Drawing.Point(263, 265);
            this.txtTaxAdministration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaxAdministration.Name = "txtTaxAdministration";
            this.txtTaxAdministration.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTaxAdministration.Properties.Appearance.Options.UseFont = true;
            this.txtTaxAdministration.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtTaxAdministration.Size = new System.Drawing.Size(516, 32);
            this.txtTaxAdministration.TabIndex = 20;
            // 
            // txtMail
            // 
            this.txtMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMail.Location = new System.Drawing.Point(263, 189);
            this.txtMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMail.Name = "txtMail";
            this.txtMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Properties.Appearance.Options.UseFont = true;
            this.txtMail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtMail.Size = new System.Drawing.Size(516, 32);
            this.txtMail.TabIndex = 39;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.Location = new System.Drawing.Point(263, 153);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPhone.Properties.Appearance.Options.UseFont = true;
            this.txtPhone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtPhone.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtPhone.Properties.MaskSettings.Set("mask", "(000) 000-0000");
            this.txtPhone.Size = new System.Drawing.Size(516, 32);
            this.txtPhone.TabIndex = 38;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.Location = new System.Drawing.Point(263, 116);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLastName.Properties.Appearance.Options.UseFont = true;
            this.txtLastName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtLastName.Size = new System.Drawing.Size(516, 32);
            this.txtLastName.TabIndex = 37;
            // 
            // FrmCustomerUpdate
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1724, 778);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmCustomerUpdate";
            this.Text = "Cari Kart Güncelleme";
            this.Load += new System.EventHandler(this.FrmCustomerUpdate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistrict.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProvince.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxAdministration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtDistrict;
        private DevExpress.XtraEditors.TextEdit txtProvince;
        private System.Windows.Forms.RichTextBox txtAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit txtFirstName;
        private DevExpress.XtraEditors.TextEdit txtWebsite;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtTaxNo;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtTaxAdministration;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private DevExpress.XtraEditors.LookUpEdit cbxCustomer;
        private System.Windows.Forms.CheckBox chcxStatus;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnUpdateCustomer;
    }
}