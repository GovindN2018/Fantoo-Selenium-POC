using AutoTestFramework.Pages;
using NUnit.Framework;
using System.Threading;

namespace AutoTestFramework.Test_Scenarios
{
    class InvalidContactUsEntries
    {
        [SetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void AttemptToSubmitEmptyContactUsForm()
        {
            NavigateTo.NavigateToContactUsPage();

            Actions.ClearContactUsForm();

            Actions.SubmitContactUsForm();

            FantooContactUsPage cuEmptySubmitWarnings = new FantooContactUsPage();

            Assert.AreEqual(Config.FormEntries.WarningMessagesEmptyContactUsForm.NoFirstName, cuEmptySubmitWarnings.WarningNoFirstName.Text);
            Assert.AreEqual(Config.FormEntries.WarningMessagesEmptyContactUsForm.NoLastName, cuEmptySubmitWarnings.WarningNoLastName.Text);
            Assert.AreEqual(Config.FormEntries.WarningMessagesEmptyContactUsForm.NoCompanyName, cuEmptySubmitWarnings.WarningNoCompanyName.Text);
            Assert.AreEqual(Config.FormEntries.WarningMessagesEmptyContactUsForm.NoEmailAddress, cuEmptySubmitWarnings.WarningInvalidOrBlankEmail.Text);
            Assert.AreEqual(Config.FormEntries.WarningMessagesEmptyContactUsForm.NoSubject, cuEmptySubmitWarnings.WarningNoSubject.Text);
            Assert.AreEqual(Config.FormEntries.WarningMessagesEmptyContactUsForm.NoMessage, cuEmptySubmitWarnings.WarningNoMessage.Text);
        }

        [Test]
        public void NoFirstName()
        {
            NavigateTo.NavigateToContactUsPage();

            Actions.ClearContactUsForm();

            Actions.FillContactUsForm(Config.FormEntries.InvalidEntries.FirstName.BlankField, Config.FormEntries.ValidEntries.LastName,
                                      Config.FormEntries.ValidEntries.CompanyName, Config.FormEntries.ValidEntries.EmailAddress,
                                      Config.FormEntries.ValidEntries.PhoneNumber, Config.FormEntries.ValidEntries.Subject1,
                                      Config.FormEntries.ValidEntries.Message);

            Actions.SubmitContactUsForm();

            FantooContactUsPage cuEmptyFirstName = new FantooContactUsPage();

            Assert.AreEqual(Config.FormEntries.WarningMessagesEmptyContactUsForm.NoFirstName, cuEmptyFirstName.WarningNoFirstName.Text);
        }

        [Test]
        public void OnlySpaceCharactersInFirstName()
        {
            NavigateTo.NavigateToContactUsPage();

            Actions.ClearContactUsForm();

            Actions.FillContactUsForm(Config.FormEntries.InvalidEntries.FirstName.OnlySpaceCharacters, Config.FormEntries.ValidEntries.LastName,
                                      Config.FormEntries.ValidEntries.CompanyName, Config.FormEntries.ValidEntries.EmailAddress,
                                      Config.FormEntries.ValidEntries.PhoneNumber, Config.FormEntries.ValidEntries.Subject1,
                                      Config.FormEntries.ValidEntries.Message);

            Actions.SubmitContactUsForm();

            FantooContactUsPage cuEmptyFirstName = new FantooContactUsPage();

            Assert.AreEqual(Config.FormEntries.WarningMessagesEmptyContactUsForm.NoFirstName, cuEmptyFirstName.WarningNoFirstName.Text);
        }

        [Test]
        public void NoLastName()
        {
            NavigateTo.NavigateToContactUsPage();

            Actions.ClearContactUsForm();

            Actions.FillContactUsForm(Config.FormEntries.ValidEntries.FirstName, Config.FormEntries.InvalidEntries.LastName.BlankField,
                                      Config.FormEntries.ValidEntries.CompanyName, Config.FormEntries.ValidEntries.EmailAddress,
                                      Config.FormEntries.ValidEntries.PhoneNumber, Config.FormEntries.ValidEntries.Subject1,
                                      Config.FormEntries.ValidEntries.Message);

            Actions.SubmitContactUsForm();

            FantooContactUsPage cuEmptyLastName = new FantooContactUsPage();

            Assert.AreEqual(Config.FormEntries.WarningMessagesEmptyContactUsForm.NoLastName, cuEmptyLastName.WarningNoLastName.Text);
        }

        [Test]
        public void OnlySpaceCharactersInLastName()
        {
            NavigateTo.NavigateToContactUsPage();

            Actions.ClearContactUsForm();

            Actions.FillContactUsForm(Config.FormEntries.ValidEntries.FirstName, Config.FormEntries.InvalidEntries.LastName.OnlySpaceCharacters,
                                      Config.FormEntries.ValidEntries.CompanyName, Config.FormEntries.ValidEntries.EmailAddress,
                                      Config.FormEntries.ValidEntries.PhoneNumber, Config.FormEntries.ValidEntries.Subject1,
                                      Config.FormEntries.ValidEntries.Message);

            Actions.SubmitContactUsForm();

            FantooContactUsPage cuEmptyLastName = new FantooContactUsPage();

            Assert.AreEqual(Config.FormEntries.WarningMessagesEmptyContactUsForm.NoLastName, cuEmptyLastName.WarningNoLastName.Text);
        }

        [Test]
        public void NoCompanyName()
        {
            NavigateTo.NavigateToContactUsPage();

            Actions.ClearContactUsForm();

            Actions.FillContactUsForm(Config.FormEntries.ValidEntries.FirstName, Config.FormEntries.ValidEntries.LastName,
                                      Config.FormEntries.InvalidEntries.CompanyName.BlankField, Config.FormEntries.ValidEntries.EmailAddress,
                                      Config.FormEntries.ValidEntries.PhoneNumber, Config.FormEntries.ValidEntries.Subject1,
                                      Config.FormEntries.ValidEntries.Message);

            Actions.SubmitContactUsForm();

            FantooContactUsPage cuEmptyCompanyName = new FantooContactUsPage();

            Assert.AreEqual(Config.FormEntries.WarningMessagesEmptyContactUsForm.NoCompanyName, cuEmptyCompanyName.WarningNoCompanyName.Text);
        }

        [Test]
        public void OnlySpaceCharactersInCompanyName()
        {
            NavigateTo.NavigateToContactUsPage();

            Actions.ClearContactUsForm();

            Actions.FillContactUsForm(Config.FormEntries.ValidEntries.FirstName, Config.FormEntries.ValidEntries.LastName,
                                      Config.FormEntries.InvalidEntries.CompanyName.OnlySpaceCharacters, Config.FormEntries.ValidEntries.EmailAddress,
                                      Config.FormEntries.ValidEntries.PhoneNumber, Config.FormEntries.ValidEntries.Subject1,
                                      Config.FormEntries.ValidEntries.Message);

            Actions.SubmitContactUsForm();

            FantooContactUsPage cuEmptyCompanyName = new FantooContactUsPage();

            Assert.AreEqual(Config.FormEntries.WarningMessagesEmptyContactUsForm.NoCompanyName, cuEmptyCompanyName.WarningNoCompanyName.Text);
        }

        [Test]
        public void NoSubject()
        {
            NavigateTo.NavigateToContactUsPage();

            Actions.ClearContactUsForm();

            Actions.FillContactUsForm(Config.FormEntries.ValidEntries.FirstName, Config.FormEntries.ValidEntries.LastName,
                                      Config.FormEntries.ValidEntries.CompanyName, Config.FormEntries.ValidEntries.EmailAddress,
                                      Config.FormEntries.ValidEntries.PhoneNumber, Config.FormEntries.InvalidEntries.Subject.NoSelection,
                                      Config.FormEntries.ValidEntries.Message);

            Actions.SubmitContactUsForm();

            FantooContactUsPage cuNoSubject = new FantooContactUsPage();

            Assert.AreEqual(Config.FormEntries.WarningMessagesEmptyContactUsForm.NoCompanyName, cuNoSubject.WarningNoSubject.Text);
        }

        [Test]
        public void NoMessage()
        {
            NavigateTo.NavigateToContactUsPage();

            Actions.ClearContactUsForm();

            Actions.FillContactUsForm(Config.FormEntries.ValidEntries.FirstName, Config.FormEntries.ValidEntries.LastName,
                                      Config.FormEntries.ValidEntries.CompanyName, Config.FormEntries.ValidEntries.EmailAddress,
                                      Config.FormEntries.ValidEntries.PhoneNumber, Config.FormEntries.ValidEntries.Subject1,
                                      Config.FormEntries.InvalidEntries.Message.BlankField);

            Actions.SubmitContactUsForm();

            FantooContactUsPage cuEmptyCompanyName = new FantooContactUsPage();

            Assert.AreEqual(Config.FormEntries.WarningMessagesEmptyContactUsForm.NoCompanyName, cuEmptyCompanyName.WarningNoCompanyName.Text);
        }

        [Test]
        public void OnlySpaceCharactersInMessage()
        {
            NavigateTo.NavigateToContactUsPage();

            Actions.ClearContactUsForm();

            Actions.FillContactUsForm(Config.FormEntries.ValidEntries.FirstName, Config.FormEntries.ValidEntries.LastName,
                                      Config.FormEntries.ValidEntries.CompanyName, Config.FormEntries.ValidEntries.EmailAddress,
                                      Config.FormEntries.ValidEntries.PhoneNumber, Config.FormEntries.ValidEntries.Subject1,
                                      Config.FormEntries.InvalidEntries.Message.OnlySpaceCharacters);

            Actions.SubmitContactUsForm();

            FantooContactUsPage cuEmptyCompanyName = new FantooContactUsPage();

            Assert.AreEqual(Config.FormEntries.WarningMessagesEmptyContactUsForm.NoCompanyName, cuEmptyCompanyName.WarningNoCompanyName.Text);
        }

        [Test]
        public void NoEmailAddress()
        {
            NavigateTo.NavigateToContactUsPage();

            Actions.ClearContactUsForm();

            Actions.FillContactUsForm(Config.FormEntries.ValidEntries.FirstName, Config.FormEntries.ValidEntries.LastName,
                                      Config.FormEntries.ValidEntries.CompanyName, Config.FormEntries.InvalidEntries.EmailAddress.BlankField,
                                      Config.FormEntries.ValidEntries.PhoneNumber, Config.FormEntries.ValidEntries.Subject1,
                                      Config.FormEntries.ValidEntries.Message);

            Actions.SubmitContactUsForm();

            FantooContactUsPage cuInvalidEmailMessage = new FantooContactUsPage();

            Assert.AreEqual(Config.FormEntries.WarningMessagesEmptyContactUsForm.NoEmailAddress, cuInvalidEmailMessage.WarningInvalidOrBlankEmail.Text);
        }

        [Test]
        public void OnlySpaceCharactersInEmailAddress()
        {
            NavigateTo.NavigateToContactUsPage();

            Actions.ClearContactUsForm();

            Actions.FillContactUsForm(Config.FormEntries.ValidEntries.FirstName, Config.FormEntries.ValidEntries.LastName,
                                      Config.FormEntries.ValidEntries.CompanyName, Config.FormEntries.InvalidEntries.EmailAddress.OnlySpaceCharacters,
                                      Config.FormEntries.ValidEntries.PhoneNumber, Config.FormEntries.ValidEntries.Subject1,
                                      Config.FormEntries.ValidEntries.Message);

            Actions.SubmitContactUsForm();

            FantooContactUsPage cuInvalidEmailMessage = new FantooContactUsPage();

            Assert.AreEqual(Config.FormEntries.WarningMessagesEmptyContactUsForm.NoEmailAddress, cuInvalidEmailMessage.WarningInvalidOrBlankEmail.Text);
        }

        [Test]
        public void InvalidEmailAddressLocalPartWithBlankSpace()
        {
            NavigateTo.NavigateToContactUsPage();

            Actions.ClearContactUsForm();

            Actions.FillContactUsForm(Config.FormEntries.ValidEntries.FirstName, Config.FormEntries.ValidEntries.LastName,
                                      Config.FormEntries.ValidEntries.CompanyName, Config.FormEntries.InvalidEntries.EmailAddress.LocalPartWithBlankSpace,
                                      Config.FormEntries.ValidEntries.PhoneNumber, Config.FormEntries.ValidEntries.Subject1,
                                      Config.FormEntries.ValidEntries.Message);

            Actions.SubmitContactUsForm();

            FantooContactUsPage cuInvalidEmailMessage = new FantooContactUsPage();

            Assert.AreEqual(Config.FormEntries.WarningMessagesEmptyContactUsForm.InvalidEmailWarningMessage, cuInvalidEmailMessage.WarningInvalidOrBlankEmail.Text);
        }

        [Test]
        public void InvalidEmailAddressMissingDomainPart()
        {
            NavigateTo.NavigateToContactUsPage();

            Actions.ClearContactUsForm();

            Actions.FillContactUsForm(Config.FormEntries.ValidEntries.FirstName, Config.FormEntries.ValidEntries.LastName,
                                      Config.FormEntries.ValidEntries.CompanyName, Config.FormEntries.InvalidEntries.EmailAddress.MissingDomainPart,
                                      Config.FormEntries.ValidEntries.PhoneNumber, Config.FormEntries.ValidEntries.Subject1,
                                      Config.FormEntries.ValidEntries.Message);

            Actions.SubmitContactUsForm();

            FantooContactUsPage cuInvalidEmailMessage = new FantooContactUsPage();

            Assert.AreEqual(Config.FormEntries.WarningMessagesEmptyContactUsForm.InvalidEmailWarningMessage, cuInvalidEmailMessage.WarningInvalidOrBlankEmail.Text);
        }

        [Test]
        public void InvalidEmailAddressMissingLocalPart()
        {
            NavigateTo.NavigateToContactUsPage();

            Actions.ClearContactUsForm();

            Actions.FillContactUsForm(Config.FormEntries.ValidEntries.FirstName, Config.FormEntries.ValidEntries.LastName,
                                      Config.FormEntries.ValidEntries.CompanyName, Config.FormEntries.InvalidEntries.EmailAddress.MissingLocalPart,
                                      Config.FormEntries.ValidEntries.PhoneNumber, Config.FormEntries.ValidEntries.Subject1,
                                      Config.FormEntries.ValidEntries.Message);

            Actions.SubmitContactUsForm();

            FantooContactUsPage cuInvalidEmailMessage = new FantooContactUsPage();

            Assert.AreEqual(Config.FormEntries.WarningMessagesEmptyContactUsForm.InvalidEmailWarningMessage, cuInvalidEmailMessage.WarningInvalidOrBlankEmail.Text);
        }

        [Test]
        public void InvalidEmailAddressMissingAtSymbol()
        {
            NavigateTo.NavigateToContactUsPage();

            Actions.ClearContactUsForm();

            Actions.FillContactUsForm(Config.FormEntries.ValidEntries.FirstName, Config.FormEntries.ValidEntries.LastName,
                                      Config.FormEntries.ValidEntries.CompanyName, Config.FormEntries.InvalidEntries.EmailAddress.MissingAtSymbol,
                                      Config.FormEntries.ValidEntries.PhoneNumber, Config.FormEntries.ValidEntries.Subject1,
                                      Config.FormEntries.ValidEntries.Message);

            Actions.SubmitContactUsForm();

            FantooContactUsPage cuInvalidEmailMessage = new FantooContactUsPage();

            Assert.AreEqual(Config.FormEntries.WarningMessagesEmptyContactUsForm.InvalidEmailWarningMessage, cuInvalidEmailMessage.WarningInvalidOrBlankEmail.Text);
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
