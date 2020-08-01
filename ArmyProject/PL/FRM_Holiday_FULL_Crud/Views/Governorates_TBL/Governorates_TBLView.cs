using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace ArmyProject.PL.FRM_Holiday_FULL_Crud.Views.Governorates_TBLView{
    public partial class Governorates_TBLView : XtraUserControl {
        public Governorates_TBLView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<ArmyProject.PL.FRM_Holiday_FULL_Crud.ViewModels.Governorates_TBLViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                governorates_TBLViewBindingSource, x => x.Entity, x => x.Update());
									// Binding for ArrivalStations_TBL LookUp editor
			fluentAPI.SetBinding(ArrivalStations_TBLLookUpEdit.Properties, p => p.DataSource, x => x.LookUpArrivalStations_TBL.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
