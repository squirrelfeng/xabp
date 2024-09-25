﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using Volo.Abp.Data;

namespace X.Abp.VersionManagement;

public static class VersionManagementDbProperties
{
    public static string DbTablePrefix { get; set; } = "Vm";

    public static string DbSchema { get; set; } = AbpCommonDbProperties.DbSchema;

    public const string ConnectionStringName = "VersionManagement";
}