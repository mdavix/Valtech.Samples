using OpenQA.Selenium;
using SpecBind.Pages;

namespace Valtech.Samples.BG.AcceptanceTests.Pages
{
    [PageNavigation("/en/quote")]
    public class QuotePage : BGBasePage
    {
        [ElementLocator(CssSelector = "button.quote-button[data-cover-type='health']")]
        public IWebElement GlobalHealthInsurance { get; set; }

        [ElementLocator(CssSelector = "input.quote-input-country")]
        public IWebElement Country { get; set; }

        [ElementLocator(CssSelector = "button[type=submit]")]
        public IWebElement ContinueToNextStep { get; set; }
    }
}
