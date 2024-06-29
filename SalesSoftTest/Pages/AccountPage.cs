using OpenQA.Selenium;
using PageObjectLib.Elements;
using PageObjectLib.Factories;
using SalesSoftTest.Pages.InputFields.CreateAccountInputFields;
using SalesSoftTest.Pages.NavigateMenu;
using SeleniumExtras.WaitHelpers;

namespace SalesSoftTest.Pages
{
    internal class AccountPage
    {
        private static WebElements AccountName() => new(By.XPath("//*[@slot='primaryField']"));

        public static NameField NameField = new();
        public static WebsiteField SiteField = new();
        public static DescriptionField DescriptionField = new();
        public static BillingStritField BillingStritField = new();
        public static TypeField TypeField = new();
        
        public static string GetAccountName() => AccountName().GetText();
    }
}
