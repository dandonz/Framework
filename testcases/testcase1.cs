using OpenQA.Selenium;
using Automation.SeleniumCore; 
using Xunit; 
using System; 


namespace Automation.TestCases
{
    public class TestCases1
    {
        //https://swimburger.net/blog/dotnet/how-to-run-net-core-selenium-ui-tests-on-azure-devops-pipelines
        //https://www.azuredevopslabs.com/labs/vstsextend/selenium/
        //https://q-automations.com/2020/08/16/selenium-with-azure-pipeline/
        //Todo@dandonz 
        IWebDriver driver; 
        DriverManager driverManager; 
        [Fact]
        public void CarpetCleaningLoginLinkClick()
        {
            // driverManager = DriverManagerFactory.getDriverManager("CHROME");
            driverManager = DriverManagerFactory.getDriverManager("CHROME");
            driver = driverManager.getWebDriver();
            
            //Too short and should combine the using of explicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Navigate().GoToUrl("https://carpetcleaningact.com.au/");
            IWebElement lnkLogin = driver.FindElement(By.ClassName("PriceBuilder_NavlinkCustom1__3xOP-"));
            lnkLogin.Click();
            System.Threading.Thread.Sleep(3000);
            IWebElement txtUsername = driver.FindElement(By.ClassName("Input_InputElement__3sl1k"));        

            // Assert.Equal("Mail Address", txtUsername.GetAttribute("placeholder"));
            driver.Close();
            driver.Quit();
            
            driver.Dispose(); 
        }
    }
}