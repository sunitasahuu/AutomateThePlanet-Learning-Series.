using JenkinsCSharpApi.Interfaces;
// <copyright file="BuildAdapter_TriggerBuild_Should.cs" company="Automate The Planet Ltd.">
// Copyright 2016 Automate The Planet Ltd.
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Anton Angelov</author>
// <site>http://automatetheplanet.com/</site>
using JenkinsCSharpApi.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telerik.JustMock;

namespace JenkinsCSharpApi.UnitTests.BuildAdapterTests
{
    [TestClass]
    public class BuildAdapter_TriggerBuild_Should
    {
        [TestMethod]
        public void TriggerBuild()
        {
            IHttpAdapter httpAdapter = Mock.Create<IHttpAdapter>();
            Mock.Arrange(() => httpAdapter.Post(Arg.AnyString, Arg.AnyString)).Returns("SUCCESS");
            var buildAdapter = new BuildAdapter(httpAdapter, JenkinsTestData.JenkinsUrl, JenkinsTestData.ProjectName);
            string response = buildAdapter.TriggerBuild(string.Empty);

            Assert.AreEqual<string>(
                "SUCCESS",
                response,
                "The build was not triggered successfully.");
        }
    }
}