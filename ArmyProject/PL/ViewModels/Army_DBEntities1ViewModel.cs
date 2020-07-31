using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using ArmyProject.PL.Army_DBEntities1DataModel;

namespace ArmyProject.PL.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the Army_DBEntities1 data model.
    /// </summary>
    public partial class Army_DBEntities1ViewModel : DocumentsViewModel<Army_DBEntities1ModuleDescription, IArmy_DBEntities1UnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";
		INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
	
        /// <summary>
        /// Creates a new instance of Army_DBEntities1ViewModel as a POCO view model.
        /// </summary>
        public static Army_DBEntities1ViewModel Create() {
            return ViewModelSource.Create(() => new Army_DBEntities1ViewModel());
        }

		
        /// <summary>
        /// Initializes a new instance of the Army_DBEntities1ViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Army_DBEntities1ViewModel type without the POCO proxy factory.
        /// </summary>
        protected Army_DBEntities1ViewModel()
		    : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override Army_DBEntities1ModuleDescription[] CreateModules() {
			return new Army_DBEntities1ModuleDescription[] {
                new Army_DBEntities1ModuleDescription( "Students TBL", "Students_TBLCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Students_TBL)),
			};
        }
                		protected override void OnActiveModuleChanged(Army_DBEntities1ModuleDescription oldModule) {
            if(ActiveModule != null && NavigationService != null) {
                NavigationService.ClearNavigationHistory();
            }
            base.OnActiveModuleChanged(oldModule);
        }
	}

    public partial class Army_DBEntities1ModuleDescription : ModuleDescription<Army_DBEntities1ModuleDescription> {
        public Army_DBEntities1ModuleDescription(string title, string documentType, string group, Func<Army_DBEntities1ModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}