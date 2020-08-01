using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using ArmyProject.PL.FRM_Holiday_FULL_Crud.Army_DBEntitiesDataModel;

namespace ArmyProject.PL.FRM_Holiday_FULL_Crud.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the Army_DBEntities data model.
    /// </summary>
    public partial class Army_DBEntitiesViewModel : DocumentsViewModel<Army_DBEntitiesModuleDescription, IArmy_DBEntitiesUnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";
		INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
	
        /// <summary>
        /// Creates a new instance of Army_DBEntitiesViewModel as a POCO view model.
        /// </summary>
        public static Army_DBEntitiesViewModel Create() {
            return ViewModelSource.Create(() => new Army_DBEntitiesViewModel());
        }

		
        /// <summary>
        /// Initializes a new instance of the Army_DBEntitiesViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Army_DBEntitiesViewModel type without the POCO proxy factory.
        /// </summary>
        protected Army_DBEntitiesViewModel()
		    : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override Army_DBEntitiesModuleDescription[] CreateModules() {
			return new Army_DBEntitiesModuleDescription[] {
                new Army_DBEntitiesModuleDescription( "Governorates TBL", "Governorates_TBLCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Governorates_TBL)),
			};
        }
                		protected override void OnActiveModuleChanged(Army_DBEntitiesModuleDescription oldModule) {
            if(ActiveModule != null && NavigationService != null) {
                NavigationService.ClearNavigationHistory();
            }
            base.OnActiveModuleChanged(oldModule);
        }
	}

    public partial class Army_DBEntitiesModuleDescription : ModuleDescription<Army_DBEntitiesModuleDescription> {
        public Army_DBEntitiesModuleDescription(string title, string documentType, string group, Func<Army_DBEntitiesModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}