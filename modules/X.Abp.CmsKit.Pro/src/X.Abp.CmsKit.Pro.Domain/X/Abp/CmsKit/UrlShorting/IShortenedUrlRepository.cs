﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using Volo.Abp.Domain.Repositories;

namespace X.Abp.CmsKit.UrlShorting;

public interface IShortenedUrlRepository :
IBasicRepository<ShortenedUrl, Guid>
{
    Task<List<ShortenedUrl>> GetListAsync(
      string filter = null,
      string sorting = null,
      int skipCount = 0,
      int maxResultCount = int.MaxValue,
      CancellationToken cancellationToken = default);

    Task<long> GetCountAsync(string filter = null, CancellationToken cancellationToken = default);

    Task<ShortenedUrl> FindBySourceUrlAsync(
      string sourceUrl,
      CancellationToken cancellationToken = default);
}