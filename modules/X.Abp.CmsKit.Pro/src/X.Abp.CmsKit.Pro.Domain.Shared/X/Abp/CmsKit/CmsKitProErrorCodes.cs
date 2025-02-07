﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

namespace X.Abp.CmsKit;

public static class CmsKitProErrorCodes
{
    public static class UrlShorting
    {
        public const string ShortenedUrlAlreadyExistsException = "CmsKitPro:UrlForwarding:0001";
    }

    public static class Poll
    {
        public const string PollAllowSingleVoteException = "CmsKitPro:Poll:0001";
        public const string PollEndDateCannotSetBeforeStartDateException = "CmsKitPro:Poll:0002";
        public const string PollResultShowingEndDateCannotSetBeforeStartDate = "CmsKitPro:Poll:0003";
        public const string PollUserVoteVotedBySameUser = "CmsKitPro:Poll:0004";
        public const string PollOptionWidgetNameCannotBeSame = "CmsKitPro:Poll:0005";
        public const string PollHasAlreadySameCodeException = "CmsKitPro:Poll:0006";
        public const string PollSubmitVoteConcurrencyException = "CmsKitPro:Poll:0007";
    }

    public static class PageFeedbacks
    {
        public const string EntityCantHavePageFeedback = "CmsKitPro:PageFeedback:0001";
    }

    public static class FaqSection
    {
        public const string FaqSectionHasAlreadyException = "CmsKitPro:FaqSection:0001";
        public const string FaqSectionInvalidGroupName = "CmsKitPro:FaqSection:0002";
    }

    public static class FaqQuestion
    {
        public const string FaqQuestionHasAlreadyException = "CmsKitPro:FaqQuestion:0001";
        public const string FaqQuestionSectionNotFound = "CmsKitPro:FaqQuestion:0002";
    }
}
