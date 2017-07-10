namespace DatabaseFirst.Model.Database.CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OpportunitySLA")]
    public partial class OpportunitySLA
    {
        public Guid OpportunitySLAId { get; set; }

        public Guid OpportunityId { get; set; }

        public Guid MasterSLAId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Remains { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime LastModifiedOn { get; set; }

        public int Status { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public virtual MasterSLA MasterSLA { get; set; }

        public virtual Opportunity Opportunity { get; set; }
    }
}
