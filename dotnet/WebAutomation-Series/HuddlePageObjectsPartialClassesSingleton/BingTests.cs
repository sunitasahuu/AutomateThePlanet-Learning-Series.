// <copyright file="BingTests.cs" company="Automate The Planet Ltd.">
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
// <site>https://automatetheplanet.com/</site>
using System;
using HuddlePageObjectsPartialClassesSingleton.Pages.SingletonBingMainPage;
using HuddlePageObjectsPartialClassesSingleton.SingletonBingMainPage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace HuddlePageObjectsPartialClassesSingleton
{
    [TestClass]
    public class BingTests
    {
        private IWebDriver _driver;

        [TestInitialize]
        public void TestInitialize()
        {
            _driver = new FirefoxDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            ////Driver.StartBrowser();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _driver.Quit();
            ////Driver.StopBrowser();
        }

        [TestMethod]
        public void SearchTextInBing_First()
        {
            var bingMainPage = new BingMainPage(_driver);

            bingMainPage.Navigate();
            bingMainPage.Search("Automate The Planet");

            bingMainPage.AssertResultsCount("236,000 RESULTS");
        }

        [TestMethod]
        public void Singleton_SearchTextInBing_First()
        {
            SBingMainPage.Instance.Navigate();
            SBingMainPage.Instance.Search("Automate The Planet");

            SBingMainPage.Instance.AssertResultsCount("236,000 RESULTS");
        }
    }
}
