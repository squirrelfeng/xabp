﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using Volo.Abp;

using X.Abp.Chat.Messages;

namespace X.Abp.Chat.Conversations;

[RemoteService(Name = AbpChatRemoteServiceConsts.RemoteServiceName)]
[Area(AbpChatRemoteServiceConsts.ModuleName)]
[Route("api/chat/conversation")]
public class ConversationController : ChatController, IConversationAppService
{
    protected IConversationAppService ConversationAppService { get; }

    public ConversationController(IConversationAppService conversationAppService)
    {
        ConversationAppService = conversationAppService;
    }

    [HttpPost]
    [Route("send-message")]
    public Task SendMessageAsync(SendMessageInput input)
    {
        return ConversationAppService.SendMessageAsync(input);
    }

    [HttpGet]
    [Route("conversation")]
    public Task<ChatConversationDto> GetConversationAsync(GetConversationInput input)
    {
        return ConversationAppService.GetConversationAsync(input);
    }

    [HttpPost]
    [Route("mark-conversation-as-read")]
    public Task MarkConversationAsReadAsync(MarkConversationAsReadInput input)
    {
        return ConversationAppService.MarkConversationAsReadAsync(input);
    }
}