﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using Volo.Abp.GlobalFeatures;

namespace X.Abp.CmsKit.GlobalFeatures;

[GlobalFeatureName(Name)]
public class UrlShortingFeature : GlobalFeature
{
    public const string Name = "CmsKitPro.UrlShorting";

    internal UrlShortingFeature(GlobalCmsKitProFeatures value)
      : base(value)
    {
    }
}
