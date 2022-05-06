namespace Automation.SeleniumCore
{
    public static class DriverManagerFactory
    {
        public static DriverManager getDriverManager(string type )
        {
            DriverManager driverManager; 
            switch (type)
            {
                case "CHROME": 
                    driverManager = new ChromeDriverManager();
                    break; 
                case "FIREFOX": 
                    driverManager = null; 
                    break; 
                default:
                    driverManager = null; 
                    break; 
            }
            return driverManager; 
        }
    }

}