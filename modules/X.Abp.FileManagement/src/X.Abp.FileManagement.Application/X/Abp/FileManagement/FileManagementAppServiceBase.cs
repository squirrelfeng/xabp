﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using Volo.Abp.Application.Services;

using X.Abp.FileManagement.Localization;

namespace X.Abp.FileManagement;

public abstract class FileManagementAppServiceBase : ApplicationService
{
    protected FileManagementAppServiceBase()
    {
        LocalizationResource = typeof(FileManagementResource);
        ObjectMapperContext = typeof(AbpFileManagementApplicationModule);
    }
}