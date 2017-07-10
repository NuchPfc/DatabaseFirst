namespace DatabaseFirst.Model.Database.CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RuleBranch")]
    public partial class RuleBranch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RuleBranch()
        {
            RuleActions = new HashSet<RuleAction>();
        }

        public Guid RuleBranchId { get; set; }

        public Guid BizRuleId { get; set; }

        public int BranchNo { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime LastModifiedOn { get; set; }

        public int Status { get; set; }

        public virtual BizRule BizRule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RuleAction> RuleActions { get; set; }
    }
}
