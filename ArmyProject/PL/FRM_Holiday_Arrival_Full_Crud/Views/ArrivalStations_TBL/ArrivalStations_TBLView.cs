using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace ArmyProject.PL.FRM_Holiday_Arrival_Full_Crud.Views.ArrivalStations_TBLView{
    public partial class ArrivalStations_TBLView : XtraUserControl {
        public ArrivalStations_TBLView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<ArmyProject.PL.FRM_Holiday_Arrival_Full_Crud.ViewModels.ArrivalStations_TBLViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                arrivalStations_TBLViewBindingSource, x => x.Entity, x => x.Update());
									// Binding for Transport_TBL LookUp editor
			fluentAPI.SetBinding(Transport_TBLLookUpEdit.Properties, p => p.DataSource, x => x.LookUpTransport_TBL.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
