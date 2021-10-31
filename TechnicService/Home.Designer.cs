
namespace TechnicService
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnMalfunction = new DevExpress.XtraBars.BarButtonItem();
            this.skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.btnMalfunctions = new DevExpress.XtraBars.BarButtonItem();
            this.btnProducts = new DevExpress.XtraBars.BarButtonItem();
            this.btnCategory = new DevExpress.XtraBars.BarSubItem();
            this.btnCategoryAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnCategoryDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnCategoryUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnMalfunction,
            this.skinPaletteDropDownButtonItem1,
            this.skinDropDownButtonItem1,
            this.btnMalfunctions,
            this.btnProducts,
            this.btnCategory,
            this.btnCategoryAdd,
            this.btnCategoryDelete,
            this.barToggleSwitchItem1,
            this.btnCategoryUpdate});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 18;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbonControl1.Size = new System.Drawing.Size(1209, 183);
            // 
            // btnMalfunction
            // 
            this.btnMalfunction.Id = 6;
            this.btnMalfunction.Name = "btnMalfunction";
            // 
            // skinPaletteDropDownButtonItem1
            // 
            this.skinPaletteDropDownButtonItem1.Id = 2;
            this.skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 4;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // btnMalfunctions
            // 
            this.btnMalfunctions.Caption = "Arızalı Ürünler";
            this.btnMalfunctions.Id = 5;
            this.btnMalfunctions.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMalfunctions.ImageOptions.Image")));
            this.btnMalfunctions.Name = "btnMalfunctions";
            this.btnMalfunctions.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnMalfunctions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMalfunctions_ItemClick);
            // 
            // btnProducts
            // 
            this.btnProducts.Caption = "Ürünler";
            this.btnProducts.Id = 7;
            this.btnProducts.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.ImageOptions.Image")));
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // btnCategory
            // 
            this.btnCategory.Caption = "Kategoriler";
            this.btnCategory.Id = 9;
            this.btnCategory.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.ImageOptions.Image")));
            this.btnCategory.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCategoryAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCategoryDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCategoryUpdate)});
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Caption = "Kategori Ekle";
            this.btnCategoryAdd.Id = 10;
            this.btnCategoryAdd.ImageOptions.Image = global::TechnicService.Properties.Resources.add_16x16;
            this.btnCategoryAdd.ImageOptions.LargeImage = global::TechnicService.Properties.Resources.add_32x32;
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCategoryAdd_ItemClick);
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.Caption = "Kategori Sil";
            this.btnCategoryDelete.Id = 11;
            this.btnCategoryDelete.ImageOptions.Image = global::TechnicService.Properties.Resources.removepivotfield_16x16;
            this.btnCategoryDelete.ImageOptions.LargeImage = global::TechnicService.Properties.Resources.removepivotfield_32x32;
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCategoryDelete_ItemClick);
            // 
            // btnCategoryUpdate
            // 
            this.btnCategoryUpdate.Caption = "Kategori Güncelle";
            this.btnCategoryUpdate.Id = 17;
            this.btnCategoryUpdate.ImageOptions.Image = global::TechnicService.Properties.Resources.refreshallpivottable_16x16;
            this.btnCategoryUpdate.ImageOptions.LargeImage = global::TechnicService.Properties.Resources.refreshallpivottable_32x32;
            this.btnCategoryUpdate.Name = "btnCategoryUpdate";
            this.btnCategoryUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCategoryUpdate_ItemClick);
            // 
            // barToggleSwitchItem1
            // 
            this.barToggleSwitchItem1.Caption = "barToggleSwitchItem1";
            this.barToggleSwitchItem1.Id = 16;
            this.barToggleSwitchItem1.Name = "barToggleSwitchItem1";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Arızalı Ürünler";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.skinDropDownButtonItem1);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnMalfunctions);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Ürünler";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnProducts);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnCategory);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage1});
            this.ribbonPageCategory1.Text = "ribbonPageCategory1";
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1209, 722);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnMalfunction;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnMalfunctions;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnProducts;
        private DevExpress.XtraBars.BarSubItem btnCategory;
        private DevExpress.XtraBars.BarButtonItem btnCategoryAdd;
        private DevExpress.XtraBars.BarButtonItem btnCategoryDelete;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private DevExpress.XtraBars.BarButtonItem btnCategoryUpdate;
    }
}