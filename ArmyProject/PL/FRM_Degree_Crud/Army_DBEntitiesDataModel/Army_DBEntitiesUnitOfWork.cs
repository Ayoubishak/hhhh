using ArmyProject;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArmyProject.PL.FRM_Degree_Crud.Army_DBEntitiesDataModel {

    /// <summary>
    /// A Army_DBEntitiesUnitOfWork instance that represents the run-time implementation of the IArmy_DBEntitiesUnitOfWork interface.
    /// </summary>
    public class Army_DBEntitiesUnitOfWork : DbUnitOfWork<Army_DBEntities>, IArmy_DBEntitiesUnitOfWork {

        public Army_DBEntitiesUnitOfWork(Func<Army_DBEntities> contextFactory)
            : base(contextFactory) {
        }

        IRepository<History_TBL, int> IArmy_DBEntitiesUnitOfWork.History_TBL {
            get { return GetRepository(x => x.Set<History_TBL>(), (History_TBL x) => x.Id); }
        }

        IRepository<Student_Sanctions_TBL, int> IArmy_DBEntitiesUnitOfWork.Student_Sanctions_TBL {
            get { return GetRepository(x => x.Set<Student_Sanctions_TBL>(), (Student_Sanctions_TBL x) => x.Id); }
        }

        IRepository<Students_TBL, int> IArmy_DBEntitiesUnitOfWork.Students_TBL {
            get { return GetRepository(x => x.Set<Students_TBL>(), (Students_TBL x) => x.Id); }
        }

        IRepository<sysdiagram, int> IArmy_DBEntitiesUnitOfWork.sysdiagrams {
            get { return GetRepository(x => x.Set<sysdiagram>(), (sysdiagram x) => x.diagram_id); }
        }

        IRepository<Users_TBL, int> IArmy_DBEntitiesUnitOfWork.Users_TBL {
            get { return GetRepository(x => x.Set<Users_TBL>(), (Users_TBL x) => x.Id); }
        }

        IRepository<Degree_TBL, string> IArmy_DBEntitiesUnitOfWork.Degree_TBL {
            get { return GetRepository(x => x.Set<Degree_TBL>(), (Degree_TBL x) => x.DegName); }
        }

        IRepository<Governorates_TBL, string> IArmy_DBEntitiesUnitOfWork.Governorates_TBL {
            get { return GetRepository(x => x.Set<Governorates_TBL>(), (Governorates_TBL x) => x.GovName); }
        }

        IRepository<RecruitingArea_TBL, string> IArmy_DBEntitiesUnitOfWork.RecruitingArea_TBL {
            get { return GetRepository(x => x.Set<RecruitingArea_TBL>(), (RecruitingArea_TBL x) => x.RecName); }
        }

        IRepository<ArrivalStations_TBL, int> IArmy_DBEntitiesUnitOfWork.ArrivalStations_TBL {
            get { return GetRepository(x => x.Set<ArrivalStations_TBL>(), (ArrivalStations_TBL x) => x.Id); }
        }

        IRepository<Sanctions_TBL, int> IArmy_DBEntitiesUnitOfWork.Sanctions_TBL {
            get { return GetRepository(x => x.Set<Sanctions_TBL>(), (Sanctions_TBL x) => x.Id); }
        }

        IRepository<Transport_TBL, int> IArmy_DBEntitiesUnitOfWork.Transport_TBL {
            get { return GetRepository(x => x.Set<Transport_TBL>(), (Transport_TBL x) => x.Id); }
        }
    }
}
