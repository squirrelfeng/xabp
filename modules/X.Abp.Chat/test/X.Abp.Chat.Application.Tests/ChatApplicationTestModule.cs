﻿using Volo.Abp.Modularity;

namespace X.Abp.Chat;

[DependsOn(
    typeof(ChatApplicationModule),
    typeof(ChatDomainTestModule)
    )]
public class ChatApplicationTestModule : AbpModule
{

}