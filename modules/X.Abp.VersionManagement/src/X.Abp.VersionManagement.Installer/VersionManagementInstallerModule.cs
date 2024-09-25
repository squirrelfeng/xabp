﻿using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace X.Abp.VersionManagement;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class VersionManagementInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<VersionManagementInstallerModule>();
        });
    }
}