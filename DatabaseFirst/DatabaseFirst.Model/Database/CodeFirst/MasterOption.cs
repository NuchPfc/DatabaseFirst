namespace DatabaseFirst.Model.Database.CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MasterOption
    {
        [Key]
        public Guid OptionId { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public int Value { get; set; }

        [StringLength(500)]
        public string Text { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(200)]
        public string TableName { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime LastModifiedOn { get; set; }

        public int Status { get; set; }
    }
}
