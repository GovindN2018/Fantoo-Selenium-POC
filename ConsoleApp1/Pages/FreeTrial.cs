namespace AutoTestFramework.Pages
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    public class FreeTrial
    {
        public FreeTrial()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > label")]
        public IWebElement LblName { get; set; }

        [FindsBy(How = How.Id, Using = "first-name")]
        public IWebElement TbFirstName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > div > div.left-input.has-error > span")]
        public IWebElement WarningFirstNameBlank { get; set; }

        [FindsBy(How = How.Id, Using = "last-name")]
        public IWebElement TbLastName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > div > div.right-input.has-error > span")]
        public IWebElement WarningLastNameBlank { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > ul > li:nth-child(1) > label")]
        public IWebElement LblEmailAddress { get; set; }

        [FindsBy(How = How.Id, Using = "email-address")]
        public IWebElement TbEmailAddress { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > ul > li:nth-child(1) > span")]
        public IWebElement WarningInvalidOrBlankEmail { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > ul > li:nth-child(2) > label")]
        public IWebElement LblCompanyName { get; set; }

        [FindsBy(How = How.Id, Using = "company-name")]
        public IWebElement TbCompanyName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > ul > li:nth-child(2) > span")]
        public IWebElement WarningCompanyNameBlank { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > ul > li:nth-child(3) > input[type=\"submit\"]")]
        public IWebElement BtnSubmit { get; set; }

    }
}
