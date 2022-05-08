using OpenQA.Selenium.Chrome; 
using WebDriverManager; 
using WebDriverManager.DriverConfigs.Impl; 

namespace Automation.SeleniumCore
{
    public class ChromeDriverManager: DriverManager
    {
        protected override void createWebDriver()
        {
            //
            //How to use WebDriverManager: https://www.nuget.org/packages/WebDriverManager/
            //
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--headless");
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig(),"Latest",WebDriverManager.Helpers.Architecture.Auto);
            this.driver = new ChromeDriver(chromeOptions); 
        }
    }
}