﻿using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace X.Abp.Payment;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PaymentHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class PaymentConsoleApiClientModule : AbpModule
{

}