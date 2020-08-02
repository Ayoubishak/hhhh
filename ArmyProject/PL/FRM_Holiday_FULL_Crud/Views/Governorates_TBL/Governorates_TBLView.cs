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

        /*
         تغيير الاى دي لمحطة الوصول فى الطالب مثل التى فى المحافظة
         create proc SP_UpdateArrivalIdInStudents
         AS
         Update Students_TBL
         Set Students_TBL.ArrivalStations_Id = Governorates_TBL.ArrivalStations_Id
         from Students_TBL Inner join Governorates_TBL
         ON Students_TBL.Governorate = Governorates_TBL.GovName 
         */
        private void ArrivalStations_TBLLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            BL.CLS_Students stu = new BL.CLS_Students();
            stu.UpdateArrivalIdInStudents();
        }
    }
}
