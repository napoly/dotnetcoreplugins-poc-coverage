using Microsoft.Playwright;
using MvcAppPlugin;
using MvcWebApp;
using Xunit;

namespace IntegrationTest;

public class PlaywrightPluginIntegrationTest : IAsyncLifetime
{
    private IPage _page;
    private IBrowser _browser;

    public async Task InitializeAsync()
    {
        var playwright = await Playwright.CreateAsync();
        _browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
        var context = await _browser.NewContextAsync();
        _page = await context.NewPageAsync();
    }

    public async Task DisposeAsync()
    {
        await _browser.CloseAsync();
    }
    
    [Fact]
    public async Task ExecutePluginSuccessfully()
    {
        await _page.GotoAsync("http://localhost:5000/");
        await _page.ClickAsync("a[href='/myplugin']");
        var textContent = await _page.InnerTextAsync("p");
        Assert.Equal("Hello world from Plugin!", textContent);
    }

    /*[Fact]
    public void CallPluginFunctionDirectly()
    {
        new MyPluginController().Index();
    }
    
    [Fact]
    public void CreateWebHostBuilder()
    {
        ProgramMvcApp.CreateWebHostBuilder(["test"]);
    }*/
}