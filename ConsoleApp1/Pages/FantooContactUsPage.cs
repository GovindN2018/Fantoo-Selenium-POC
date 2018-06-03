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
        public IWebElement LabelName { get; set; }

        [FindsBy(How = How.Id, Using = "first-name")]
        public IWebElement TextFirstName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > div > div.left-input.has-error > span")]
        public IWebElement WarningNoFirstName { get; set; }

        [FindsBy(How = How.Id, Using = "last-name")]
        public IWebElement TextLastName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > div > div.right-input.has-error > span")]
        public IWebElement WarningNoLastName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > ul > li:nth-child(1) > label")]
        public IWebElement LabelCompanyName { get; set; }

        [FindsBy(How = How.Id, Using = "company-name")]
        public IWebElement TextCompanyName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > ul > li.has-error > span")]
        public IWebElement WarningNoCompanyName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > ul > li:nth-child(2) > label")]
        public IWebElement LabelEmailAddress { get; set; }

        [FindsBy(How = How.Id, Using = "email-address")]
        public IWebElement TextEmailAddress { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > ul > li:nth-child(2) > span")]
        public IWebElement WarningInvalidOrBlankEmail { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > ul > li:nth-child(3) > label")]
        public IWebElement LabelPhoneNumber { get; set; }

        [FindsBy(How = How.Id, Using = "phone-number")]
        public IWebElement TextPhoneNumber { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > ul > li:nth-child(4) > label")]
        public IWebElement LabelSubject { get; set; }
          
        [FindsBy(How = How.Id, Using = "subject")]
        public IWebElement ListSubject { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > ul > li:nth-child(4) > span")]
        public IWebElement WarningNoSubject { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > ul > li:nth-child(5) > label")]
        public IWebElement LabelMessage { get; set; }

        [FindsBy(How = How.Id, Using = "message")]
        public IWebElement TextMessage { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > ul > li:nth-child(5) > span")]
        public IWebElement WarningNoMessage{ get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-inner > ul > li:nth-child(6) > input[type=\"submit\"]")]
        public IWebElement ButtonSubmit { get; set; }

        [FindsBy(How = How.Id, Using = "success-message")]
        public IWebElement SuccessMessage { get; set; }

    }
}
