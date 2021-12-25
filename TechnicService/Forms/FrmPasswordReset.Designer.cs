
namespace TechnicService.Forms
{
    partial class FrmPasswordReset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPasswordReset));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.txtPassword2 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pictureEdit1.Properties.Appearance.Options.UseFont = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(698, 442);
            this.pictureEdit1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(106, 110);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 28);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Parola";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(245, 231);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(197, 43);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Değiştir";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(106, 157);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(100, 28);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Parola (T)";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(555, 110);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.checkEdit1.Properties.Caption = "";
            this.checkEdit1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.checkEdit1.Size = new System.Drawing.Size(94, 24);
            this.checkEdit1.TabIndex = 17;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(227, 104);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Size = new System.Drawing.Size(350, 34);
            this.txtPassword.TabIndex = 16;
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(555, 157);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.checkEdit2.Properties.Caption = "";
            this.checkEdit2.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.checkEdit2.Size = new System.Drawing.Size(94, 24);
            this.checkEdit2.TabIndex = 19;
            this.checkEdit2.CheckedChanged += new System.EventHandler(this.checkEdit2_CheckedChanged);
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(227, 151);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword2.Properties.Appearance.Options.UseFont = true;
            this.txtPassword2.Size = new System.Drawing.Size(350, 34);
            this.txtPassword2.TabIndex = 18;
            // 
            // FrmPasswordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(698, 442);
            this.Controls.Add(this.checkEdit2);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmPasswordReset";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.TextEdit txtPassword2;
    }
}