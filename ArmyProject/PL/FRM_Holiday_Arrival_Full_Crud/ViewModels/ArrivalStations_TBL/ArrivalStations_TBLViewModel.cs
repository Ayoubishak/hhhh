using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using ArmyProject.PL.FRM_Holiday_Arrival_Full_Crud.Army_DBEntitiesDataModel;
using ArmyProject.PL.FRM_Holiday_Arrival_Full_Crud.Common;
using ArmyProject;

namespace ArmyProject.PL.FRM_Holiday_Arrival_Full_Crud.ViewModels {

    /// <summary>
    /// Represents the single ArrivalStations_TBL object view model.
    /// </summary>
    public partial class ArrivalStations_TBLViewModel : SingleObjectViewModel<ArrivalStations_TBL, int, IArmy_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ArrivalStations_TBLViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ArrivalStations_TBLViewModel Create(IUnitOfWorkFactory<IArmy_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ArrivalStations_TBLViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ArrivalStations_TBLViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ArrivalStations_TBLViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ArrivalStations_TBLViewModel(IUnitOfWorkFactory<IArmy_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.ArrivalStations_TBL, x => x.ArriName) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Students_TBL for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Students_TBL> LookUpStudents_TBL {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ArrivalStations_TBLViewModel x) => x.LookUpStudents_TBL,
                    getRepositoryFunc: x => x.Students_TBL);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Governorates_TBL for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Governorates_TBL> LookUpGovernorates_TBL {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ArrivalStations_TBLViewModel x) => x.LookUpGovernorates_TBL,
                    getRepositoryFunc: x => x.Governorates_TBL);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Transport_TBL for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Transport_TBL> LookUpTransport_TBL {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ArrivalStations_TBLViewModel x) => x.LookUpTransport_TBL,
                    getRepositoryFunc: x => x.Transport_TBL);
            }
        }


        /// <summary>
        /// The view model for the ArrivalStations_TBLStudents_TBL detail collection.
        /// </summary>
        public CollectionViewModelBase<Students_TBL, Students_TBL, int, IArmy_DBEntitiesUnitOfWork> ArrivalStations_TBLStudents_TBLDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ArrivalStations_TBLViewModel x) => x.ArrivalStations_TBLStudents_TBLDetails,
                    getRepositoryFunc: x => x.Students_TBL,
                    foreignKeyExpression: x => x.ArrivalStations_Id,
                    navigationExpression: x => x.ArrivalStations_TBL);
            }
        }

        /// <summary>
        /// The view model for the ArrivalStations_TBLGovernorates_TBL detail collection.
        /// </summary>
        public CollectionViewModelBase<Governorates_TBL, Governorates_TBL, string, IArmy_DBEntitiesUnitOfWork> ArrivalStations_TBLGovernorates_TBLDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ArrivalStations_TBLViewModel x) => x.ArrivalStations_TBLGovernorates_TBLDetails,
                    getRepositoryFunc: x => x.Governorates_TBL,
                    foreignKeyExpression: x => x.ArrivalStations_Id,
                    navigationExpression: x => x.ArrivalStations_TBL);
            }
        }
    }
}
