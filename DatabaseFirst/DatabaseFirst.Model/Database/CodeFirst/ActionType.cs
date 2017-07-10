namespace DatabaseFirst.Model.Database.CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActionType")]
    public partial class ActionType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ActionType()
        {
            RuleActions = new HashSet<RuleAction>();
        }

        public Guid ActionTypeId { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(500)]
        public string HandlerClass { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime LastModifiedOn { get; set; }

        public int Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RuleAction> RuleActions { get; set; }
    }
}
