using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD01.Tests
{
    [TestClass()]
    public class ArraysTests
    {
        [TestMethod()]
        public void CheckIfPalindrome_ReturnsFalse_IfWordIsNotPalindrome()
        {
            var result = Arrays.CheckIfPalindrome("kar");
            Assert.AreEqual(false, result);
        }
        [TestMethod()]
        public void CheckIfPalindrome_ReturnsTrue_IfWordIsPalindrome()
        {
            var result = Arrays.CheckIfPalindrome("rar");
            Assert.AreEqual(true, result);
        }
    }
}