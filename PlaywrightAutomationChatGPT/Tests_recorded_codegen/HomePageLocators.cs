/*
    using Microsoft.Playwright;
    using System;
    using System.Threading.Tasks;
    
    using var playwright = await Playwright.CreateAsync();
    await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
    {
        Headless = false,
    });
    var context = await browser.NewContextAsync();
    var page = await context.NewPageAsync();
    await page.GotoAsync("https://demo.nopcommerce.com/");
    await Assertions.Expect(page.GetByRole(AriaRole.Link, new() { Name = "Register" })).ToBeVisibleAsync();
    await Assertions.Expect(page.GetByRole(AriaRole.Link, new() { Name = "Log in" })).ToBeVisibleAsync();
    await Assertions.Expect(page.GetByRole(AriaRole.Link, new() { Name = "Computers" })).ToBeVisibleAsync();
    await Assertions.Expect(page.GetByRole().ToBeVisibleAsync(GetByRole(AriaRole.Link, new() { Name = "Electronics" }).First);
 
 */