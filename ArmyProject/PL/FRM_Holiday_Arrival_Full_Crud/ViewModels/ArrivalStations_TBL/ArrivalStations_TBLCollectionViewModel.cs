using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using ArmyProject.PL.FRM_Holiday_Arrival_Full_Crud.Army_DBEntitiesDataModel;
using ArmyProject.PL.FRM_Holiday_Arrival_Full_Crud.Common;
using ArmyProject;

namespace ArmyProject.PL.FRM_Holiday_Arrival_Full_Crud.ViewModels {

    /// <summary>
    /// Represents the ArrivalStations_TBL collection view model.
    /// </summary>
    public partial class ArrivalStations_TBLCollectionViewModel : CollectionViewModel<ArrivalStations_TBL, int, IArmy_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ArrivalStations_TBLCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ArrivalStations_TBLCollectionViewModel Create(IUnitOfWorkFactory<IArmy_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ArrivalStations_TBLCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ArrivalStations_TBLCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ArrivalStations_TBLCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ArrivalStations_TBLCollectionViewModel(IUnitOfWorkFactory<IArmy_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.ArrivalStations_TBL) {
        }
    }
}