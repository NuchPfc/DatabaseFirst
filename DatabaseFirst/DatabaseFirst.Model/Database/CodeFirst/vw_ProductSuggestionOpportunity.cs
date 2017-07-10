namespace DatabaseFirst.Model.Database.CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_ProductSuggestionOpportunity
    {
        [StringLength(100)]
        public string pfc_location_province { get; set; }

        [StringLength(100)]
        public string pfc_location_district { get; set; }

        [StringLength(500)]
        public string pfc_location_detail { get; set; }

        [Column(TypeName = "money")]
        public decimal? pfc_LBBudget { get; set; }

        [Column(TypeName = "money")]
        public decimal? pfc_UBBudget { get; set; }

        [StringLength(100)]
        public string pfc_name { get; set; }

        [Key]
        public Guid OpportunityId { get; set; }

        public Guid? pfc_location_zone { get; set; }
    }
}
