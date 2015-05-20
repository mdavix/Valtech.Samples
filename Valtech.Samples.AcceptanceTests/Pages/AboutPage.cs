using OpenQA.Selenium;
using SpecBind.Pages;

namespace Valtech.Samples.AcceptanceTests.Pages
{
    [PageNavigation("/about")]
    public class AboutPage
    {
        [ElementLocator(Id = "asideText")]
        public IWebElement AsideHeader { get; set; }
    }
}
