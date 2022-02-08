using NUnit.Framework;
using Mine.Models;

namespace UnitTests.Models
{
    [TestFixture]
    public class HomeMenuItemTests
    {
        [Test]
        public void MenuItem_Constructor_Valid_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new HomeMenuItem();
            // Reset

            // Assert 
            Assert.IsNotNull(result);
        }

        [Test]
        public void MenuItem_Set_Get_Valid_Default_Should_Pass()
        {
            //Arrange

            //Act
            var result = new HomeMenuItem();
            result.Id = MenuItemType.Items;
            result.Title = "Title";
            //Reset

            //Assert
            Assert.AreEqual(MenuItemType.Items, result.Id);
            Assert.AreEqual("Title", result.Title);
        }
    }
}