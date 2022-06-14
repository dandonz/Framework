using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using WebDriverManager; 
using WebDriverManager.DriverConfigs.Impl; 

namespace Automation.SeleniumCore
{
    public class FirefoxDriverManager: DriverManager
    {
        protected override void createWebDriver()        
        {
            FirefoxOptions firefoxOptions = new FirefoxOptions();
            // firefoxOptions.AddArguments("--headless");
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig(),"Latest",WebDriverManager.Helpers.Architecture.Auto);
            this.driver = new FirefoxDriver(firefoxOptions);
        }
    }

}