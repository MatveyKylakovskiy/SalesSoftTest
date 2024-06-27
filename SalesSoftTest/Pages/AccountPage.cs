using OpenQA.Selenium;
using PageObjectLib.Elements;
using SalesSoftTest.Pages.CreateAccountInputFields;

namespace SalesSoftTest.Pages
{
    internal class AccountPage
    {
        private static WebElements NewAccountButton() => new(By.XPath("//*[@title='New']"));
        //private static WebElements SaveEditButton() => new(By.XPath("//*[@name='SaveEdit']"));
        private static WebElements SaveEditButton() => new(By.XPath("//*[@variant='brand']"));
        private static WebElements AccountName() => new(By.XPath("//*[@slot='primaryField']"));

        public static NameField NameField = new();
        public static WebsiteField SiteField = new();
        public static DescriptionField DescriptionField = new();
        public static BillingStritField BillingStritField = new();
        public static TypeField TypeField = new();

        public static void CreateNewAccount() => NewAccountButton().Click();
        public static void SaveAccount() => SaveEditButton().Click();
        public static string GetAccountName() => AccountName().GetText();
    }
}
