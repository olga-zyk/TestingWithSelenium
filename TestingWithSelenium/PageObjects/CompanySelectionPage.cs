using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;


namespace TestingWithSelenium.PageObjects
{
    class CompanySelectionPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public CompanySelectionPage(IWebDriver driver)
        {
            this._driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ctl00_phMainContent_ctl12")]
        private IWebElement byLocationTable;

        //[FindsBy(How = How.Id, Using = "ctl00_phMainContent_rptRegions_ctl01_lbCheckGroup")]

        [FindsBy(How = How.ClassName, Using = "data options-list generated161")]
        private IWebElement byIndustryTable;

        //public void GoToPage()
        //{
        //    driver.Navigate().GoToUrl("https://www.118.lt/db-uzsakymas?actionId=5");
        //}

        public void ChooseVilniusRegion()
        {
            byLocationTable.FindElement(By.Id("ctl00_phMainContent_rptRegions_ctl01_lbCheckGroup")).Click();
            _driver.FindElement(By.Id("ctl00_phMainContent_rptRegions_ctl01_rptRegionsSub_ctl07_cbChild")).Click();
        }

        public void ChooseAllIndustries()
        {
            byIndustryTable.FindElement(By.Id("ctl00_phMainContent_rptActivities_ctl00_cbAllActivities"));
        }

    }
}
