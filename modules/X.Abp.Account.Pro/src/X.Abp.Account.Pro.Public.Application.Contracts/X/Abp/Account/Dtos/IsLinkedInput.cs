﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using System;

using Volo.Abp.MultiTenancy;

namespace X.Abp.Account.Dtos;

public class IsLinkedInput : IMultiTenant
{
    public Guid UserId { get; set; }

    public Guid? TenantId { get; set; }
}