﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using System;

namespace X.Abp.Quartz.Dtos;

public class TimeZoneDto
{
    public TimeZoneDto(TimeZoneInfo timeZone)
    {
        Id = timeZone.Id;
        StandardName = timeZone.StandardName;
        DisplayName = timeZone.DisplayName;
    }

    public string Id { get; }

    public string StandardName { get; }

    public string DisplayName { get; }
}