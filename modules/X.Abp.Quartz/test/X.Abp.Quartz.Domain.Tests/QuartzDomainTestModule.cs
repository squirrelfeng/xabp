﻿using Volo.Abp.Modularity;

namespace X.Abp.Quartz;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(AbpQuartzDomainModule),
    typeof(QuartzTestBaseModule)
    )]
public class QuartzDomainTestModule : AbpModule
{

}
