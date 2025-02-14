﻿using X.Abp.IdentityServer.Samples;
using Xunit;

namespace X.Abp.IdentityServer.MongoDB.Samples;

[Collection(MongoTestCollection.Name)]
public class SampleRepository_Tests : SampleRepository_Tests<AbpIdentityServerProMongoDbTestModule>
{
    /* Don't write custom repository tests here, instead write to
     * the base class.
     * One exception can be some specific tests related to MongoDB.
     */
}
