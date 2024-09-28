﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using JetBrains.Annotations;

using Volo.Abp;
using Volo.Abp.DependencyInjection;

namespace X.Abp.Notification.RealTime
{
  public class OnlineClientManager<T> : OnlineClientManager, IOnlineClientManager<T>
  {
    public OnlineClientManager(IOnlineClientStore<T> store)
        : base(store)
    {
    }
  }
}
