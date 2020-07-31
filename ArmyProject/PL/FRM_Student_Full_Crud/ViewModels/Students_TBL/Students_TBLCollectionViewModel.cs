using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using ArmyProject.PL.Army_DBEntities1DataModel;
using ArmyProject.PL.Common;
using ArmyProject;

namespace ArmyProject.PL.ViewModels {

    /// <summary>
    /// Represents the Students_TBL collection view model.
    /// </summary>
    public partial class Students_TBLCollectionViewModel : CollectionViewModel<Students_TBL, int, IArmy_DBEntities1UnitOfWork> {

        /// <summary>
        /// Creates a new instance of Students_TBLCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Students_TBLCollectionViewModel Create(IUnitOfWorkFactory<IArmy_DBEntities1UnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Students_TBLCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Students_TBLCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Students_TBLCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Students_TBLCollectionViewModel(IUnitOfWorkFactory<IArmy_DBEntities1UnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Students_TBL) {
        }
    }
}