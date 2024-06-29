using SalesSoftTest.Helpers;
using SalesSoftTest.Pages.NavigateMenu;
using SalesSoftTest.Pages;

namespace SalesSoftTest.Tests
{
    internal class CreateContactTest : BaseTest
    {
        [TestCase("MyContact")]
        [TestCase("My Second")]
        public void CreateContactTest1(string accountName)
        {
            HomePage.ContactsButton.ClickMenuButton();
            Closer.CloseHomeTab();
            BaseNavigate.CreateNewItem();



            BaseNavigate.SaveEdit();

            Assert.That(accountName, Is.EqualTo(AccountPage.GetAccountName()));
        }
    }
}
