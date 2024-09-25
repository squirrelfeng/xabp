﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using AutoMapper;

using Volo.Abp.AutoMapper;

using X.Abp.CmsKit.Newsletters;
using X.Abp.CmsKit.Polls;
using X.Abp.CmsKit.Public.Newsletters;
using X.Abp.CmsKit.Public.Polls;
using X.Abp.CmsKit.Public.UrlShorting;
using X.Abp.CmsKit.UrlShorting;

namespace X.Abp.CmsKit.Public;

public class AbpCmsKitProPublicApplicationAutoMapperProfile : Profile
{
    public AbpCmsKitProPublicApplicationAutoMapperProfile()
    {
        CreateMap<NewsletterPreferenceDefinition, NewsletterPreferenceDetailsDto>()
            .Ignore(preferenceDetailsDto => preferenceDetailsDto.DisplayPreference)
            .Ignore(preferenceDetailsDto => preferenceDetailsDto.Definition)
            .Ignore(preferenceDetailsDto => preferenceDetailsDto.IsSelectedByEmailAddress);
        CreateMap<NewsletterPreferenceDefinition, NewsletterEmailOptionsDto>()
            .Ignore(newsletterEmailOptionsDto => newsletterEmailOptionsDto.PrivacyPolicyConfirmation)
            .Ignore(newsletterEmailOptionsDto => newsletterEmailOptionsDto.DisplayAdditionalPreferences)
            .Ignore(newsletterEmailOptionsDto => newsletterEmailOptionsDto.AdditionalPreferences);
        CreateMap<ShortenedUrl, ShortenedUrlDto>();
        CreateMap<ShortenedUrlCacheItem, ShortenedUrlDto>();
        CreateMap<Poll, PollWithDetailsDto>();
        CreateMap<PollOption, PollOptionDto>();
    }
}