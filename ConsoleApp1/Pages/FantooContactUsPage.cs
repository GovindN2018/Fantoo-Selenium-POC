using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework.Pages
{
    public class FantooContactUsPage
    {
        public FantooContactUsPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > label")]
        public IWebElement LblName { get; set; }

        [FindsBy(How = How.Id, Using = "first-name")]
        public IWebElement TbFirstName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > div > div.left-input.has-error > span")]
        public IWebElement WarningNoFirstName { get; set; }

        [FindsBy(How = How.Id, Using = "last-name")]
        public IWebElement TbLastName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > div > div.right-input.has-error > span")]
        public IWebElement WarningNoLastName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > ul > li:nth-child(1) > label")]
        public IWebElement LblCompanyName { get; set; }

        [FindsBy(How = How.Id, Using = "company-name")]
        public IWebElement TbCompanyName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > ul > li.has-error > span")]
        public IWebElement WarningNoCompanyName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > ul > li:nth-child(2) > label")]
        public IWebElement LblEmailAddress { get; set; }

        [FindsBy(How = How.Id, Using = "email-address")]
        public IWebElement TbEmailAddress { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > ul > li:nth-child(2) > span")]
        public IWebElement WarningInvalidOrBlankEmail { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > ul > li:nth-child(3) > label")]
        public IWebElement LblPhoneNumber { get; set; }

        [FindsBy(How = How.Id, Using = "phone-number")]
        public IWebElement TbPhoneNumber { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > ul > li:nth-child(4) > label")]
        public IWebElement LblSubject { get; set; }
          
        [FindsBy(How = How.Id, Using = "subject")]
        public IWebElement DrbSubject { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > ul > li:nth-child(4) > span")]
        public IWebElement WarningNoSubject { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > ul > li:nth-child(5) > label")]
        public IWebElement LblMessage { get; set; }

        [FindsBy(How = How.Id, Using = "message")]
        public IWebElement TbMessage { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > ul > li:nth-child(5) > span")]
        public IWebElement WarningNoMessage{ get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > ul > li:nth-child(6) > input[type=\"submit\"]")]
        public IWebElement BtnSubmit { get; set; }

        [FindsBy(How = How.Id, Using = "success-message")]
        public IWebElement SuccessMessage { get; set; }

    }
}
