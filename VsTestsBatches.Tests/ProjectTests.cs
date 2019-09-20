using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using VsTestBatches;
using Xunit;
using Xunit.Abstractions;

namespace VsTestsBatches.Tests
{
    public class ProjectTests
    {
        [Theory]
        [ClassData(typeof(VersionsData))]
        public void CheckVersion(string version, bool expected)
        {
            Project project = new Project();
            bool result = project.IsVersionSupported(version);

            Assert.Equal(result, expected);
        }
    }

    public class VersionsData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "V2", true };
            yield return new object[] { "V1", true };
            yield return new object[] { "beta", false };
            yield return new object[] { "alpha", false };
            yield return new object[] { "internal", false };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
