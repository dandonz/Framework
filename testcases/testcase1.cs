using OpenQA.Selenium;
using Automation.SeleniumCore; 
using Xunit; 
using System; 

namespace Automation.TestCases
{
    public class TestCases1
    {
        //https://q-automations.com/2020/08/16/selenium-with-azure-pipeline/
        //Todo@dandonz 
        IWebDriver driver; 
        DriverManager driverManager; 
        [Fact]
        public void BingSearchTest()
        {
            driverManager = DriverManagerFactory.getDriverManager("CHROME");
            driver = driverManager.getWebDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); 

            try
            {
                driver.Navigate().GoToUrl("http://www.bing.com/");
                IWebElement txtSearchBox = driver.FindElement(By.Id("sb_form_q"));
                txtSearchBox.SendKeys("Deploy Selenium Automation Test to Azure");


                IWebElement form = driver.FindElement(By.Id("sb_form"));
                System.Threading.Thread.Sleep(5000);
                form.Submit();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally{
                driver.Close();
                driver.Quit();
            }
        }
    }
}