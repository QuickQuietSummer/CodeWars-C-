using CodeWars.Katas._25._03._2022;
using NUnit.Framework;

namespace CodeWars.Test.Tests._25._03._2022
{
    [TestFixture]
    public class SumOfOddNumbersTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, SumOfOddNumbers.RowSumOddNumbers(1));
            Assert.AreEqual(8, SumOfOddNumbers.RowSumOddNumbers(2));
            Assert.AreEqual(27, SumOfOddNumbers.RowSumOddNumbers(3));
            Assert.AreEqual(74088, SumOfOddNumbers.RowSumOddNumbers(42));
        }
    }
}