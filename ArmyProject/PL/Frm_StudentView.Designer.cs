namespace ArmyProject.PL
{
    partial class Frm_StudentView
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.armyDBDataSetViewStudentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.army_DBDataSetViewStudents = new ArmyProject.Army_DBDataSetViewStudents();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cardView2 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.armyDBDataSetViewStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.students_TBLTableAdapter1 = new ArmyProject.Army_DBDataSetViewStudentsTableAdapters.Students_TBLTableAdapter();
            this.governorates_TBLTableAdapter1 = new ArmyProject.Army_DBDataSetViewStudentsTableAdapters.Governorates_TBLTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armyDBDataSetViewStudentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.army_DBDataSetViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armyDBDataSetViewStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // cardView1
            // 
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            // 
            // gridControl1
            // 
            this.gridControl1.AllowDrop = true;
            this.gridControl1.DataSource = this.armyDBDataSetViewStudentsBindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView1;
            gridLevelNode2.LevelTemplate = this.cardView1;
            gridLevelNode2.RelationName = "FK_Students_TBL_Governorates_TBL";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            gridLevelNode1.RelationName = "Governorates_TBL";
            gridLevelNode3.RelationName = "Students_TBL";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode3});
            this.gridControl1.Location = new System.Drawing.Point(120, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(827, 466);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.gridView6,
            this.cardView2,
            this.gridView3,
            this.gridView4,
            this.gridView1,
            this.cardView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // armyDBDataSetViewStudentsBindingSource1
            // 
            this.armyDBDataSetViewStudentsBindingSource1.DataSource = this.army_DBDataSetViewStudents;
            this.armyDBDataSetViewStudentsBindingSource1.Position = 0;
            // 
            // army_DBDataSetViewStudents
            // 
            this.army_DBDataSetViewStudents.DataSetName = "Army_DBDataSetViewStudents";
            this.army_DBDataSetViewStudents.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "البيانات";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridView6
            // 
            this.gridView6.GridControl = this.gridControl1;
            this.gridView6.Name = "gridView6";
            // 
            // cardView2
            // 
            this.cardView2.GridControl = this.gridControl1;
            this.cardView2.Name = "cardView2";
            this.cardView2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gridControl1;
            this.gridView4.Name = "gridView4";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // armyDBDataSetViewStudentsBindingSource
            // 
            this.armyDBDataSetViewStudentsBindingSource.DataSource = this.army_DBDataSetViewStudents;
            this.armyDBDataSetViewStudentsBindingSource.Position = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3,
            this.navBarGroup4});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 120;
            this.navBarControl1.Size = new System.Drawing.Size(120, 466);
            this.navBarControl1.TabIndex = 0;
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "navBarGroup1";
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "navBarGroup2";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "navBarGroup3";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "navBarGroup4";
            this.navBarGroup4.Expanded = true;
            this.navBarGroup4.Name = "navBarGroup4";
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(947, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(16, 466);
            this.panelControl1.TabIndex = 1;
            // 
            // students_TBLTableAdapter1
            // 
            this.students_TBLTableAdapter1.ClearBeforeFill = true;
            // 
            // governorates_TBLTableAdapter1
            // 
            this.governorates_TBLTableAdapter1.ClearBeforeFill = true;
            // 
            // Frm_StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.navBarControl1);
            this.Name = "Frm_StudentView";
            this.Size = new System.Drawing.Size(963, 466);
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armyDBDataSetViewStudentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.army_DBDataSetViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armyDBDataSetViewStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private System.Windows.Forms.BindingSource armyDBDataSetViewStudentsBindingSource;
        private Army_DBDataSetViewStudents army_DBDataSetViewStudents;
        private System.Windows.Forms.BindingSource armyDBDataSetViewStudentsBindingSource1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Views.Card.CardView cardView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Army_DBDataSetViewStudentsTableAdapters.Students_TBLTableAdapter students_TBLTableAdapter1;
        public DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private Army_DBDataSetViewStudentsTableAdapters.Governorates_TBLTableAdapter governorates_TBLTableAdapter1;
    }
}
