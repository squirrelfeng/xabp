// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Content;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Abp.Http.Modeling;
using X.Abp.CmsKit.Admin.Newsletters;

// ReSharper disable once CheckNamespace
namespace X.Abp.CmsKit.Admin.Newsletters;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(INewsletterRecordAdminAppService), typeof(NewsletterRecordAdminClientProxy))]
public partial class NewsletterRecordAdminClientProxy : ClientProxyBase<INewsletterRecordAdminAppService>, INewsletterRecordAdminAppService
{
    public virtual async Task<PagedResultDto<NewsletterRecordDto>> GetListAsync(GetNewsletterRecordsRequestInput input)
    {
        return await RequestAsync<PagedResultDto<NewsletterRecordDto>>(nameof(GetListAsync), new ClientProxyRequestTypeValue
        {
            { typeof(GetNewsletterRecordsRequestInput), input }
        });
    }

    public virtual async Task<NewsletterRecordWithDetailsDto> GetAsync(Guid id)
    {
        return await RequestAsync<NewsletterRecordWithDetailsDto>(nameof(GetAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }

    public virtual async Task<List<NewsletterRecordCsvDto>> GetNewsletterRecordsCsvDetailAsync(GetNewsletterRecordsCsvRequestInput input)
    {
        return await RequestAsync<List<NewsletterRecordCsvDto>>(nameof(GetNewsletterRecordsCsvDetailAsync), new ClientProxyRequestTypeValue
        {
            { typeof(GetNewsletterRecordsCsvRequestInput), input }
        });
    }

    public virtual async Task<List<String>> GetNewsletterPreferencesAsync()
    {
        return await RequestAsync<List<String>>(nameof(GetNewsletterPreferencesAsync));
    }

    public virtual async Task<IRemoteStreamContent> GetCsvResponsesAsync(GetNewsletterRecordsCsvRequestInput input)
    {
        return await RequestAsync<IRemoteStreamContent>(nameof(GetCsvResponsesAsync), new ClientProxyRequestTypeValue
        {
            { typeof(GetNewsletterRecordsCsvRequestInput), input }
        });
    }
}