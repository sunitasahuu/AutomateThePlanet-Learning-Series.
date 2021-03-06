// <copyright file="MessageArgsMsTest.cs" company="Automate The Planet Ltd.">
// Copyright 2021 Automate The Planet Ltd.
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
using System;
using System.IO;
using System.Text;

namespace MSBuildTcpIPLogger
{
    public class MessageArgsMsTest : BaseMessageArgs
    {
        public string TestListContent { get; set; }

        public string ResultsFilePath { get; set; }

        public string TestListPath { get; set; }

        public string ListName { get; set; }

        public MessageArgsMsTest(Command command, string projectPath, IpAddressSettings ipAddressSettings, string workingDir, string testListContent, string testListName, string resultsFilePath)
            : base(command, projectPath, ipAddressSettings, workingDir)
        {
            TestListContent = testListContent;
            ResultsFilePath = resultsFilePath;
            ListName = testListName;
        }

        public MessageArgsMsTest()
        {
        }

        public string CreateTestList()
        {
            TestListPath = string.Empty;
            if (!string.IsNullOrEmpty(TestListContent))
            {
                TestListPath = Path.GetTempFileName();
                var sw = new StreamWriter(TestListPath, false, Encoding.UTF8);
                TestListContent = TestListContent.TrimStart('?');
                sw.WriteLine(TestListContent);
                sw.Close();
                sw = new StreamWriter(@"E:\AutomationTestAssistant\ServerAgent\bin\Release\testList.xml", false, Encoding.UTF8);
                sw.WriteLine(TestListContent);
                sw.Close();
            }

            return TestListPath;
        }
    }
}
