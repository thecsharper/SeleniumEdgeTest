using OpenQA.Selenium.Remote;

namespace SeleniumEdgeTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // From https://developer.microsoft.com/en-us/microsoft-edge/tools/webdriver/#downloads
            var service = OpenQA.Selenium.Edge.EdgeDriverService.CreateDefaultService(@"D:\Develop\SeleniumEdgeTest\Drivers\edgedriver_win32", @"msedgedriver.exe");
            service.UseVerboseLogging = true;
            service.UseSpecCompliantProtocol = true;
            service.Start();

            var options = new OpenQA.Selenium.Edge.EdgeOptions();

            var driver = new RemoteWebDriver(service.ServiceUrl, options);
            driver.Url = "https://www.w2globaldata.com";
            driver.Navigate();
        }
    }
}
