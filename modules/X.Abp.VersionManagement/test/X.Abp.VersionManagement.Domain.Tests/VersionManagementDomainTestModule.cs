﻿using Volo.Abp.Modularity;

namespace X.Abp.VersionManagement;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(AbpVersionManagementDomainModule),
    typeof(VersionManagementTestBaseModule)
    )]
public class VersionManagementDomainTestModule : AbpModule
{

}
