namespace DatabaseFirst.Model.Database.CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RuleInstantLog")]
    public partial class RuleInstantLog
    {
        public Guid RuleInstantLogId { get; set; }

        public Guid OpportunityRuleInstantId { get; set; }

        public int RuleBranchNo { get; set; }

        [StringLength(500)]
        public string Reason { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime LastModifiedOn { get; set; }

        public int Status { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public virtual OpportunityRuleInstant OpportunityRuleInstant { get; set; }
    }
}
