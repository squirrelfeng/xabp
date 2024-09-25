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
using X.Abp.Quartz.Schedulers;
using X.Abp.Quartz.Schedulers.Dtos;

// ReSharper disable once CheckNamespace
namespace X.Abp.Quartz;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(ISchedulerAppService), typeof(SchedulerClientProxy))]
public partial class SchedulerClientProxy : ClientProxyBase<ISchedulerAppService>, ISchedulerAppService
{
    public virtual async Task<PagedResultDto<SchedulerHeaderDto>> GetListAsync(GetSchedulerListInput input)
    {
        return await RequestAsync<PagedResultDto<SchedulerHeaderDto>>(nameof(GetListAsync), new ClientProxyRequestTypeValue
        {
            { typeof(GetSchedulerListInput), input }
        });
    }

    public virtual async Task<SchedulerDto> GetAsync(string schedulerName)
    {
        return await RequestAsync<SchedulerDto>(nameof(GetAsync), new ClientProxyRequestTypeValue
        {
            { typeof(string), schedulerName }
        });
    }

    public virtual async Task StartAsync(string schedulerName, int? delayMilliseconds)
    {
        await RequestAsync(nameof(StartAsync), new ClientProxyRequestTypeValue
        {
            { typeof(string), schedulerName },
            { typeof(int?), delayMilliseconds }
        });
    }

    public virtual async Task StandbyAsync(string schedulerName)
    {
        await RequestAsync(nameof(StandbyAsync), new ClientProxyRequestTypeValue
        {
            { typeof(string), schedulerName }
        });
    }

    public virtual async Task ShutdownAsync(string schedulerName, bool waitForJobsToComplete)
    {
        await RequestAsync(nameof(ShutdownAsync), new ClientProxyRequestTypeValue
        {
            { typeof(string), schedulerName },
            { typeof(bool), waitForJobsToComplete }
        });
    }

    public virtual async Task ClearAsync(string schedulerName)
    {
        await RequestAsync(nameof(ClearAsync), new ClientProxyRequestTypeValue
        {
            { typeof(string), schedulerName }
        });
    }
}