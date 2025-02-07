﻿using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace X.Abp.FileManagement;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpFileManagementHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class FileManagementConsoleApiClientModule : AbpModule
{

}
