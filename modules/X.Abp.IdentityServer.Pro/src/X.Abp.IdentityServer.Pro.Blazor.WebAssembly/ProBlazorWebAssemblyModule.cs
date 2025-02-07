﻿using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace X.Abp.IdentityServer.Blazor.WebAssembly;

[DependsOn(
    typeof(ProBlazorModule),
    typeof(AbpIdentityServerProHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class ProBlazorWebAssemblyModule : AbpModule
{

}
