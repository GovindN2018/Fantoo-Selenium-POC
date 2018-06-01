

namespace AutoTestFramework
{
    public static class Config
    {
        public static string BaseURL = "https://www.fantoo.com";

        public static class FormEntries
        {
            public static class ValidEntries
            {
                public static string FirstName = "Govind";
                public static string LastName = "Nayak";
                public static string CompanyName = "Fantoo Ltd.";
                public static string EmailAddress = "Govind@fantoo.net";
                public static string PhoneNumber = "0123456789";
                public static string Subject1 = "I’d like to find out more about your product";
                public static string Subject2 = "I’d like to become a partner";
                public static string Subject3 = "Other";
                public static string Message = "Please ignore this contact request. This is just for testing Fantoo website.";
                public static string SuccessMessage = "Thank you for getting in contact,";
            }

            public static class InvalidEntries
            {
                public static class FirstName
                {
                    public static string BlankField = ""; // expected warning: "This is a required field"
                    public static string OnlySpaceCharacters = "     "; // expected warning: "This is a required field"
                    //public static string OnlyNumericCharacters = "1234567890";
                    //public static string OnlySpecialCharacters = "¬!\"£$%^&*()_+";
                }

                public static class LastName
                {
                    public static string BlankField = ""; // expected warning: "This is a required field"
                    public static string OnlySpaceCharacters = "     "; // expected warning: "This is a required field"
                    //public static string OnlyNumericCharacters = "1234567890";
                    //public static string OnlySpecialCharacters = "¬!\"£$%^&*()_+";
                }

                public static class CompanyName
                {
                    public static string BlankField = ""; // expected warning: "This is a required field"
                    public static string OnlySpaceCharacters = "     "; // expected warning: "This is a required field"
                    //public static string OnlyNumericCharacters = "1234567890";
                    //public static string OnlySpecialCharacters = "¬!\"£$%^&*()_+";
                }

                public static class EmailAddress
                {
                    public static string BlankField = ""; // expected warning: "This is a required field"
                    public static string OnlySpaceCharacters = "     "; // expected warning: "This is a required field"
                    public static string LocalPartWithBlankSpace = "Gov ind@fantoo.net"; // expected warning: "You have not given a correct e-mail address"
                    public static string MissingDomainPart = "abc"; // expected warning: "You have not given a correct e-mail address"
                    public static string MissingLocalPart = "@fantoo.net"; // expected warning: "You have not given a correct e-mail address"
                    public static string MissingAtSymbol = "abcfantoo.net"; // expected warning: "You have not given a correct e-mail address"
                }

                //public static class PhoneNumber
                //{
                //    public static string BlankField = "";
                //    public static string OnlySpaceCharacters = "     ";
                //    public static string OnlyAlphabeticCharacters = "qwerty";
                //}

                public static class Subject
                {
                    public static string NoSelection = "Select an option"; // expected warning: "This is a required field"
                }

                public static class Message
                {
                    public static string BlankField = ""; // expected warning: "This is a required field"
                    public static string OnlySpaceCharacters = "     "; // expected warning: "This is a required field"
                }
            }

            public static class WarningMessagesEmptyContactUsForm
            {
                public static string NoFirstName = "This is a required field";
                public static string NoLastName = "This is a required field";
                public static string NoCompanyName = "This is a required field";
                public static string NoEmailAddress = "This is a required field";
                public static string InvalidEmailWarningMessage = "You have not given a correct e-mail address";
                //public static string PhoneNumber = "This is a required field";
                public static string NoSubject = "This is a required field";
                public static string NoMessage = "This is a required field";

                
            }

        }
    }
}
