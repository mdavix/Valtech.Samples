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

        [ElementLocator(CssSelector = "button[type=submit]")]
        public IWebElement ContinueToNextStep { get; set; }

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
    }
}
