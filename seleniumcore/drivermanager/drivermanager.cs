using OpenQA.Selenium; 
namespace Automation.SeleniumCore
{
    public abstract class DriverManager
    {
        protected IWebDriver driver; 
        protected abstract void createWebDriver();
        public void quitWebDriver()
        {
            if(null != driver)
            {
                driver.Quit();
                driver.Dispose(); 
            }
        }
        public IWebDriver getWebDriver()
        {
            if(null == driver)
            {
                createWebDriver();
            }
            return driver; 
        }
    }
}