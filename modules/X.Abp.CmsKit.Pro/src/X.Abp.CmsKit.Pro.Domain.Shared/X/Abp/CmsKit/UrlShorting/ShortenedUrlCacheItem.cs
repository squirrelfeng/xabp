﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using System;

namespace X.Abp.CmsKit.UrlShorting;

public class ShortenedUrlCacheItem
{
    public Guid Id { get; set; }

    public string Source { get; set; }

    public string Target { get; set; }

    public bool Exists { get; set; } = true;
}