namespace AutoTestFramework.Pages.PageElements
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    public class Menu
    {
        public Menu()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#header > section > div > div.left.logo > a")]
        public IWebElement LinkLeftLogo { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#main-navigation > ul > li:nth-child(1) > a")]
        public IWebElement LinkProduct { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#main-navigation > ul > li:nth-child(2) > a")]
        public IWebElement LinkAbout { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#main-navigation > ul > li:nth-child(3) > a")]
        public IWebElement LinkContactUs { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#main-navigation > ul > li.free-trial-button > a")]
        public IWebElement BtnFreeTrial { get; set; }

    }
}
