using Microsoft.Playwright;

namespace PlaywrightAutomationChatGPT.Tests_created_ChatGPT;
public class Page_Home_V00
{
    private const string HomePageUrl = "https://demo.nopcommerce.com/";

    [Test]
    public async Task VerifyPageElementsAreVisible()
    {
        // Launch browser and create a new page
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false,
        });
        var context = await browser.NewContextAsync();
        var page = await context.NewPageAsync();

        // Navigate to the homepage
        await page.GotoAsync(HomePageUrl);

        // Verify visibility of page elements
        await Assertions.Expect(Eelement(page)).ToBeVisibleAsync();

        await Assertions.Expect(page.GetByRole(AriaRole.Link, new() { Name = "Log in" })).ToBeVisibleAsync();
        await Assertions.Expect(page.GetByRole(AriaRole.Link, new() { Name = "Computers" })).ToBeVisibleAsync();
        await Assertions.Expect(page.GetByRole(AriaRole.Link, new() { Name = "Electronics" }).First).ToBeVisibleAsync();
    }

    private static ILocator Eelement(IPage page)
    {
        return page.GetByRole(AriaRole.Link, new() { Name = "Register" });
    }
}




