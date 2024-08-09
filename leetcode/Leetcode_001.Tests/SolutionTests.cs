using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode_001.Tests
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        public void IsPalindrome_CheckingnumberIspalindrome_True()
        {
            int value = 12321;
            Solution s = new Solution();
            Assert.IsTrue(s.IsPalindrome(value));
        }

        [TestMethod]
        public void IsPalindrome_CheckingnumberIspalindrome_False()
        {
            int value = 12325;
            Solution s = new Solution();
            Assert.IsFalse(s.IsPalindrome(value));
        }
    }
}
