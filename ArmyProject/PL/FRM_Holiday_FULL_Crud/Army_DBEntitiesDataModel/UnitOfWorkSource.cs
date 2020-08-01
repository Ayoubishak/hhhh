using ArmyProject;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using DevExpress.Mvvm.DataModel.EF6;
using System;
using System.Collections;
using System.Linq;

namespace ArmyProject.PL.FRM_Holiday_FULL_Crud.Army_DBEntitiesDataModel {

    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {

		/// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IArmy_DBEntitiesUnitOfWork> GetUnitOfWorkFactory() {
            return new DbUnitOfWorkFactory<IArmy_DBEntitiesUnitOfWork>(() => new Army_DBEntitiesUnitOfWork(() => new Army_DBEntities()));
        }
    }
}