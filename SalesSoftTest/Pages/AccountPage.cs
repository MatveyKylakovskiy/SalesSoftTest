using OpenQA.Selenium;
using PageObjectLib.Elements;
using SalesSoftTest.Pages.CreateAccountInputFields;

namespace SalesSoftTest.Pages
{
    internal class AccountPage
    {
        private static WebElements NewAccountButton() => new(By.XPath("//*[@title='New']"));

        public static void CreateNewAccount() => NewAccountButton().Click();

        public static NameField NameField = new();
        public static WebsiteField SiteField = new();
        public static DescriptionField DescriptionField = new();
    }
}
