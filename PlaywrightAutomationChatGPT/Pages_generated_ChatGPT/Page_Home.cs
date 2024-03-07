using Microsoft.Playwright;


namespace PlaywrightAutomationChatGPT.Pages_generated_chatgpt
{
    public class Page_Home
    {
        private readonly IPage _page;

        // Locators
        private ILocator RegisterLinkLocator => _page.GetByRole(AriaRole.Link, new() { Name = "Register" });
        private ILocator LoginLinkLocator => _page.GetByRole(AriaRole.Link, new() { Name = "Log in" });
        private ILocator ComputersLinkLocator => _page.GetByRole(AriaRole.Link, new() { Name = "Computers" });
        private ILocator ElectronicsLinkLocator => _page.GetByRole(AriaRole.Link, new() { Name = "Electronics" }).First;


        public Page_Home(IPage page)
        {
            _page = page;
        }

        // Methods for navigation and visibility checks.
        public async Task NavigateToHomePageAsync(string url)
        {
            await _page.GotoAsync(url);
        }

        public async Task<bool> IsRegisterLinkVisibleAsync()
        {
            await RegisterLinkLocator.HighlightAsync();
            return await RegisterLinkLocator.IsVisibleAsync();
        }


        public async Task<bool> IsLoginLinkVisibleAsync()
        {
            await LoginLinkLocator.HighlightAsync();
            return await LoginLinkLocator.IsVisibleAsync();
        }

        public async Task<bool> IsComputersLinkVisibleAsync()
        {
            await ComputersLinkLocator.HighlightAsync();
            return await ComputersLinkLocator.IsVisibleAsync();
        }

        public async Task<bool> IsElectronicsLinkVisibleAsync()
        {
            await ElectronicsLinkLocator.HighlightAsync();
            return await ElectronicsLinkLocator.IsVisibleAsync();
        }
    }
}

