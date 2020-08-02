using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using ArmyProject.PL.FRM_Degree_Crud.Army_DBEntitiesDataModel;
using ArmyProject.PL.FRM_Degree_Crud.Common;
using ArmyProject;

namespace ArmyProject.PL.FRM_Degree_Crud.ViewModels {

    /// <summary>
    /// Represents the Degree_TBL collection view model.
    /// </summary>
    public partial class Degree_TBLCollectionViewModel : CollectionViewModel<Degree_TBL, string, IArmy_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Degree_TBLCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Degree_TBLCollectionViewModel Create(IUnitOfWorkFactory<IArmy_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Degree_TBLCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Degree_TBLCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Degree_TBLCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Degree_TBLCollectionViewModel(IUnitOfWorkFactory<IArmy_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Degree_TBL) {
        }
    }
}