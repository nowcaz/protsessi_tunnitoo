using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Selenium
{
    public class FirstTestCase
    {
        static void Main(string[] args)
        {
            string binaryLocation = "C:\\Users\\opilane\\Source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";


            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\Source\\repos\\protsessi_tunnitoo-main\\protsessi_tunnitoo-main\\Selenium\\Selenium\\Drivers", options);
            driver.Url = "http://127.0.0.1:5500/proge-too-main/M-ng-main/index.html";
        }
    }
}
