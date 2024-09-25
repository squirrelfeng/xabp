﻿// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Abp.Http.Modeling;
using X.Abp.Forms.Forms;
using X.Abp.Forms.Questions;
using X.Abp.Forms.Responses;

// ReSharper disable once CheckNamespace
namespace X.Abp.Forms.Responses;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IResponseAppService), typeof(ResponseClientProxy))]
public partial class ResponseClientProxy : ClientProxyBase<IResponseAppService>, IResponseAppService
{
    public virtual async Task<FormResponseDto> GetAsync(Guid id)
    {
        return await RequestAsync<FormResponseDto>(nameof(GetAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }

    public virtual async Task<PagedResultDto<FormResponseDto>> GetListAsync(GetUserFormListInputDto input)
    {
        return await RequestAsync<PagedResultDto<FormResponseDto>>(nameof(GetListAsync), new ClientProxyRequestTypeValue
        {
            { typeof(GetUserFormListInputDto), input }
        });
    }

    public virtual async Task<List<QuestionWithAnswersDto>> GetQuestionsWithAnswersAsync(Guid id)
    {
        return await RequestAsync<List<QuestionWithAnswersDto>>(nameof(GetQuestionsWithAnswersAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }

    public virtual async Task<FormDto> GetFormDetailsAsync(Guid formId)
    {
        return await RequestAsync<FormDto>(nameof(GetFormDetailsAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), formId }
        });
    }

    public virtual async Task<PagedResultDto<FormWithResponseDto>> GetUserFormsByUserIdAsync(Guid userId)
    {
        return await RequestAsync<PagedResultDto<FormWithResponseDto>>(nameof(GetUserFormsByUserIdAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), userId }
        });
    }

    public virtual async Task<FormResponseDto> SaveAnswersAsync(Guid formId, CreateResponseDto input)
    {
        return await RequestAsync<FormResponseDto>(nameof(SaveAnswersAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), formId },
            { typeof(CreateResponseDto), input }
        });
    }

    public virtual async Task<FormResponseDto> UpdateAnswersAsync(Guid id, UpdateResponseDto input)
    {
        return await RequestAsync<FormResponseDto>(nameof(UpdateAnswersAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id },
            { typeof(UpdateResponseDto), input }
        });
    }

    public virtual async Task DeleteAsync(Guid id)
    {
        await RequestAsync(nameof(DeleteAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }
}