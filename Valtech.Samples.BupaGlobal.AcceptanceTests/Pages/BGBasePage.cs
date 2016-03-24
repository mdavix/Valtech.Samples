using OpenQA.Selenium;
using SpecBind.Pages;
using SpecBind.Selenium;

namespace Valtech.Samples.BG.AcceptanceTests.Pages
{
    public class BGBasePage
    {
        //[ElementLocator(CssSelector = "nav ul.primary")]
        //public PrimaryNav Primary { get; set; }

        [ElementLocator(CssSelector = "nav ul.primary li:nth-child(1)")]
        public IWebElement InternationalHealthInsurance { get; set; }

        [ElementLocator(CssSelector = "nav ul.primary li:nth-child(2)")]
        public IWebElement BusinessHealthInsurance { get; set; }

        [ElementLocator(CssSelector = "nav ul.primary li:nth-child(3)")]
        public IWebElement GetAQuote { get; set; }

        [ElementLocator(CssSelector = "nav ul.primary li:nth-child(4)")]
        public IWebElement YourWellbeing { get; set; }

        [ElementLocator(CssSelector = "nav ul.primary li:nth-child(5)")]
        public IWebElement WhyBupaGlobal { get; set; }

        [ElementLocator(CssSelector = "nav ul.primary li:nth-child(6)")]
        public IWebElement FacilityFinder { get; set; }

        //public class PrimaryNav : WebElement
        //{
        //    public PrimaryNav(ISearchContext parent):base(parent)
        //    {
        //    }

        //    [ElementLocator(TagName = "LI", Index = 1)]
        //    public IWebElement InternaltionalHealthInsurance { get; set; }

        //    [ElementLocator(TagName = "LI", Index = 2)]
        //    public IWebElement BusinessHealthInsurance { get; set; }
        //}
    }
}
