using OpenQA.Selenium;
using SpecBind.Pages;

namespace Valtech.Samples.BG.AcceptanceTests.Pages
{
    [PageNavigation("/en/Quote/Health-insurance")]
    public class QuotePage : BGBasePage
    {
        [ElementLocator(CssSelector = "div.quote-answer-item")]
        public IWebElement GlobalHealthInsurance { get; set; }

        [ElementLocator(CssSelector = "input.quote-input-country")]
        public IWebElement Country { get; set; }
    }
}
