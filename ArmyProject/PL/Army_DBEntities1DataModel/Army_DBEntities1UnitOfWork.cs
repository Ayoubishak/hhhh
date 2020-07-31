using ArmyProject;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArmyProject.PL.Army_DBEntities1DataModel {

    /// <summary>
    /// A Army_DBEntities1UnitOfWork instance that represents the run-time implementation of the IArmy_DBEntities1UnitOfWork interface.
    /// </summary>
    public class Army_DBEntities1UnitOfWork : DbUnitOfWork<Army_DBEntities1>, IArmy_DBEntities1UnitOfWork {

        public Army_DBEntities1UnitOfWork(Func<Army_DBEntities1> contextFactory)
            : base(contextFactory) {
        }

        IRepository<ArrivalStations_TBL, int> IArmy_DBEntities1UnitOfWork.ArrivalStations_TBL {
            get { return GetRepository(x => x.Set<ArrivalStations_TBL>(), (ArrivalStations_TBL x) => x.Id); }
        }

        IRepository<Degree_TBL, int> IArmy_DBEntities1UnitOfWork.Degree_TBL {
            get { return GetRepository(x => x.Set<Degree_TBL>(), (Degree_TBL x) => x.Id); }
        }

        IRepository<Governorates_TBL, int> IArmy_DBEntities1UnitOfWork.Governorates_TBL {
            get { return GetRepository(x => x.Set<Governorates_TBL>(), (Governorates_TBL x) => x.Id); }
        }

        IRepository<History_TBL, int> IArmy_DBEntities1UnitOfWork.History_TBL {
            get { return GetRepository(x => x.Set<History_TBL>(), (History_TBL x) => x.Id); }
        }

        IRepository<RecruitingArea_TBL, int> IArmy_DBEntities1UnitOfWork.RecruitingArea_TBL {
            get { return GetRepository(x => x.Set<RecruitingArea_TBL>(), (RecruitingArea_TBL x) => x.Id); }
        }

        IRepository<Sanctions_TBL, int> IArmy_DBEntities1UnitOfWork.Sanctions_TBL {
            get { return GetRepository(x => x.Set<Sanctions_TBL>(), (Sanctions_TBL x) => x.Id); }
        }

        IRepository<Student_Sanctions_TBL, int> IArmy_DBEntities1UnitOfWork.Student_Sanctions_TBL {
            get { return GetRepository(x => x.Set<Student_Sanctions_TBL>(), (Student_Sanctions_TBL x) => x.Id); }
        }

        IRepository<Students_TBL, int> IArmy_DBEntities1UnitOfWork.Students_TBL {
            get { return GetRepository(x => x.Set<Students_TBL>(), (Students_TBL x) => x.Id); }
        }

        IRepository<sysdiagram, int> IArmy_DBEntities1UnitOfWork.sysdiagrams {
            get { return GetRepository(x => x.Set<sysdiagram>(), (sysdiagram x) => x.diagram_id); }
        }

        IRepository<Transport_TBL, int> IArmy_DBEntities1UnitOfWork.Transport_TBL {
            get { return GetRepository(x => x.Set<Transport_TBL>(), (Transport_TBL x) => x.Id); }
        }

        IRepository<Users_TBL, int> IArmy_DBEntities1UnitOfWork.Users_TBL {
            get { return GetRepository(x => x.Set<Users_TBL>(), (Users_TBL x) => x.Id); }
        }
    }
}
