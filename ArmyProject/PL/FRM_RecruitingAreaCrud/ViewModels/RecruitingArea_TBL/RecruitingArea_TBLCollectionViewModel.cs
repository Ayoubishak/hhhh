using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using ArmyProject.PL.FRM_RecruitingAreaCrud.Army_DBEntitiesDataModel;
using ArmyProject.PL.FRM_RecruitingAreaCrud.Common;
using ArmyProject;

namespace ArmyProject.PL.FRM_RecruitingAreaCrud.ViewModels {

    /// <summary>
    /// Represents the RecruitingArea_TBL collection view model.
    /// </summary>
    public partial class RecruitingArea_TBLCollectionViewModel : CollectionViewModel<RecruitingArea_TBL, string, IArmy_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of RecruitingArea_TBLCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static RecruitingArea_TBLCollectionViewModel Create(IUnitOfWorkFactory<IArmy_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new RecruitingArea_TBLCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the RecruitingArea_TBLCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the RecruitingArea_TBLCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected RecruitingArea_TBLCollectionViewModel(IUnitOfWorkFactory<IArmy_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.RecruitingArea_TBL) {
        }
    }
}