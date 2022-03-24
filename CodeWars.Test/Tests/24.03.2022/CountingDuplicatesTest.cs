using CodeWars.Katas._24._03._2022;
using NUnit.Framework;

namespace CodeWars.Test.Tests._24._03._2022
{
    [TestFixture]
    public class CountingDuplicatesTest
    {
        [Test]
        public void KataTests()
        {
            Assert.AreEqual(0, CountingDuplicates.DuplicateCount(""));
            Assert.AreEqual(0, CountingDuplicates.DuplicateCount("abcde"));
            Assert.AreEqual(2, CountingDuplicates.DuplicateCount("aabbcde"));
            Assert.AreEqual(2, CountingDuplicates.DuplicateCount("aabBcde"), "should ignore case");
            Assert.AreEqual(1, CountingDuplicates.DuplicateCount("Indivisibility"));
            Assert.AreEqual(2, CountingDuplicates.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
            Assert.AreEqual(8, CountingDuplicates.DuplicateCount("165180178190178180184179180178181187165188163188177182183193"));
        }
    }
}