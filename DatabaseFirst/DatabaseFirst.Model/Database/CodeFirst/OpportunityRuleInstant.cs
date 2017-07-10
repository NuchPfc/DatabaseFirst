namespace DatabaseFirst.Model.Database.CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OpportunityRuleInstant")]
    public partial class OpportunityRuleInstant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OpportunityRuleInstant()
        {
            RuleInstantLogs = new HashSet<RuleInstantLog>();
        }

        public Guid OpportunityRuleInstantId { get; set; }

        public Guid OpportunityId { get; set; }

        public Guid BizRuleId { get; set; }

        [StringLength(500)]
        public string Result { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime LastModifiedOn { get; set; }

        public int Status { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public virtual BizRule BizRule { get; set; }

        public virtual Opportunity Opportunity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RuleInstantLog> RuleInstantLogs { get; set; }
    }
}
