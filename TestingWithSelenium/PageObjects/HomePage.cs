using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestingWithSelenium.PageObjects
{
    class HomePage
    {
        private IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            this._driver = driver;
            //PageFactory.InitElements(driver, this);
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ctl00_phMainContent_ctl00_hlDBSale")]
        private IWebElement companySelection;

        public void GoToPage()
        {
            _driver.Navigate().GoToUrl("https://www.118.lt");
        }

        public CompanySelectionPage GoToCompanySelectionPage()
        {
            companySelection.Click();
            return new CompanySelectionPage(_driver);
        }

    }
}
