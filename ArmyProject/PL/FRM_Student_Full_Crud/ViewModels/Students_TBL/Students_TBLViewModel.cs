using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using ArmyProject.PL.Army_DBEntities1DataModel;
using ArmyProject.PL.Common;
using ArmyProject;

namespace ArmyProject.PL.ViewModels {

    /// <summary>
    /// Represents the single Students_TBL object view model.
    /// </summary>
    public partial class Students_TBLViewModel : SingleObjectViewModel<Students_TBL, int, IArmy_DBEntities1UnitOfWork> {

        /// <summary>
        /// Creates a new instance of Students_TBLViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Students_TBLViewModel Create(IUnitOfWorkFactory<IArmy_DBEntities1UnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Students_TBLViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Students_TBLViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Students_TBLViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Students_TBLViewModel(IUnitOfWorkFactory<IArmy_DBEntities1UnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Students_TBL, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Student_Sanctions_TBL for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Student_Sanctions_TBL> LookUpStudent_Sanctions_TBL {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Students_TBLViewModel x) => x.LookUpStudent_Sanctions_TBL,
                    getRepositoryFunc: x => x.Student_Sanctions_TBL);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of ArrivalStations_TBL for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ArrivalStations_TBL> LookUpArrivalStations_TBL {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Students_TBLViewModel x) => x.LookUpArrivalStations_TBL,
                    getRepositoryFunc: x => x.ArrivalStations_TBL);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Degree_TBL for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Degree_TBL> LookUpDegree_TBL {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Students_TBLViewModel x) => x.LookUpDegree_TBL,
                    getRepositoryFunc: x => x.Degree_TBL);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Governorates_TBL for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Governorates_TBL> LookUpGovernorates_TBL {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Students_TBLViewModel x) => x.LookUpGovernorates_TBL,
                    getRepositoryFunc: x => x.Governorates_TBL);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of RecruitingArea_TBL for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<RecruitingArea_TBL> LookUpRecruitingArea_TBL {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Students_TBLViewModel x) => x.LookUpRecruitingArea_TBL,
                    getRepositoryFunc: x => x.RecruitingArea_TBL);
            }
        }


        /// <summary>
        /// The view model for the Students_TBLStudent_Sanctions_TBL detail collection.
        /// </summary>
        public CollectionViewModelBase<Student_Sanctions_TBL, Student_Sanctions_TBL, int, IArmy_DBEntities1UnitOfWork> Students_TBLStudent_Sanctions_TBLDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Students_TBLViewModel x) => x.Students_TBLStudent_Sanctions_TBLDetails,
                    getRepositoryFunc: x => x.Student_Sanctions_TBL,
                    foreignKeyExpression: x => x.Student_Id,
                    navigationExpression: x => x.Students_TBL);
            }
        }
    }
}
