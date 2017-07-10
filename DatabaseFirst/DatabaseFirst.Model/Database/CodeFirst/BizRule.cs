namespace DatabaseFirst.Model.Database.CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BizRule")]
    public partial class BizRule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BizRule()
        {
            OpportunityRuleInstants = new HashSet<OpportunityRuleInstant>();
            RuleBranches = new HashSet<RuleBranch>();
        }

        public Guid BizRuleId { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(200)]
        public string Type { get; set; }

        [StringLength(200)]
        public string SubType { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime LastModifiedOn { get; set; }

        public int Status { get; set; }

        [StringLength(200)]
        public string StoredProc { get; set; }

        [StringLength(200)]
        public string ConnentionStr { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpportunityRuleInstant> OpportunityRuleInstants { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RuleBranch> RuleBranches { get; set; }
    }
}
