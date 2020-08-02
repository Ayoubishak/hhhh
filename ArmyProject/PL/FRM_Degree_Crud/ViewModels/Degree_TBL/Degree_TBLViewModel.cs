using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using ArmyProject.PL.FRM_Degree_Crud.Army_DBEntitiesDataModel;
using ArmyProject.PL.FRM_Degree_Crud.Common;
using ArmyProject;

namespace ArmyProject.PL.FRM_Degree_Crud.ViewModels {

    /// <summary>
    /// Represents the single Degree_TBL object view model.
    /// </summary>
    public partial class Degree_TBLViewModel : SingleObjectViewModel<Degree_TBL, string, IArmy_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Degree_TBLViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Degree_TBLViewModel Create(IUnitOfWorkFactory<IArmy_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Degree_TBLViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Degree_TBLViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Degree_TBLViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Degree_TBLViewModel(IUnitOfWorkFactory<IArmy_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Degree_TBL, x => x.DegName) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Students_TBL for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Students_TBL> LookUpStudents_TBL {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Degree_TBLViewModel x) => x.LookUpStudents_TBL,
                    getRepositoryFunc: x => x.Students_TBL);
            }
        }


        /// <summary>
        /// The view model for the Degree_TBLStudents_TBL detail collection.
        /// </summary>
        public CollectionViewModelBase<Students_TBL, Students_TBL, int, IArmy_DBEntitiesUnitOfWork> Degree_TBLStudents_TBLDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Degree_TBLViewModel x) => x.Degree_TBLStudents_TBLDetails,
                    getRepositoryFunc: x => x.Students_TBL,
                    foreignKeyExpression: x => x.Degree,
                    navigationExpression: x => x.Degree_TBL);
            }
        }
    }
}
