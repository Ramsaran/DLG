using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace DLG.Stepdefinitions
{
    [Binding]
    class Navigation_and_Search
    {
        public IWebDriver driver;
        [Given(@"I have launch the Browser")]
        public void GivenIHaveLaunchTheBrowser()
        {
            driver = new FirefoxDriver();
        }

        [Given(@"I have entered URL")]
        public void GivenIHaveEnteredURL()
        {
            driver.Navigate().GoToUrl("https://covercheck.vwfsinsuranceportal.co.uk/");
        }

        [Then(@"the homepage should be display")]
        public void ThenTheHomepageShouldBeDisplay()
        {
            true.Equals(driver.FindElement(By.Id("dlg-dealersearch-title")).Displayed);
        }

        [Then(@"Enter the vehicle registration number and click on Find vehicle button")]
        public void ThenEnterTheVehicleRegistrationNumberAndClickOnFindVehicleButton()
        {
            driver.FindElement(By.Id("vehicleReg")).SendKeys("OV12UYY");
            driver.FindElement(By.ClassName("track-search")).Click();
        }

        [Then(@"Vehicle registration number should be display cover start and cover end")]
        public void ThenVehicleRegistrationNumberShouldBeDisplayCoverStartAndCoverEnd()
        {
            true.Equals(driver.FindElement(By.Id("dlg-dealersearch-title")).Displayed);
        }

    }
}
