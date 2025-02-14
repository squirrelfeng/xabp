﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Volo.Abp.Domain.Repositories.MongoDB;
using Volo.Abp.MongoDB;
using Volo.Abp.Threading;

using X.Abp.LanguageManagement.External;

namespace X.Abp.LanguageManagement.MongoDB
{
    public class MongoLocalizationResourceRecordRepository : MongoDbRepository<ILanguageManagementMongoDbContext, LocalizationResourceRecord, Guid>, ILocalizationResourceRecordRepository
    {
        public MongoLocalizationResourceRecordRepository(
          IMongoDbContextProvider<ILanguageManagementMongoDbContext> dbContextProvider)
          : base(dbContextProvider)
        {
        }

        public LocalizationResourceRecord? Find(string name)
        {
            using (Volo.Abp.Uow.UnitOfWorkManager.DisableObsoleteDbContextCreationWarning.SetScoped(true))
            {
                return GetMongoQueryable().FirstOrDefault(localizationResourceRecord => localizationResourceRecord.Name == name);
            }
        }

        public virtual async Task<LocalizationResourceRecord?> FindAsync(
          string name,
          CancellationToken cancellationToken = default)
        {
            return await FindAsync(localizationResourceRecord => localizationResourceRecord.Name == name, true, cancellationToken);
        }
    }
}
