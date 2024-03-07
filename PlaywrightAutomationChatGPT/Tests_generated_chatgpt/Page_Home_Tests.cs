using Microsoft.Playwright;
using PlaywrightAutomationChatGPT.Pages_generated_chatgpt;

namespace PlaywrightAutomationChatGPT.Tests_generated_chatgpt;

public class Page_Home_Tests
{
    private const string HomePageUrl = "https://demo.nopcommerce.com/";

    [Test]
    public async Task VerifyPageElementsAreVisible()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
        var context = await browser.NewContextAsync();
        var page = await context.NewPageAsync();

        var pageHome = new Page_Home(page);
        await pageHome.NavigateToHomePageAsync(HomePageUrl);

        await pageHome.IsRegisterLinkVisibleAsync();
        await pageHome.IsLoginLinkVisibleAsync();
        await pageHome.IsComputersLinkVisibleAsync();
        await pageHome.IsElectronicsLinkVisibleAsync();
    }
}




