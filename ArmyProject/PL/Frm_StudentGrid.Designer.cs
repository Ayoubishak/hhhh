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
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.armyDBDataSetForGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.army_DBDataSetForGrid = new ArmyProject.Army_DBDataSetForGrid();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.students_TBLTableAdapter1 = new ArmyProject.Army_DBDataSetForGridTableAdapters.Students_TBLTableAdapter();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armyDBDataSetForGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.army_DBDataSetForGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 200;
            this.navBarControl1.Size = new System.Drawing.Size(200, 473);
            this.navBarControl1.TabIndex = 0;
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "navBarGroup1";
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.armyDBDataSetForGridBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "Students_TBL";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(200, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(731, 473);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
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
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // students_TBLTableAdapter1
            // 
            this.students_TBLTableAdapter1.ClearBeforeFill = true;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // Frm_StudentGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.navBarControl1);
            this.Name = "Frm_StudentGrid";
            this.Size = new System.Drawing.Size(931, 473);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armyDBDataSetForGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.army_DBDataSetForGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource armyDBDataSetForGridBindingSource;
        private Army_DBDataSetForGrid army_DBDataSetForGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Army_DBDataSetForGridTableAdapters.Students_TBLTableAdapter students_TBLTableAdapter1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}
