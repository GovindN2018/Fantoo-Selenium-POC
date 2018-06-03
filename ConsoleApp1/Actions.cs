
using AutoTestFramework.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutoTestFramework
{
    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();

            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
        }

        public static void ClearContactUsForm()
        {
            FantooContactUsPage cuClear = new FantooContactUsPage();

            cuClear.TextFirstName.Clear();
            cuClear.TextLastName.Clear();
            cuClear.TextCompanyName.Clear();
            cuClear.TextEmailAddress.Clear();
            cuClear.TextPhoneNumber.Clear();
            cuClear.ListSubject.SendKeys("Select an option" + Keys.Enter);
            cuClear.TextMessage.Clear();
        }

        public static void FillContactUsForm(string FirstName, string LastName, string CompanyName, string EmailAddress, string PhoneNumber, string Subject, string Message)
        {
            FantooContactUsPage cuPost = new FantooContactUsPage();

            cuPost.TextFirstName.SendKeys(FirstName);
            cuPost.TextLastName.SendKeys(LastName);
            cuPost.TextCompanyName.SendKeys(CompanyName);
            cuPost.TextEmailAddress.SendKeys(EmailAddress);
            cuPost.TextPhoneNumber.SendKeys(PhoneNumber);
            cuPost.ListSubject.SendKeys(Subject + Keys.Enter);
            cuPost.TextMessage.SendKeys(Message);        
        }

        public static void SubmitContactUsForm()
        {
            FantooContactUsPage cuSubmit = new FantooContactUsPage();
            cuSubmit.ButtonSubmit.Click();
        }

    }
}
