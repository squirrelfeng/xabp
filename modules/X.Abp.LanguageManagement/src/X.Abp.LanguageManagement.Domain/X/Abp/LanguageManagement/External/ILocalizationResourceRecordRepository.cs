﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using System;
using System.Threading;
using System.Threading.Tasks;

using Volo.Abp.Domain.Repositories;

namespace X.Abp.LanguageManagement.External
{
    public interface ILocalizationResourceRecordRepository
        : IBasicRepository<LocalizationResourceRecord, Guid>,
            IBasicRepository<LocalizationResourceRecord>,
            IReadOnlyBasicRepository<LocalizationResourceRecord>,
            IReadOnlyBasicRepository<LocalizationResourceRecord, Guid>,
            IRepository
    {
        LocalizationResourceRecord Find(string name);

        Task<LocalizationResourceRecord> FindAsync(string name, CancellationToken cancellationToken = default);
    }
}
