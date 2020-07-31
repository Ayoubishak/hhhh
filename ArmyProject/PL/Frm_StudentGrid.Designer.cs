namespace ArmyProject.PL
{
    partial class Frm_StudentGrid
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.armyDBDataSetForGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.army_DBDataSetForGrid = new ArmyProject.Army_DBDataSetForGrid();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.students_TBLTableAdapter1 = new ArmyProject.Army_DBDataSetForGridTableAdapters.Students_TBLTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armyDBDataSetForGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.army_DBDataSetForGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsPrint.ExpandAllGroups = false;
            this.gridView2.OptionsPrint.PrintFilterInfo = true;
            this.gridView2.OptionsPrint.PrintGroupFooter = false;
            this.gridView2.OptionsPrint.PrintSelectedRowsOnly = true;
            // 
            // gridControl1
            // 
            this.gridControl1.AllowDrop = true;
            this.gridControl1.DataSource = this.armyDBDataSetForGridBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "Students_TBL";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(138, 0);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(793, 473);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click_1);
            // 
            // armyDBDataSetForGridBindingSource
            // 
            this.armyDBDataSetForGridBindingSource.DataSource = this.army_DBDataSetForGrid;
            this.armyDBDataSetForGridBindingSource.Position = 0;
            // 
            // army_DBDataSetForGrid
            // 
            this.army_DBDataSetForGrid.DataSetName = "Army_DBDataSetForGrid";
            this.army_DBDataSetForGrid.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 138;
            this.navBarControl1.Size = new System.Drawing.Size(138, 473);
            this.navBarControl1.TabIndex = 0;
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "navBarGroup1";
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // students_TBLTableAdapter1
            // 
            this.students_TBLTableAdapter1.ClearBeforeFill = true;
            // 
            // Frm_StudentGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.navBarControl1);
            this.Name = "Frm_StudentGrid";
            this.Size = new System.Drawing.Size(931, 473);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armyDBDataSetForGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.army_DBDataSetForGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private System.Windows.Forms.BindingSource armyDBDataSetForGridBindingSource;
        private Army_DBDataSetForGrid army_DBDataSetForGrid;
        private Army_DBDataSetForGridTableAdapters.Students_TBLTableAdapter students_TBLTableAdapter1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        public DevExpress.XtraGrid.GridControl gridControl1;
    }
}
