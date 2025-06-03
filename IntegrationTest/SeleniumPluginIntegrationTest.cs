using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace IntegrationTest
{
    public class SeleniumPluginIntegrationTest : IAsyncLifetime
    {
        private IWebDriver _driver;

        public async Task InitializeAsync()
        {
            // Start Chrome browser
            var options = new ChromeOptions();
            // options.AddArgument("headless"); // Run in headless mode, remove if you want to see the browser
            _driver = new ChromeDriver(options);
        }

        public async Task DisposeAsync()
        {
            // Dispose the driver after the tests
            _driver.Quit();
        }

        [Fact]
        public async Task ExecutePluginSuccessfully()
        {
            // Navigate to the page
            _driver.Navigate().GoToUrl("http://localhost:5000/");

            // Find the link and click it
            var link = _driver.FindElement(By.CssSelector("a[href='/myplugin']"));
            link.Click();

            // Get the text content of the <p> element
            var textContent = _driver.FindElement(By.CssSelector("p")).Text;

            // Assert the text content is as expected
            Assert.Equal("Hello world from Plugin!", textContent);
        }
    }
}