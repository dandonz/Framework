using OpenQA.Selenium; 
namespace Automation.SeleniumCore
{
    public abstract class DriverManager
    {
        protected IWebDriver driver; 
        protected abstract void createWebDriver();
        public IWebDriver getWebDriver()
        {
            if(null == driver)
            {
                createWebDriver();
            }
            return driver; 
        }
        public void quitWebDriver()
        {
            if(null != driver)
            {
                driver.Quit();
                driver.Dispose(); 
            }
        }

    }
}