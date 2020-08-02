using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace ArmyProject.PL.FRM_Degree_Crud.Views.Degree_TBLView{
    public partial class Degree_TBLView : XtraUserControl {
        public Degree_TBLView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<ArmyProject.PL.FRM_Degree_Crud.ViewModels.Degree_TBLViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                degree_TBLViewBindingSource, x => x.Entity, x => x.Update());
						 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }

        private void barButtonItemPrintDeg_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            Students_TBLGridControl.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            Students_TBLGridControl.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            Students_TBLGridControl.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            Students_TBLGridControl.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            Students_TBLGridControl.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            Students_TBLGridControl.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void barButtonItemCloseW_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(ArmyProject.PL.FRM_Degree_Crud.ViewModels.Degree_TBLViewModel), "Close", this.bbiClose);
        }
    }
}
