using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace HomeAppliancesCost.StepDefinitions
{
    [Binding]
    public class ScotlandResidentCostStepDefinitions
    {
        IWebDriver driver;
        [Given(@"I am a resident from Scotland")]
        public void GivenIAmAResidentFromScotland()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.citizensadvice.org.uk/");
            driver.FindElement(By.XPath("//*[@id=\"home-extent-popup\"]/div/div/a[3]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"main-nav\"]/ul/li[4]/a")).Click();
            driver.FindElement(By.XPath("//*[@id=\"main\"]/div[2]/div/div[2]/ul/li/a")).Click();
            driver.FindElement(By.XPath("//*[@id=\"main\"]/div[2]/div/div[2]/ul/li[6]/a")).Click();
        }

        [When(@"I add the list appliances Electric blanket and its average usage and the national average rates")]
        public void WhenIAddTheListAppliancesElectricBlanketAndItsAverageUsageAndTheNationalAverageRates()
        {
            throw new PendingStepException();
        }

        [Then(@"I should get the results table with daily, weekly, monthly, and yearly costs")]
        public void ThenIShouldGetTheResultsTableWithDailyWeeklyMonthlyAndYearlyCosts()
        {
            throw new PendingStepException();
        }
    }
}