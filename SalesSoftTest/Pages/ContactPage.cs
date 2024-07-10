
using OpenQA.Selenium;
using PageObjectLib.Elements;
using SalesSoftTest.Pages.InputFields.CreateContactInputFields;

namespace SalesSoftTest.Pages
{
    internal class ContactPage
    {
        private static WebElements NewContactButton() => new(By.XPath("//*[@title='New']"));
        private static WebElements ContactName() => new(By.XPath("//*[@slot='primaryField']"));

        public static AccountNameField AccountNameField = new();
        public static FirstNameField FirstNameField = new();
        public static LastNameField LastNameField = new();

        public static string GetContactName() => ContactName().GetText();
    }
}
