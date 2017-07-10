namespace DatabaseFirst.Model.Database.CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MasterSLA")]
    public partial class MasterSLA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MasterSLA()
        {
            OpportunitySLAs = new HashSet<OpportunitySLA>();
        }

        public Guid MasterSLAId { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Type { get; set; }

        [StringLength(200)]
        public string SubType { get; set; }

        public int Status { get; set; }

        public int Days { get; set; }

        [StringLength(200)]
        public string StartDateName { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime LastModifiedOn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpportunitySLA> OpportunitySLAs { get; set; }
    }
}
