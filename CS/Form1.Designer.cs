namespace DynamicDataTable {
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
            if(disposing && (components != null)) {
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
            this.cmbTables = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblTables = new DevExpress.XtraEditors.LabelControl();
            this.pnlTables = new DevExpress.XtraEditors.PanelControl();
            this.grdTableBrowser = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTables.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTables)).BeginInit();
            this.pnlTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTableBrowser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTables
            // 
            this.cmbTables.Location = new System.Drawing.Point(136, 8);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTables.Properties.Sorted = true;
            this.cmbTables.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbTables.Size = new System.Drawing.Size(198, 20);
            this.cmbTables.TabIndex = 0;
            // 
            // lblTables
            // 
            this.lblTables.Location = new System.Drawing.Point(12, 11);
            this.lblTables.Name = "lblTables";
            this.lblTables.Size = new System.Drawing.Size(118, 13);
            this.lblTables.TabIndex = 1;
            this.lblTables.Text = "Choose table to browse:";
            // 
            // pnlTables
            // 
            this.pnlTables.Controls.Add(this.lblTables);
            this.pnlTables.Controls.Add(this.cmbTables);
            this.pnlTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTables.Location = new System.Drawing.Point(0, 0);
            this.pnlTables.Name = "pnlTables";
            this.pnlTables.Size = new System.Drawing.Size(664, 36);
            this.pnlTables.TabIndex = 2;
            // 
            // grdTableBrowser
            // 
            this.grdTableBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTableBrowser.Location = new System.Drawing.Point(0, 36);
            this.grdTableBrowser.MainView = this.gridView1;
            this.grdTableBrowser.Name = "grdTableBrowser";
            this.grdTableBrowser.Size = new System.Drawing.Size(664, 445);
            this.grdTableBrowser.TabIndex = 3;
            this.grdTableBrowser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdTableBrowser;
            this.gridView1.Name = "gridView1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 481);
            this.Controls.Add(this.grdTableBrowser);
            this.Controls.Add(this.pnlTables);
            this.Name = "Form1";
            this.Text = "Northwind Browser";
            ((System.ComponentModel.ISupportInitialize)(this.cmbTables.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTables)).EndInit();
            this.pnlTables.ResumeLayout(false);
            this.pnlTables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTableBrowser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmbTables;
        private DevExpress.XtraEditors.LabelControl lblTables;
        private DevExpress.XtraEditors.PanelControl pnlTables;
        private DevExpress.XtraGrid.GridControl grdTableBrowser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}

