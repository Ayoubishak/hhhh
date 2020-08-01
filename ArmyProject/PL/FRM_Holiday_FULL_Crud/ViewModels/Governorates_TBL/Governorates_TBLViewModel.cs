using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using ArmyProject.PL.FRM_Holiday_FULL_Crud.Army_DBEntitiesDataModel;
using ArmyProject.PL.FRM_Holiday_FULL_Crud.Common;
using ArmyProject;

namespace ArmyProject.PL.FRM_Holiday_FULL_Crud.ViewModels {

    /// <summary>
    /// Represents the single Governorates_TBL object view model.
    /// </summary>
    public partial class Governorates_TBLViewModel : SingleObjectViewModel<Governorates_TBL, string, IArmy_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Governorates_TBLViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Governorates_TBLViewModel Create(IUnitOfWorkFactory<IArmy_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Governorates_TBLViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Governorates_TBLViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Governorates_TBLViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Governorates_TBLViewModel(IUnitOfWorkFactory<IArmy_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Governorates_TBL, x => x.GovName) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Students_TBL for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Students_TBL> LookUpStudents_TBL {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Governorates_TBLViewModel x) => x.LookUpStudents_TBL,
                    getRepositoryFunc: x => x.Students_TBL);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of ArrivalStations_TBL for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ArrivalStations_TBL> LookUpArrivalStations_TBL {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Governorates_TBLViewModel x) => x.LookUpArrivalStations_TBL,
                    getRepositoryFunc: x => x.ArrivalStations_TBL);
            }
        }


        /// <summary>
        /// The view model for the Governorates_TBLStudents_TBL detail collection.
        /// </summary>
        public CollectionViewModelBase<Students_TBL, Students_TBL, int, IArmy_DBEntitiesUnitOfWork> Governorates_TBLStudents_TBLDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Governorates_TBLViewModel x) => x.Governorates_TBLStudents_TBLDetails,
                    getRepositoryFunc: x => x.Students_TBL,
                    foreignKeyExpression: x => x.Governorate,
                    navigationExpression: x => x.Governorates_TBL);
            }
        }
    }
}
