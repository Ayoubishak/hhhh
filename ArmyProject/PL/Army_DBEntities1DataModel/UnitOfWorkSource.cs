using ArmyProject;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using DevExpress.Mvvm.DataModel.EF6;
using System;
using System.Collections;
using System.Linq;

namespace ArmyProject.PL.Army_DBEntities1DataModel {

    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {

		/// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IArmy_DBEntities1UnitOfWork> GetUnitOfWorkFactory() {
            return new DbUnitOfWorkFactory<IArmy_DBEntities1UnitOfWork>(() => new Army_DBEntities1UnitOfWork(() => new Army_DBEntities1()));
        }
    }
}