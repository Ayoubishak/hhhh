using ArmyProject;
using DevExpress.Mvvm.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArmyProject.PL.FRM_Holiday_FULL_Crud.Army_DBEntitiesDataModel {

    /// <summary>
    /// IArmy_DBEntitiesUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IArmy_DBEntitiesUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The History_TBL entities repository.
        /// </summary>
		IRepository<History_TBL, int> History_TBL { get; }
        
        /// <summary>
        /// The Student_Sanctions_TBL entities repository.
        /// </summary>
		IRepository<Student_Sanctions_TBL, int> Student_Sanctions_TBL { get; }
        
        /// <summary>
        /// The Students_TBL entities repository.
        /// </summary>
		IRepository<Students_TBL, int> Students_TBL { get; }
        
        /// <summary>
        /// The sysdiagram entities repository.
        /// </summary>
		IRepository<sysdiagram, int> sysdiagrams { get; }
        
        /// <summary>
        /// The Users_TBL entities repository.
        /// </summary>
		IRepository<Users_TBL, int> Users_TBL { get; }
        
        /// <summary>
        /// The Degree_TBL entities repository.
        /// </summary>
		IRepository<Degree_TBL, string> Degree_TBL { get; }
        
        /// <summary>
        /// The Governorates_TBL entities repository.
        /// </summary>
		IRepository<Governorates_TBL, string> Governorates_TBL { get; }
        
        /// <summary>
        /// The RecruitingArea_TBL entities repository.
        /// </summary>
		IRepository<RecruitingArea_TBL, string> RecruitingArea_TBL { get; }
        
        /// <summary>
        /// The ArrivalStations_TBL entities repository.
        /// </summary>
		IRepository<ArrivalStations_TBL, int> ArrivalStations_TBL { get; }
        
        /// <summary>
        /// The Sanctions_TBL entities repository.
        /// </summary>
		IRepository<Sanctions_TBL, int> Sanctions_TBL { get; }
        
        /// <summary>
        /// The Transport_TBL entities repository.
        /// </summary>
		IRepository<Transport_TBL, int> Transport_TBL { get; }
    }
}
