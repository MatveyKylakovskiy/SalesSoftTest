using SalesSoftTest.Helpers;
using SalesSoftTest.Pages.NavigateMenu;
using SalesSoftTest.Pages;
using SalesSoftTest.Pages.InputFields.CreateContactInputFields;

namespace SalesSoftTest.Tests
{
    internal class CreateContactTest : BaseTest
    {
        [TestCase("User", "Test", "fghsd")]
        [TestCase("User2", "Test2", "fghsd")]
        public void CreateContactTest1(string firstName, string lastName, string accountName)
        {
            HomePage.ContactsButton.ClickMenuButton();
            Closer.CloseHomeTab();
            BaseNavigate.CreateNewItem();

            ContactPage.AccountNameField.InputDataToField(accountName);
            ContactPage.FirstNameField.InputDataToField(firstName);
            ContactPage.LastNameField.InputDataToField(lastName);

            BaseNavigate.SaveEdit();

            Assert.That($"{firstName} {lastName}", Is.EqualTo(ContactPage.GetContactName()));
        }
    }
}
