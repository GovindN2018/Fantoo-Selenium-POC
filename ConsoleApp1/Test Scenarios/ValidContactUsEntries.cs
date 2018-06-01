using AutoTestFramework.Pages;
using NUnit.Framework;
using System.Threading;

namespace AutoTestFramework.Test_Scenarios
{
    class ValidContactUsEntries
    {
        [SetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void SuccessfulContactUsRequestSubject1()
        {
            NavigateTo.NavigateToContactUsPage();

            Actions.ClearContactUsForm();//I made this change just now

            Actions.FillContactUsForm(Config.FormEntries.ValidEntries.FirstName, Config.FormEntries.ValidEntries.LastName,
                                      Config.FormEntries.ValidEntries.CompanyName, Config.FormEntries.ValidEntries.EmailAddress,
                                      Config.FormEntries.ValidEntries.PhoneNumber, Config.FormEntries.ValidEntries.Subject1,
                                      Config.FormEntries.ValidEntries.Message);

            Actions.SubmitContactUsForm();

            Thread.Sleep(2000);

            FantooContactUsPage cuSuccessMessage = new FantooContactUsPage();

            Assert.AreEqual(true, cuSuccessMessage.SuccessMessage.Displayed);
        }

        [Test]
        public void SuccessfulContactUsRequestSubject2()
        {
            NavigateTo.NavigateToContactUsPage();

            //Actions.ClearContactUsForm();

            Actions.FillContactUsForm(Config.FormEntries.ValidEntries.FirstName, Config.FormEntries.ValidEntries.LastName,
                                      Config.FormEntries.ValidEntries.CompanyName, Config.FormEntries.ValidEntries.EmailAddress,
                                      Config.FormEntries.ValidEntries.PhoneNumber, Config.FormEntries.ValidEntries.Subject2,
                                      Config.FormEntries.ValidEntries.Message);

            Actions.SubmitContactUsForm();

            Thread.Sleep(2000);

            FantooContactUsPage cuSuccessMessage = new FantooContactUsPage();

            Assert.AreEqual(true, cuSuccessMessage.SuccessMessage.Displayed);
        }

        [Test]
        public void SuccessfulContactUsRequestSubject3()
        {
            NavigateTo.NavigateToContactUsPage();

            Actions.ClearContactUsForm();

            Actions.FillContactUsForm(Config.FormEntries.ValidEntries.FirstName, Config.FormEntries.ValidEntries.LastName,
                                      Config.FormEntries.ValidEntries.CompanyName, Config.FormEntries.ValidEntries.EmailAddress,
                                      Config.FormEntries.ValidEntries.PhoneNumber, Config.FormEntries.ValidEntries.Subject3,
                                      Config.FormEntries.ValidEntries.Message);

            Actions.SubmitContactUsForm();

            Thread.Sleep(2000);

            FantooContactUsPage cuSuccessMessage = new FantooContactUsPage();

            Assert.AreEqual(true, cuSuccessMessage.SuccessMessage.Displayed);
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
