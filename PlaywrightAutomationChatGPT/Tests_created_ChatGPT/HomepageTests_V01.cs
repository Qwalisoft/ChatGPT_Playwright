using Microsoft.Playwright;
using PlaywrightAutomationChatGPT.Pages_generated_ChatGPT;
using static System.Net.Mime.MediaTypeNames;


namespace PlaywrightAutomationChatGPT.Tests_created_ChatGPT;

public class TestCases
{
    private const string HomePageUrl = "https://demo.nopcommerce.com/";

    [Test]
    public async Task VerifyPageElementsAreVisible()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
        var context = await browser.NewContextAsync();
        var page = await context.NewPageAsync();

        var pageHome = new Page_Home_V02(page);
        await pageHome.NavigateToHomePageAsync(HomePageUrl);

        await pageHome.IsRegisterLinkVisibleAsync();
        await pageHome.IsLoginLinkVisibleAsync();
        await pageHome.IsComputersLinkVisibleAsync();
        await pageHome.IsElectronicsLinkVisibleAsync();
    }
}




