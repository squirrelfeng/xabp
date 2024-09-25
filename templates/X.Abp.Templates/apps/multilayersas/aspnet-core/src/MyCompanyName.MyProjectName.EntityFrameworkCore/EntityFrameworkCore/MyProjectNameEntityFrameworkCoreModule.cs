﻿using Microsoft.Extensions.DependencyInjection;

using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.BlobStoring.Database.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
#if MySQL
using Volo.Abp.EntityFrameworkCore.MySQL;
#elif SQLServer
using Volo.Abp.EntityFrameworkCore.SqlServer;
#elif SQLite
using Volo.Abp.EntityFrameworkCore.Sqlite;
#elif Oracle
using Volo.Abp.EntityFrameworkCore.Oracle;
#elif OracleDevart
using Volo.Abp.EntityFrameworkCore.Oracle.Devart;
#else
using Volo.Abp.EntityFrameworkCore.PostgreSql;
#endif
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.Uow;

using X.Abp.FileManagement.EntityFrameworkCore;
using X.Abp.Gdpr;
using X.Abp.Identity.EntityFrameworkCore;
#if IdentityServer4
using X.Abp.IdentityServer.EntityFrameworkCore;
#else
using X.Abp.OpenIddict.EntityFrameworkCore;
#endif
using X.Abp.LanguageManagement.EntityFrameworkCore;
using X.Abp.Saas.EntityFrameworkCore;
using X.Abp.TextTemplateManagement.EntityFrameworkCore;

namespace MyCompanyName.MyProjectName.EntityFrameworkCore;

[DependsOn(
    typeof(MyProjectNameDomainModule),
    typeof(AbpPermissionManagementEntityFrameworkCoreModule),
    typeof(AbpSettingManagementEntityFrameworkCoreModule),
#if MySQL
    typeof(AbpEntityFrameworkCoreMySQLModule),
#elif SQLServer
    typeof(AbpEntityFrameworkCoreSqlServerModule),
#elif SQLite
    typeof(AbpEntityFrameworkCoreSqliteModule),
#elif Oracle
    typeof(AbpEntityFrameworkCoreOracleModule),
#elif OracleDevart
    typeof(AbpEntityFrameworkCoreOracleDevartModule),
#else
    typeof(AbpEntityFrameworkCorePostgreSqlModule),
#endif
    typeof(AbpBackgroundJobsEntityFrameworkCoreModule),
    typeof(BlobStoringDatabaseEntityFrameworkCoreModule),
    typeof(AbpAuditLoggingEntityFrameworkCoreModule),
    typeof(AbpFeatureManagementEntityFrameworkCoreModule),
    typeof(AbpIdentityProEntityFrameworkCoreModule),
#if IdentityServer4
    typeof(AbpIdentityServerProEntityFrameworkCoreModule),
#else
    typeof(AbpOpenIddictProEntityFrameworkCoreModule),
#endif
    typeof(AbpLanguageManagementEntityFrameworkCoreModule),
    typeof(AbpFileManagementEntityFrameworkCoreModule),
    typeof(AbpSaasEntityFrameworkCoreModule),
    typeof(AbpTextTemplateManagementEntityFrameworkCoreModule),
    typeof(AbpGdprEntityFrameworkCoreModule))]
public class MyProjectNameEntityFrameworkCoreModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
#if PostgreSql
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
#endif
        MyProjectNameEfCoreEntityExtensionMappings.Configure();
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<MyProjectNameDbContext>(options =>
        {
            /* Remove "includeAllEntities: true" to create
             * default repositories only for aggregate roots */
            options.AddDefaultRepositories(includeAllEntities: true);
        });

        Configure<AbpDbContextOptions>(options =>
        {
            /* The main point to change your DBMS.
             * See also MyProjectNameMigrationsDbContextFactory for EF Core tooling. */
#if MySQL
            options.UseMySQL();
#elif SQLServer
            options.UseSqlServer();
#elif SQLite
            options.UseSqlite();
#elif Oracle
            options.UseOracle();
#elif OracleDevart
            options.UseOracle();
#else
            options.UseNpgsql();
#endif
        });

#if SQLite
        Configure<AbpUnitOfWorkDefaultOptions>(options =>
        {
            options.TransactionBehavior = UnitOfWorkTransactionBehavior.Disabled;
        });
#endif
    }
}