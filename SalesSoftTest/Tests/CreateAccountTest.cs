using NUnit.Framework;
using OpenQA.Selenium;
using PageObjectLib.Factories;
using SalesSoftTest.Helpers;
using SalesSoftTest.Pages;
using SalesSoftTest.Pages.NavigateMenu;
using SeleniumExtras.WaitHelpers;

namespace SalesSoftTest.Tests
{
    internal class CreateAccountTest : BaseTest
    {
        [TestCase("MyAccount")]
        [TestCase("Second")]
        public void CreateAccountTest1(string accountName)
        {
            HomePage.AccountsButton.ClickMenuButton();
            Closer.CloseHomeTab();
            BaseNavigate.CreateNewItem();

            AccountPage.NameField.InputDataToField(accountName);
            AccountPage.SiteField.InputDataToField("site");
            AccountPage.TypeField.InputDataToField("Analyst");
            AccountPage.DescriptionField.InputDataToField("description");

            BaseNavigate.SaveEdit();

            Assert.That(accountName, Is.EqualTo(AccountPage.GetAccountName()));
        }
    }
}
