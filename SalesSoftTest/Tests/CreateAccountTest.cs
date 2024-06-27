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
        [Test]
        public void CreateAccountTest1()
        {
            HomePage.AccountsButton.ClickMenuButton();
            Closer.CloseHomeTab();
            AccountPage.CreateNewAccount();
            AccountPage.NameField.InputDataToField("name");
            AccountPage.SiteField.InputDataToField("site");
            AccountPage.DescriptionField.InputDataToField("description");
        }
    }
}
