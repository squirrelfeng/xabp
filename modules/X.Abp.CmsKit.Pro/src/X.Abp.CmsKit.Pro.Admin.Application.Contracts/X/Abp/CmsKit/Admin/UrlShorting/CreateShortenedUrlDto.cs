﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using System.ComponentModel.DataAnnotations;

using Volo.Abp.Validation;

using X.Abp.CmsKit.UrlShorting;

namespace X.Abp.CmsKit.Admin.UrlShorting;

public class CreateShortenedUrlDto
{
    [Required]
    [DynamicMaxLength(typeof(ShortenedUrlConst), "MaxSourceLength")]
    public string Source { get; set; }

    [Required]
    [DynamicMaxLength(typeof(ShortenedUrlConst), "MaxTargetLength")]
    public string Target { get; set; }
}