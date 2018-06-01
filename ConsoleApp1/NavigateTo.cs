namespace AutoTestFramework
{
    using AutoTestFramework.Pages.PageElements;

    public static class NavigateTo
    {
        public static void NavigateToHomePage()
        {
            Menu menu = new Menu();

            menu.LinkLeftLogo.Click();
        }

        public static void NavigateToProductPage()
        {
            Menu menu = new Menu();

            menu.LinkProduct.Click();
        }

        public static void NavigateToAboutPage()
        {
            Menu menu = new Menu();

            menu.LinkAbout.Click();
        }

        public static void NavigateToContactUsPage()
        {
            Menu menu = new Menu();

            menu.LinkContactUs.Click();
        }

        public static void NavigateToFreeTrialPage()
        {
            Menu menu = new Menu();

            menu.BtnFreeTrial.Click();
        }





    }
}
