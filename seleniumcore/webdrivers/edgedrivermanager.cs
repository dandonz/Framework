using OpenQA.Selenium;
using OpenQA.Selenium.Edge; 
using WebDriverManager; 
using WebDriverManager.DriverConfigs.Impl; 

namespace Automation.SeleniumCore
{
    public class EdgeDriverManager: DriverManager
    {
        protected override void createWebDriver()
        {            
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig(),"Latest",WebDriverManager.Helpers.Architecture.Auto);
            this.driver = new EdgeDriver();
        }

    }
}