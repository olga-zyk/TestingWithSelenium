using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestingWithSelenium.PageObjects;
using NUnit.Framework;

namespace TestingWithSelenium
{
    [TestClass]
    public class TestClass
    {
        private IWebDriver _driver;

        [SetUp]
        public void SetUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void TestMethod1()
        {
            HomePage home = new HomePage(_driver);
            home.GoToPage();
            CompanySelectionPage companySelection = home.GoToCompanySelectionPage();
            companySelection.ChooseVilniusRegion();
            companySelection.ChooseAllIndustries();

        }

        [TearDown]
        public void TearDown()
        {
            if (_driver != null)
            {
                _driver.Close();
            }
        }
    }
}
