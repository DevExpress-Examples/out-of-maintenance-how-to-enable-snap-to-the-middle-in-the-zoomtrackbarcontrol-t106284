namespace ZoomTrackBarControl_MiddleValue {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customRepositoryItem1 = new ZoomTrackBarControl_MiddleValue.CustomRepositoryItem();
            this.customZoomTrackBar1 = new ZoomTrackBarControl_MiddleValue.CustomZoomTrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customRepositoryItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customZoomTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customZoomTrackBar1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 54);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.customRepositoryItem1});
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.ColumnEdit = this.customRepositoryItem1;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // customRepositoryItem1
            // 
            this.customRepositoryItem1.Maximum = 100;
            this.customRepositoryItem1.Middle = 5;
            this.customRepositoryItem1.MiddleDistance = 50;
            this.customRepositoryItem1.Name = "customRepositoryItem1";
            this.customRepositoryItem1.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            this.customRepositoryItem1.SnapToMiddleValue = false;
            // 
            // customZoomTrackBar1
            // 
            this.customZoomTrackBar1.EditValue = null;
            this.customZoomTrackBar1.Location = new System.Drawing.Point(12, 12);
            this.customZoomTrackBar1.Name = "customZoomTrackBar1";
            this.customZoomTrackBar1.Properties.Maximum = 100;
            this.customZoomTrackBar1.Properties.Middle = 5;
            this.customZoomTrackBar1.Properties.MiddleDistance = 10;
            this.customZoomTrackBar1.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            this.customZoomTrackBar1.Properties.SnapToMiddleValue = false;
            this.customZoomTrackBar1.Size = new System.Drawing.Size(202, 23);
            this.customZoomTrackBar1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 266);
            this.Controls.Add(this.customZoomTrackBar1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customRepositoryItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customZoomTrackBar1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customZoomTrackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private CustomZoomTrackBar customZoomTrackBar1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private CustomRepositoryItem customRepositoryItem1;



    }
}

