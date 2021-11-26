
namespace TechnicService.Forms
{
    partial class FrmMalfunction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMalfunction));
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnList = new DevExpress.XtraEditors.SimpleButton();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.pnlList = new DevExpress.XtraEditors.GroupControl();
            this.dtList = new DevExpress.XtraGrid.GridControl();
            this.grdMalfunction = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grpAdd = new DevExpress.XtraEditors.GroupControl();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.label14 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.btnAddMalfunction = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.txtProcess = new System.Windows.Forms.RichTextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtProblem = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddMalfunc = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpUpdate = new DevExpress.XtraEditors.GroupControl();
            this.btnUptated = new DevExpress.XtraEditors.SimpleButton();
            this.check = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtProcessUptade = new System.Windows.Forms.RichTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbxSerialNo = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlList)).BeginInit();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMalfunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpAdd)).BeginInit();
            this.grpAdd.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUpdate)).BeginInit();
            this.grpUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSerialNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnAdd.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette;
            this.btnAdd.Location = new System.Drawing.Point(1644, 329);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(341, 197);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Yeni Kayıt";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Appearance.BackColor = System.Drawing.Color.Lime;
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Appearance.Options.UseBackColor = true;
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnUpdate.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette;
            this.btnUpdate.Location = new System.Drawing.Point(1644, 616);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(341, 197);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Kayıt Güncelle";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnList
            // 
            this.btnList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnList.Appearance.BackColor = System.Drawing.Color.Aqua;
            this.btnList.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnList.Appearance.Options.UseBackColor = true;
            this.btnList.Appearance.Options.UseFont = true;
            this.btnList.Appearance.Options.UseForeColor = true;
            this.btnList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnList.ImageOptions.Image")));
            this.btnList.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnList.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette;
            this.btnList.Location = new System.Drawing.Point(1644, 43);
            this.btnList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(341, 197);
            this.btnList.TabIndex = 3;
            this.btnList.Text = "Kayıtları Listele";
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // pnlList
            // 
            this.pnlList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlList.Appearance.BorderColor = System.Drawing.Color.Aqua;
            this.pnlList.Appearance.Options.UseBorderColor = true;
            this.pnlList.Controls.Add(this.dtList);
            this.pnlList.Location = new System.Drawing.Point(12, 43);
            this.pnlList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(1626, 769);
            this.pnlList.TabIndex = 5;
            this.pnlList.Text = "Teknik Servis Ürün Listesi";
            // 
            // dtList
            // 
            this.dtList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtList.Location = new System.Drawing.Point(2, 33);
            this.dtList.MainView = this.grdMalfunction;
            this.dtList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtList.Name = "dtList";
            this.dtList.Size = new System.Drawing.Size(1622, 734);
            this.dtList.TabIndex = 7;
            this.dtList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdMalfunction});
            this.dtList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtList_MouseDown);
            // 
            // grdMalfunction
            // 
            this.grdMalfunction.GridControl = this.dtList;
            this.grdMalfunction.Name = "grdMalfunction";
            this.grdMalfunction.OptionsBehavior.Editable = false;
            this.grdMalfunction.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            this.grdMalfunction.OptionsBehavior.KeepGroupExpandedOnSorting = false;
            this.grdMalfunction.OptionsBehavior.ReadOnly = true;
            this.grdMalfunction.OptionsNavigation.AutoMoveRowFocus = false;
            this.grdMalfunction.OptionsSelection.EnableAppearanceHotTrackedRow = DevExpress.Utils.DefaultBoolean.False;
            this.grdMalfunction.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdMalfunction_FocusedRowChanged);
            this.grdMalfunction.DoubleClick += new System.EventHandler(this.grdMalfunction_DoubleClick);
            // 
            // grpAdd
            // 
            this.grpAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAdd.Appearance.BackColor = System.Drawing.Color.GreenYellow;
            this.grpAdd.Appearance.Options.UseBackColor = true;
            this.grpAdd.AppearanceCaption.BorderColor = System.Drawing.Color.GreenYellow;
            this.grpAdd.AppearanceCaption.Options.UseBorderColor = true;
            this.grpAdd.AutoSize = true;
            this.grpAdd.Controls.Add(this.pnlAdd);
            this.grpAdd.Location = new System.Drawing.Point(9, 44);
            this.grpAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(1628, 769);
            this.grpAdd.TabIndex = 6;
            this.grpAdd.Text = "Yeni Kayıt Ekleme";
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.panel1);
            this.pnlAdd.Controls.Add(this.btnAddMalfunc);
            this.pnlAdd.Controls.Add(this.label5);
            this.pnlAdd.Controls.Add(this.label3);
            this.pnlAdd.Controls.Add(this.label4);
            this.pnlAdd.Controls.Add(this.label2);
            this.pnlAdd.Controls.Add(this.label1);
            this.pnlAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdd.Location = new System.Drawing.Point(2, 33);
            this.pnlAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(1624, 734);
            this.pnlAdd.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GreenYellow;
            this.panel1.Controls.Add(this.txtSeriNo);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.textEdit1);
            this.panel1.Controls.Add(this.btnAddMalfunction);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtProcess);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.txtProblem);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1624, 734);
            this.panel1.TabIndex = 14;
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSeriNo.Location = new System.Drawing.Point(252, 112);
            this.txtSeriNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeriNo.Properties.Appearance.Options.UseFont = true;
            this.txtSeriNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtSeriNo.Size = new System.Drawing.Size(516, 32);
            this.txtSeriNo.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(156, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 24);
            this.label14.TabIndex = 22;
            this.label14.Text = "*Seri No";
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEdit1.Location = new System.Drawing.Point(252, 74);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.textEdit1.Size = new System.Drawing.Size(516, 32);
            this.textEdit1.TabIndex = 21;
            // 
            // btnAddMalfunction
            // 
            this.btnAddMalfunction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMalfunction.Appearance.BackColor = System.Drawing.Color.White;
            this.btnAddMalfunction.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddMalfunction.Appearance.Options.UseBackColor = true;
            this.btnAddMalfunction.Appearance.Options.UseFont = true;
            this.btnAddMalfunction.ImageOptions.Image = global::TechnicService.Properties.Resources.apply_32x32;
            this.btnAddMalfunction.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddMalfunction.Location = new System.Drawing.Point(422, 640);
            this.btnAddMalfunction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddMalfunction.Name = "btnAddMalfunction";
            this.btnAddMalfunction.Size = new System.Drawing.Size(917, 53);
            this.btnAddMalfunction.TabIndex = 16;
            this.btnAddMalfunction.Text = "Ekle";
            this.btnAddMalfunction.Click += new System.EventHandler(this.btnAddMalfunction_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Location = new System.Drawing.Point(906, 167);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(659, 204);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(17, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 24);
            this.label13.TabIndex = 25;
            this.label13.Text = "Telefon";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.Location = new System.Drawing.Point(121, 122);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPhone.Properties.Appearance.Options.UseFont = true;
            this.txtPhone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtPhone.Properties.MaskSettings.Set("mask", "(000) 000-0000");
            this.txtPhone.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtPhone.Size = new System.Drawing.Size(516, 32);
            this.txtPhone.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(17, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 24);
            this.label12.TabIndex = 23;
            this.label12.Text = "Soyad";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.Location = new System.Drawing.Point(121, 85);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLastName.Properties.Appearance.Options.UseFont = true;
            this.txtLastName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtLastName.Size = new System.Drawing.Size(516, 32);
            this.txtLastName.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(17, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 24);
            this.label11.TabIndex = 21;
            this.label11.Text = "Ad";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.Location = new System.Drawing.Point(121, 47);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirstName.Properties.Appearance.Options.UseFont = true;
            this.txtFirstName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtFirstName.Size = new System.Drawing.Size(516, 32);
            this.txtFirstName.TabIndex = 20;
            // 
            // txtProcess
            // 
            this.txtProcess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProcess.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProcess.Location = new System.Drawing.Point(252, 470);
            this.txtProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(516, 134);
            this.txtProcess.TabIndex = 12;
            this.txtProcess.Text = "";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDescription.Location = new System.Drawing.Point(252, 289);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(516, 134);
            this.txtDescription.TabIndex = 11;
            this.txtDescription.Text = "";
            // 
            // txtProblem
            // 
            this.txtProblem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProblem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProblem.Location = new System.Drawing.Point(252, 150);
            this.txtProblem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProblem.Name = "txtProblem";
            this.txtProblem.Size = new System.Drawing.Size(516, 134);
            this.txtProblem.TabIndex = 10;
            this.txtProblem.Text = "";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(154, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "*İşlem";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(154, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "*Fiyat";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.Location = new System.Drawing.Point(252, 433);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPrice.Properties.Appearance.Options.UseFont = true;
            this.txtPrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPrice.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtPrice.Properties.MaskSettings.Set("mask", "c");
            this.txtPrice.Size = new System.Drawing.Size(516, 32);
            this.txtPrice.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(155, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 72);
            this.label9.TabIndex = 5;
            this.label9.Text = "*Teknik \r\n  Servis\r\n  Raporu";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(154, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 48);
            this.label10.TabIndex = 3;
            this.label10.Text = "*Müşteri\r\n Şikayeti\r\n";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(154, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "*Ürün";
            // 
            // btnAddMalfunc
            // 
            this.btnAddMalfunc.Location = new System.Drawing.Point(0, 0);
            this.btnAddMalfunc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddMalfunc.Name = "btnAddMalfunc";
            this.btnAddMalfunc.Size = new System.Drawing.Size(93, 30);
            this.btnAddMalfunc.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(154, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "*İşlem";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(154, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "*Fiyat";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(154, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "*Açıklama";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(154, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "*Problem";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(154, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "*Başlık";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // grpUpdate
            // 
            this.grpUpdate.Appearance.BackColor = System.Drawing.Color.Lime;
            this.grpUpdate.Appearance.BackColor2 = System.Drawing.Color.DarkOliveGreen;
            this.grpUpdate.Appearance.BorderColor = System.Drawing.Color.Lime;
            this.grpUpdate.Appearance.Options.UseBackColor = true;
            this.grpUpdate.Appearance.Options.UseBorderColor = true;
            this.grpUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpUpdate.Controls.Add(this.btnUptated);
            this.grpUpdate.Controls.Add(this.check);
            this.grpUpdate.Controls.Add(this.labelControl3);
            this.grpUpdate.Controls.Add(this.txtProcessUptade);
            this.grpUpdate.Controls.Add(this.labelControl2);
            this.grpUpdate.Controls.Add(this.labelControl1);
            this.grpUpdate.Controls.Add(this.cbxSerialNo);
            this.grpUpdate.Location = new System.Drawing.Point(18, 43);
            this.grpUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(1809, 695);
            this.grpUpdate.TabIndex = 8;
            this.grpUpdate.Text = "Kayıt Güncelle";
            // 
            // btnUptated
            // 
            this.btnUptated.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUptated.Appearance.Options.UseFont = true;
            this.btnUptated.Location = new System.Drawing.Point(619, 462);
            this.btnUptated.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUptated.Name = "btnUptated";
            this.btnUptated.Size = new System.Drawing.Size(443, 57);
            this.btnUptated.TabIndex = 6;
            this.btnUptated.Text = "Güncelle";
            this.btnUptated.Click += new System.EventHandler(this.btnUptated_Click);
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(1129, 222);
            this.check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check.Name = "check";
            this.check.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.check.Properties.Appearance.Options.UseFont = true;
            this.check.Properties.Caption = "Teslim Edildi";
            this.check.Size = new System.Drawing.Size(203, 28);
            this.check.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(1129, 188);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 24);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Durum";
            // 
            // txtProcessUptade
            // 
            this.txtProcessUptade.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProcessUptade.Location = new System.Drawing.Point(619, 222);
            this.txtProcessUptade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProcessUptade.Name = "txtProcessUptade";
            this.txtProcessUptade.Size = new System.Drawing.Size(443, 207);
            this.txtProcessUptade.TabIndex = 3;
            this.txtProcessUptade.Text = "";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(619, 188);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 24);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "İşlem";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(309, 188);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(112, 24);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ürün Seri No";
            // 
            // cbxSerialNo
            // 
            this.cbxSerialNo.Location = new System.Drawing.Point(309, 218);
            this.cbxSerialNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxSerialNo.Name = "cbxSerialNo";
            this.cbxSerialNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxSerialNo.Properties.Appearance.Options.UseFont = true;
            this.cbxSerialNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxSerialNo.Properties.DisplayMember = "SerialNo";
            this.cbxSerialNo.Properties.NullText = "Seri Numara Seçiniz";
            this.cbxSerialNo.Properties.ValueMember = "SerialNo";
            this.cbxSerialNo.Size = new System.Drawing.Size(235, 30);
            this.cbxSerialNo.TabIndex = 0;
            // 
            // FrmMalfunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1998, 889);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.pnlList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMalfunction";
            this.Text = "Teknik Servis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMalfunction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlList)).EndInit();
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMalfunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpAdd)).EndInit();
            this.grpAdd.ResumeLayout(false);
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUpdate)).EndInit();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSerialNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnList;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.GroupControl pnlList;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GroupControl grpAdd;
        private DevExpress.XtraEditors.SimpleButton btnAddMalfunc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtProcess;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.RichTextBox txtProblem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.TextEdit txtFirstName;
        private DevExpress.XtraEditors.SimpleButton btnAddMalfunction;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.GridControl dtList;
        private DevExpress.XtraGrid.Views.Grid.GridView grdMalfunction;
        private DevExpress.XtraEditors.GroupControl grpUpdate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cbxSerialNo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.RichTextBox txtProcessUptade;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnUptated;
        private DevExpress.XtraEditors.CheckEdit check;
        private DevExpress.XtraEditors.TextEdit txtSeriNo;
        private System.Windows.Forms.Label label14;
    }
}