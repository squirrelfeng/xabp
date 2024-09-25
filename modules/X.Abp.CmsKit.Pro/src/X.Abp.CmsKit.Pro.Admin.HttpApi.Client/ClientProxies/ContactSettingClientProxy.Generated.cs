// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Abp.Http.Modeling;
using X.Abp.CmsKit.Admin.Contact;

// ReSharper disable once CheckNamespace
namespace X.Abp.CmsKit.Admin.Contact;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IContactSettingsAppService), typeof(ContactSettingClientProxy))]
public partial class ContactSettingClientProxy : ClientProxyBase<IContactSettingsAppService>, IContactSettingsAppService
{
    public virtual async Task<CmsKitContactSettingDto> GetAsync()
    {
        return await RequestAsync<CmsKitContactSettingDto>(nameof(GetAsync));
    }

    public virtual async Task UpdateAsync(UpdateCmsKitContactSettingDto input)
    {
        await RequestAsync(nameof(UpdateAsync), new ClientProxyRequestTypeValue
        {
            { typeof(UpdateCmsKitContactSettingDto), input }
        });
    }
}