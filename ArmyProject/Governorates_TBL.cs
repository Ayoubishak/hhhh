//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArmyProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Governorates_TBL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Governorates_TBL()
        {
            this.Students_TBL = new HashSet<Students_TBL>();
        }
    
        public int Id { get; set; }
        public string GovName { get; set; }
        public string Description { get; set; }
        public Nullable<int> ArrivalStations_Id { get; set; }
    
        public virtual ArrivalStations_TBL ArrivalStations_TBL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Students_TBL> Students_TBL { get; set; }
    }
}
