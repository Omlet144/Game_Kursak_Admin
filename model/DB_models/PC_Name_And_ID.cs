namespace Game_Kursak_Admin
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PC_Name_And_ID
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PC_Name_And_ID()
        {
            Player_statistics = new HashSet<Player_statistics>();
        }

        public int Id { get; set; }

        public string Name_PC { get; set; }

        public string Id_PC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Player_statistics> Player_statistics { get; set; }
    }
}
