using Inva.LawMax.Entity;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Inva.LawMax.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class LawMaxDbContext :
    AbpDbContext<LawMaxDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    public DbSet<Case> Cases { get; set; }
    public DbSet<Hearing> Hearings { get; set; }
    public DbSet<Lawyer> Lawyers { get; set; }
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }
    public DbSet<IdentityUserDelegation> UserDelegations { get; set; }
    public DbSet<IdentitySession> Sessions { get; set; }
    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion

    public LawMaxDbContext(DbContextOptions<LawMaxDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Case>(b =>
        {
            b.ToTable("Cases");
            b.HasKey(x => x.Id);
            b.Property(x => x.Number).IsRequired();
            b.Property(x => x.Year).IsRequired();
            b.Property(x => x.LitigationDegree).IsRequired();
            b.Property(x => x.FinalVerdict).IsRequired();
            b.HasMany(x => x.Hearings)
                .WithOne(x => x.Case)
                .HasForeignKey(x => x.CaseId);
            b.HasOne(x => x.Lawyer)
               .WithMany(x => x.Cases)
              .HasForeignKey(x => x.LawyerId);

        });

        builder.Entity<Hearing>(b =>
        {
            b.ToTable("Hearings");
            b.HasKey(x => x.Id);
            b.Property(x => x.Date).IsRequired();
            b.Property(x => x.Decision).IsRequired();
        });

        builder.Entity<Lawyer>(b =>
        {
            b.ToTable("Lawyers");
            b.HasKey(x => x.Id);
            b.Property(x => x.Name).IsRequired();
            b.Property(x => x.Position).IsRequired();
            b.Property(x => x.Mobile).IsRequired();
            b.Property(x => x.Address).IsRequired();
            b.HasMany(x => x.Cases)
                     .WithOne(x => x.Lawyer)
                     .HasForeignKey(x => x.LawyerId);
        });

        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own tables/entities inside here */

        //builder.Entity<YourEntity>(b =>
        //{
        //    b.ToTable(LawMaxConsts.DbTablePrefix + "YourEntities", LawMaxConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        //});
    }
}
