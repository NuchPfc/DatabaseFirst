namespace DatabaseFirst.Model.Database.CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RuleAction")]
    public partial class RuleAction
    {
        public Guid RuleActionId { get; set; }

        public Guid RuleBranchId { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public int Order { get; set; }

        [StringLength(200)]
        public string WebAPIEndpoint { get; set; }

        public Guid ActionTypeId { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime LastModifiedOn { get; set; }

        public int Status { get; set; }

        [StringLength(200)]
        public string NextRule { get; set; }

        public bool? RunNextRuleImmediately { get; set; }

        [StringLength(200)]
        public string WebAPIBaseURL { get; set; }

        public virtual ActionType ActionType { get; set; }

        public virtual RuleBranch RuleBranch { get; set; }
    }
}
