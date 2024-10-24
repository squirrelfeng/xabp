﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using Volo.Abp.Data;
using Volo.Abp.Modularity;

using X.Abp.Identity.MongoDB;

namespace X.Abp.OpenIddict.MongoDB;

[DependsOn(
    typeof(AbpOpenIddictProTestBaseModule),
    typeof(AbpIdentityProMongoDbModule),
    typeof(AbpOpenIddictProMongoDbModule))]
public class AbpOpenIddictProMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = MongoDbFixture.GetRandomConnectionString();
        });
    }
}
