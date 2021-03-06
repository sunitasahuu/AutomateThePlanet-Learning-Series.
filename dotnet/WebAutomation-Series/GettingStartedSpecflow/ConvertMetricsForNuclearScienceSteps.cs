// <copyright file="ConvertMetricsForNuclearScienceStepsRegularExpressions - Copy.cs" company="Automate The Planet Ltd.">
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

using GettingStartedSpecflow.Core;
using GettingStartedSpecflow.Pages;
using TechTalk.SpecFlow;

namespace GettingStartedSpecflow
{
    [Binding]
    public class ConvertMetricsForNuclearScienceSteps
    {
        private HomePage _homePage;
        private KilowattHoursPage _kilowattHoursPage;

        [Given(@"web browser is opened")]
        public void GivenWebBrowserIsOpened()
        {
            Driver.StartBrowser(BrowserTypes.Chrome);
        }

        [Then(@"close web browser")]
        public void ThenCloseWebBrowser()
        {
            Driver.StopBrowser();
        }

        [When(@"I navigate to Metric Conversions")]
        public void WhenINavigateToMetricConversions_()
        {
            _homePage = new HomePage(Driver.Browser);
            _homePage.Open();
        }

        [When(@"navigate to Energy and power section")]
        public void WhenNavigateToEnergyAndPowerSection()
        {
            _homePage.EnergyAndPowerAnchor.Click();
        }

        [When(@"navigate to Kilowatt-hours")]
        public void WhenNavigateToKilowatt_Hours()
        {
            _homePage.KilowattHours.Click();
        }

        [When(@"choose conversions to Newton-meters")]
        public void WhenChooseConversionsToNewton_Meters()
        {
            _kilowattHoursPage = new KilowattHoursPage(Driver.Browser);
            _kilowattHoursPage.KilowatHoursToNewtonMetersAnchor.Click();
        }

        [When(@"type (.*) kWh")]
        public void WhenTypeKWh(double kWh)
        {
            _kilowattHoursPage.ConvertKilowattHoursToNewtonMeters(kWh);
        }

        [Then(@"assert that (.*) Nm are displayed as answer")]
        public void ThenAssertThatENmAreDisplayedAsAnswer(string expectedNewtonMeters)
        {
            _kilowattHoursPage.AssertFahrenheit(expectedNewtonMeters);
        }
    }
}