// <copyright file="BingMainPage.cs" company="Automate The Planet Ltd.">
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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using SeleniumExtras.PageObjects;

namespace WebDriverTestsCSharpSix.CSharpSix.NameOfExpression
{
    public class BingMainPage
    {
        private readonly IWebDriver _driver;

        public BingMainPage(IWebDriver browser)
        {
            _driver = browser;
            PageFactory.InitElements(browser, this);
        }

        public string Url
        {
            get
            {
                return @"http://www.bing.com/";
            }
        }

        [FindsBy(How = How.Id, Using = "sb_form_q")]
        public IWebElement SearchBox { get; set; }

        [FindsBy(How = How.Id, Using = "sb_form_go")]
        public IWebElement GoButton { get; set; }

        [FindsBy(How = How.Id, Using = "b_tween")]
        public IWebElement ResultsCountDiv { get; set; }

        public void Navigate()
        {
            _driver.Navigate().GoToUrl(Url);
        }

        public void Login(string email, string password)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException(nameof(email) + " cannot be null or empty.");
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException(nameof(password) + " cannot be null or empty.");
            }

            // login the user
        }

        public void Search(string textToType)
        {
            if (string.IsNullOrEmpty(textToType))
            {
                throw new ArgumentException(nameof(textToType) + "cannot be null or empty.");
            }

            SearchBox.Clear();
            SearchBox.SendKeys(textToType);
            GoButton.Click();
        }

        public void AssertResultsCount(string expectedCount)
        {
            Assert.AreEqual(ResultsCountDiv.Text, expectedCount);
        }
    }
}