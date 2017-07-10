namespace DatabaseFirst.Model.Database.CodeFirst
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PFCBizJobOperatorDB : DbContext
    {
        public PFCBizJobOperatorDB()
            : base("name=PFCBizJobOperatorDBDataModelCodeFirst")
        {
        }

        public virtual DbSet<ActionType> ActionTypes { get; set; }
        public virtual DbSet<BizMonSystemLog> BizMonSystemLogs { get; set; }
        public virtual DbSet<BizRule> BizRules { get; set; }
        public virtual DbSet<MasterOption> MasterOptions { get; set; }
        public virtual DbSet<MasterSLA> MasterSLAs { get; set; }
        public virtual DbSet<Opportunity> Opportunities { get; set; }
        public virtual DbSet<OpportunityHistory> OpportunityHistories { get; set; }
        public virtual DbSet<OpportunityRuleInstant> OpportunityRuleInstants { get; set; }
        public virtual DbSet<OpportunitySLA> OpportunitySLAs { get; set; }
        public virtual DbSet<RuleAction> RuleActions { get; set; }
        public virtual DbSet<RuleBranch> RuleBranches { get; set; }
        public virtual DbSet<RuleInstantLog> RuleInstantLogs { get; set; }
        public virtual DbSet<vw_ProductSuggestionOpportunity> vw_ProductSuggestionOpportunity { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<vw_ProductSuggestionOpportunity>()
                .Property(e => e.pfc_LBBudget)
                .HasPrecision(19, 4);

            modelBuilder.Entity<vw_ProductSuggestionOpportunity>()
                .Property(e => e.pfc_UBBudget)
                .HasPrecision(19, 4);
        }
    }
}
