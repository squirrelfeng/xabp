﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Volo.Abp.Application.Services;

using X.Abp.IdentityServer.ApiScope.Dtos;

namespace X.Abp.IdentityServer.ApiScope;

public interface IApiScopeAppService : ICrudAppService<ApiScopeWithDetailsDto, Guid, GetApiScopeListInput, CreateApiScopeDto, UpdateApiScopeDto>
{
    Task<List<ApiScopeWithDetailsDto>> GetAllListAsync();
}