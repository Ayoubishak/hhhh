using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using ArmyProject.PL.FRM_Holiday_FULL_Crud.Army_DBEntitiesDataModel;
using ArmyProject.PL.FRM_Holiday_FULL_Crud.Common;
using ArmyProject;

namespace ArmyProject.PL.FRM_Holiday_FULL_Crud.ViewModels {

    /// <summary>
    /// Represents the Governorates_TBL collection view model.
    /// </summary>
    public partial class Governorates_TBLCollectionViewModel : CollectionViewModel<Governorates_TBL, string, IArmy_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Governorates_TBLCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Governorates_TBLCollectionViewModel Create(IUnitOfWorkFactory<IArmy_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Governorates_TBLCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Governorates_TBLCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Governorates_TBLCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Governorates_TBLCollectionViewModel(IUnitOfWorkFactory<IArmy_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Governorates_TBL) {
        }
    }
}