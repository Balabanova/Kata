using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata1_palindrome
{
    [TestClass]
    public class PalindromeTests
    {
        [TestMethod]
        public void StringIsNull()
        {
            string str = null;
            try
            {
                var result = str.IsPalindrome();
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual("value", e.ParamName);
            }
           
        }

        [TestMethod]
        public void StringIsEmpty()
        {
            var str = "";
            var result = str.IsPalindrome();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void StringContainsOneLetter()
        {
            var str = "a";
            var result = str.IsPalindrome();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NotPalindrome()
        {
            var str = "abcdefg";
            var result = str.IsPalindrome();
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void NotSimplePalindrome()
        {
            var str = "ab";
            var result = str.IsPalindrome();
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsShortPalindrome()
        {
            var str = "aba";
            var result = str.IsPalindrome();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsLongPalindrome()
        {
            var str = "levellevellevel";
            var result = str.IsPalindrome();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindromeWithRegister()
        {
            var str = "Shahs";
            var result = str.IsPalindrome();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindromeWithPunctuation()
        {
            var str = "Was it a car or a cat I saw?";
            var result = str.IsPalindrome();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindromeWithPunctuationRussianAndHard()
        {
            var str = "А бензин - о! - течет он из неба.";
            var result = str.IsPalindrome();
            Assert.IsTrue(result);
        }
    }
}
