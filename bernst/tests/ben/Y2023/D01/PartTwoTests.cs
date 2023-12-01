using System.Security.Cryptography;

namespace tests.ben.Y2023.D01
{
    [TestClass]
    public class PartTwoTests
    {
        [TestMethod]
        public void FirstRealDigitOnLine()
        {
            var digit = BusinessLogicPartTwo.FirstDigit("xtwone3four");
            Assert.AreEqual(2, digit);
        }
        [TestMethod]
        public void FirstDigit()
        {
            var digit = BusinessLogicPartTwo.FirstDigit("two");
            Assert.AreEqual(2, digit);
        }
        [TestMethod]
        public void LastDigit()
        {
            Assert.AreEqual(2, BusinessLogicPartTwo.LastDigit("2"));
            Assert.AreEqual(3, BusinessLogicPartTwo.LastDigit("three"));
            Assert.AreEqual(4, BusinessLogicPartTwo.LastDigit("a4"));
            Assert.AreEqual(5, BusinessLogicPartTwo.LastDigit("5a"));
        }
        
        [TestMethod]
        public void DecryptLine()
        {
            var decrypted = BusinessLogicPartTwo.DecryptLine("pqr3stu8vwx");
            Assert.AreEqual(38, decrypted);
        }
        
        [TestMethod]
        public void IsNextCharacterRequiredReverse()
        {
            var test_entry = new Entry("key", 1);
            
            Assert.IsTrue(BusinessLogicPartTwo.IsNextCharacterRequiredReverse('y', test_entry));
            Assert.IsFalse(BusinessLogicPartTwo.IsNextCharacterRequiredReverse('k', test_entry));
        }

        [TestMethod]
        public void IsNextCharacterRequired()
        {
            var test_entry = new Entry("key", 1);
            
            Assert.IsTrue(BusinessLogicPartTwo.IsNextCharacterRequired('k', test_entry));
            Assert.IsFalse(BusinessLogicPartTwo.IsNextCharacterRequired('y', test_entry));
        }

        /// <summary>
        /// Solve the puzzle using the example data
        /// </summary>
        [TestMethod]
        public void SolutionExampleData()
        {
            var solution = BusinessLogicPartTwo.Solution(TestData.PartTwoExample);
            Assert.AreEqual(281, solution);
        }

        /// <summary>
        /// Solve the puzzle using the personalized data set.
        /// </summary>
        [TestMethod]
        public void SolutionMyData()
        {
            var solution = BusinessLogicPartTwo.Solution(TestData.MyData);
            Assert.AreEqual(53221, solution);
        }
    }
}