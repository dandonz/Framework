using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager; 
using WebDriverManager.DriverConfigs.Impl; 

namespace Automation.SeleniumCore
{
    public class ChromeDriverManager: DriverManager
    {
        protected override void createWebDriver()
        {            
            ChromeOptions chromeOptions = new ChromeOptions();
            // chromeOptions.AddArguments("--headless");
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig(),"Latest",WebDriverManager.Helpers.Architecture.Auto);
            this.driver = new ChromeDriver(chromeOptions); 
        }

    }
}

//How to use WebDriverManager: https://www.nuget.org/packages/WebDriverManager/

//WebDriverManager.chromedriver().setup();

// WebDriverManager.firefoxdriver().setup();

// WebDriverManager.iedriver().setup();

// WebDriverManager.edgedriver().setup();

// WebDriverManager.operadriver().setup();

// WebDriverManager.phantomjs().setup();