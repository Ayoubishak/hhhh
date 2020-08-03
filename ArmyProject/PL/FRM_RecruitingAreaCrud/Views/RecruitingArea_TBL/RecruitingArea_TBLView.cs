using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace ArmyProject.PL.FRM_RecruitingAreaCrud.Views.RecruitingArea_TBLView{
    public partial class RecruitingArea_TBLView : XtraUserControl {
        public RecruitingArea_TBLView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<ArmyProject.PL.FRM_RecruitingAreaCrud.ViewModels.RecruitingArea_TBLViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                recruitingArea_TBLViewBindingSource, x => x.Entity, x => x.Update());
						 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
