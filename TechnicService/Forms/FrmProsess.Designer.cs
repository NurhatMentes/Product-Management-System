
namespace TechnicService.Forms
{
    partial class FrmProsess
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
            this.dtProsess = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtProsess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtProsess
            // 
            this.dtProsess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtProsess.Location = new System.Drawing.Point(0, 0);
            this.dtProsess.MainView = this.gridView1;
            this.dtProsess.Name = "dtProsess";
            this.dtProsess.Size = new System.Drawing.Size(1413, 713);
            this.dtProsess.TabIndex = 0;
            this.dtProsess.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dtProsess;
            this.gridView1.Name = "gridView1";
            // 
            // FrmProsess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 713);
            this.Controls.Add(this.dtProsess);
            this.Name = "FrmProsess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProsessForm";
            this.Load += new System.EventHandler(this.FrmProsess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtProsess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dtProsess;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}