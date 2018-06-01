
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

            cuClear.TbFirstName.Clear();
            cuClear.TbLastName.Clear();
            cuClear.TbCompanyName.Clear();
            cuClear.TbEmailAddress.Clear();
            cuClear.TbPhoneNumber.Clear();
            cuClear.DrbSubject.SendKeys("Select an option" + Keys.Enter);
            cuClear.TbMessage.Clear();
        }

        public static void FillContactUsForm(string FirstName, string LastName, string CompanyName, string EmailAddress, string PhoneNumber, string Subject, string Message)
        {
            FantooContactUsPage cuPost = new FantooContactUsPage();

            cuPost.TbFirstName.SendKeys(FirstName);
            cuPost.TbLastName.SendKeys(LastName);
            cuPost.TbCompanyName.SendKeys(CompanyName);
            cuPost.TbEmailAddress.SendKeys(EmailAddress);
            cuPost.TbPhoneNumber.SendKeys(PhoneNumber);
            cuPost.DrbSubject.SendKeys(Subject + Keys.Enter);
            cuPost.TbMessage.SendKeys(Message);        
        }

        public static void SubmitContactUsForm()
        {
            FantooContactUsPage cuSubmit = new FantooContactUsPage();
            cuSubmit.BtnSubmit.Click();
        }

    }
}
