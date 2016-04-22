using OpenQA.Selenium;
using SpecBind.Pages;

namespace Valtech.Samples.BG.AcceptanceTests.Pages
{
    [PageNavigation("/en/quote/health")]
    public class HealthInsuranceQuote
    {
        [ElementLocator(CssSelector = "select.title")]
        public IWebElement Title { get; set; }

        [ElementLocator(CssSelector = "#fn")]
        public IWebElement FirstName { get; set; }

        [ElementLocator(CssSelector = "#sn")]
        public IWebElement SecondName { get; set; }

        [ElementLocator(CssSelector = "#dd")]
        public IWebElement Day { get; set; }

        [ElementLocator(CssSelector = "#mm")]
        public IWebElement Month { get; set; }

        [ElementLocator(CssSelector = "#yyyy")]
        public IWebElement Year { get; set; }

        [ElementLocator(CssSelector = "#e-mail")]
        public IWebElement Email { get; set; }

        [ElementLocator(CssSelector = "#cc")]
        public IWebElement CountryCode { get; set; }

        [ElementLocator(CssSelector = "#phone")]
        public IWebElement PhoneNumber { get; set; }

        [ElementLocator(CssSelector = "div.tickbox-privacy")]
        public IWebElement PrivacyTickbox { get; set; }

        [ElementLocator(CssSelector = "button.get-quote")]
        public IWebElement GetQuoteButton { get; set; }

        [ElementLocator(CssSelector = "div.go-to-summary")]
        public IWebElement SeeThisPlan { get; set; }
    }
}
