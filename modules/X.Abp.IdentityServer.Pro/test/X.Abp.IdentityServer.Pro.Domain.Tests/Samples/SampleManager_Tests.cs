﻿using System.Threading.Tasks;
using Xunit;

namespace X.Abp.IdentityServer.Pro.Samples;

public class SampleManager_Tests : ProDomainTestBase
{
    //private readonly SampleManager _sampleManager;

    public SampleManager_Tests()
    {
        //_sampleManager = GetRequiredService<SampleManager>();
    }

    [Fact]
    public Task Method1Async()
    {
        return Task.CompletedTask;
    }
}