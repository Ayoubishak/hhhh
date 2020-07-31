using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace ArmyProject.PL.Views.Students_TBLView{
    public partial class Students_TBLView : XtraUserControl {
        public Students_TBLView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<ArmyProject.PL.ViewModels.Students_TBLViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                students_TBLViewBindingSource, x => x.Entity, x => x.Update());
									// Binding for ArrivalStations_TBL LookUp editor
			fluentAPI.SetBinding(ArrivalStations_TBLLookUpEdit.Properties, p => p.DataSource, x => x.LookUpArrivalStations_TBL.Entities);
						// Binding for Degree_TBL LookUp editor
			fluentAPI.SetBinding(Degree_TBLLookUpEdit.Properties, p => p.DataSource, x => x.LookUpDegree_TBL.Entities);
						// Binding for Governorates_TBL LookUp editor
			fluentAPI.SetBinding(Governorates_TBLLookUpEdit.Properties, p => p.DataSource, x => x.LookUpGovernorates_TBL.Entities);
						// Binding for RecruitingArea_TBL LookUp editor
			fluentAPI.SetBinding(RecruitingArea_TBLLookUpEdit.Properties, p => p.DataSource, x => x.LookUpRecruitingArea_TBL.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
