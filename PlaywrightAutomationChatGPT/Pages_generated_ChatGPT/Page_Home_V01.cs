using Microsoft.Playwright;

namespace PlaywrightAutomationChatGPT.Pages_generated_ChatGPT;

public class Page_Home_V01
{
    private readonly IPage _page;

    public Page_Home_V01(IPage page)
    {
        _page = page;
    }

    public async Task NavigateToHomePageAsync(string url)
    {
        await _page.GotoAsync(url);
    }

    public async Task<bool> IsRegisterLinkVisibleAsync()
    {
        return await _page.GetByRole(AriaRole.Link, new() { Name = "Register" }).IsVisibleAsync();
    }

    public async Task<bool> IsLoginLinkVisibleAsync()
    {
        return await _page.GetByRole(AriaRole.Link, new() { Name = "Log in" }).IsVisibleAsync();
    }

    public async Task<bool> IsComputersLinkVisibleAsync()
    {
        return await _page.GetByRole(AriaRole.Link, new() { Name = "Computers" }).IsVisibleAsync();
    }

    public async Task<bool> IsElectronicsLinkVisibleAsync()
    {
        return await _page.GetByRole(AriaRole.Link, new() { Name = "Electronics" }).IsVisibleAsync();
    }
}
