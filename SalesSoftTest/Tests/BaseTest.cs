using PageObjectLib.Factories;
using SalesSoftTest.Pages;

namespace SalesSoftTest.Tests
{
    internal class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.GoUrl("https://saas-saas-9809.lightning.force.com/lightning/page/home");
            BasePage.Login("egoaesu-ldqe@force.com", "7Wy7cm2ZAM9qRKS№%");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
