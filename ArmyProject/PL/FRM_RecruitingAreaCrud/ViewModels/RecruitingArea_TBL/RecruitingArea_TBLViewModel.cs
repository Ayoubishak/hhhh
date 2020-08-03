using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using ArmyProject.PL.FRM_RecruitingAreaCrud.Army_DBEntitiesDataModel;
using ArmyProject.PL.FRM_RecruitingAreaCrud.Common;
using ArmyProject;

namespace ArmyProject.PL.FRM_RecruitingAreaCrud.ViewModels {

    /// <summary>
    /// Represents the single RecruitingArea_TBL object view model.
    /// </summary>
    public partial class RecruitingArea_TBLViewModel : SingleObjectViewModel<RecruitingArea_TBL, string, IArmy_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of RecruitingArea_TBLViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static RecruitingArea_TBLViewModel Create(IUnitOfWorkFactory<IArmy_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new RecruitingArea_TBLViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the RecruitingArea_TBLViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the RecruitingArea_TBLViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected RecruitingArea_TBLViewModel(IUnitOfWorkFactory<IArmy_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.RecruitingArea_TBL, x => x.RecName) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Students_TBL for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Students_TBL> LookUpStudents_TBL {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (RecruitingArea_TBLViewModel x) => x.LookUpStudents_TBL,
                    getRepositoryFunc: x => x.Students_TBL);
            }
        }


        /// <summary>
        /// The view model for the RecruitingArea_TBLStudents_TBL detail collection.
        /// </summary>
        public CollectionViewModelBase<Students_TBL, Students_TBL, int, IArmy_DBEntitiesUnitOfWork> RecruitingArea_TBLStudents_TBLDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (RecruitingArea_TBLViewModel x) => x.RecruitingArea_TBLStudents_TBLDetails,
                    getRepositoryFunc: x => x.Students_TBL,
                    foreignKeyExpression: x => x.RecruitingArea,
                    navigationExpression: x => x.RecruitingArea_TBL);
            }
        }
    }
}
