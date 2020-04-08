using DZ3_AddToCard.PageObject;
using NUnit.Framework;

namespace DZ3_AddToCard.Tests
{
    [TestFixture]
    public class AddToCartTest : BaseTest
    {
        private Header _header;
            
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _header = new Header(Driver);
            
        }

        [TestCase(true)]
        [TestCase(false)]
        public void ToCart(bool isCorrect)
        {
            bool isSmthInCart = _header.addingToCart().isAddingOk();
            
            Assert.That(isSmthInCart, Is.EqualTo(isCorrect), 
                $"Searching works {(isSmthInCart ? "successfully" : "unsuccessfully")}"+$", but we expected opposite");

        } 
    }
}