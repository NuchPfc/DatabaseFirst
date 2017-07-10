namespace DatabaseFirst.Model.Database.CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BizMonSystemLog")]
    public partial class BizMonSystemLog
    {
        [Key]
        public Guid LogId { get; set; }

        [StringLength(200)]
        public string Source { get; set; }

        [StringLength(200)]
        public string Event { get; set; }

        [StringLength(500)]
        public string Trace { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime LastModifiedOn { get; set; }

        public int Status { get; set; }

        [StringLength(200)]
        public string Name { get; set; }
    }
}
