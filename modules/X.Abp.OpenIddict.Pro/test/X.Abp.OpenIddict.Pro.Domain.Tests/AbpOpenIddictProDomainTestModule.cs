﻿using Volo.Abp.Modularity;

using X.Abp.OpenIddict.EntityFrameworkCore;

namespace X.Abp.OpenIddict;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(AbpOpenIddictProEntityFrameworkCoreTestModule),
    typeof(AbpOpenIddictProTestBaseModule)
    )]
public class AbpOpenIddictProDomainTestModule : AbpModule
{

}
