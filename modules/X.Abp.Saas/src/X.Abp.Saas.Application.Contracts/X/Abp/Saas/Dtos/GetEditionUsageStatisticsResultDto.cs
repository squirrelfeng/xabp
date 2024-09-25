﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using System.Collections.Generic;

namespace X.Abp.Saas.Dtos;

public class GetEditionUsageStatisticsResultDto
{
    public Dictionary<string, int> Data { get; set; }
}