using System.Collections.Generic;
using NUnit.Framework;

namespace ServiceStack.Redis.Tests
{
    [TestFixture]
    public class RedisStatsTests
        : RedisClientTestsBase
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            RedisConfig.AssumeServerVersion = 2821;
        }

        [Test]
        [Ignore("too long")]
        public void Batch_and_Pipeline_requests_only_counts_as_1_request()
        {
        }
    }
}