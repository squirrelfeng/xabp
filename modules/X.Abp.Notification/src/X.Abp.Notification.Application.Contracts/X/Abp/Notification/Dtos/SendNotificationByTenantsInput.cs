﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using System;

namespace X.Abp.Notification.Dtos;
public class SendNotificationByTenantsInput
{
    public string NotificationName { get; set; }

    public NotificationData Data { get; set; }

    public NotificationSeverity Severity { get; set; }

    public Guid?[] TenantIds { get; set; }

    public string[] TargetNotifiers { get; set; }
}