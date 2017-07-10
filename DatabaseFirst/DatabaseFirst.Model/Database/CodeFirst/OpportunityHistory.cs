namespace DatabaseFirst.Model.Database.CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OpportunityHistory")]
    public partial class OpportunityHistory
    {
        public Guid OpportunityHistoryId { get; set; }

        public Guid OpportunityId { get; set; }

        [StringLength(200)]
        public string FieldName { get; set; }

        [StringLength(500)]
        public string OldValue { get; set; }

        [StringLength(500)]
        public string NewValue { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime LastModifiedOn { get; set; }

        public int Status { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public virtual Opportunity Opportunity { get; set; }
    }
}
