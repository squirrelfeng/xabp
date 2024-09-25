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
using X.Abp.Payment.Admin.Plans;
using X.Abp.Payment.Plans;

// ReSharper disable once CheckNamespace
namespace X.Abp.Payment.Admin.Plans;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IPlanAdminAppService), typeof(PlanAdminClientProxy))]
public partial class PlanAdminClientProxy : ClientProxyBase<IPlanAdminAppService>, IPlanAdminAppService
{
    public virtual async Task<PlanDto> CreateAsync(PlanCreateInput input)
    {
        return await RequestAsync<PlanDto>(nameof(CreateAsync), new ClientProxyRequestTypeValue
        {
            { typeof(PlanCreateInput), input }
        });
    }

    public virtual async Task CreateGatewayPlanAsync(Guid planId, GatewayPlanCreateInput input)
    {
        await RequestAsync(nameof(CreateGatewayPlanAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), planId },
            { typeof(GatewayPlanCreateInput), input }
        });
    }

    public virtual async Task DeleteAsync(Guid id)
    {
        await RequestAsync(nameof(DeleteAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }

    public virtual async Task DeleteGatewayPlanAsync(Guid planId, string gateway)
    {
        await RequestAsync(nameof(DeleteGatewayPlanAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), planId },
            { typeof(string), gateway }
        });
    }

    public virtual async Task<PlanDto> GetAsync(Guid id)
    {
        return await RequestAsync<PlanDto>(nameof(GetAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }

    public virtual async Task<PagedResultDto<PlanDto>> GetListAsync(PlanGetListInput input)
    {
        return await RequestAsync<PagedResultDto<PlanDto>>(nameof(GetListAsync), new ClientProxyRequestTypeValue
        {
            { typeof(PlanGetListInput), input }
        });
    }

    public virtual async Task<PlanDto> UpdateAsync(Guid id, PlanUpdateInput input)
    {
        return await RequestAsync<PlanDto>(nameof(UpdateAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id },
            { typeof(PlanUpdateInput), input }
        });
    }

    public virtual async Task UpdateGatewayPlanAsync(Guid planId, string gateway, GatewayPlanUpdateInput input)
    {
        await RequestAsync(nameof(UpdateGatewayPlanAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), planId },
            { typeof(string), gateway },
            { typeof(GatewayPlanUpdateInput), input }
        });
    }

    public virtual async Task<PagedResultDto<GatewayPlanDto>> GetGatewayPlansAsync(Guid planId, GatewayPlanGetListInput input)
    {
        return await RequestAsync<PagedResultDto<GatewayPlanDto>>(nameof(GetGatewayPlansAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), planId },
            { typeof(GatewayPlanGetListInput), input }
        });
    }
}