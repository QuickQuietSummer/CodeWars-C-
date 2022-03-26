using CodeWars.Katas._26._03._2022;
using NUnit.Framework;

namespace CodeWars.Test.Tests._26._03._2022
{
    [TestFixture]
    public class StopGninnipsMySdrowTest
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual("emocleW", StopGninnipsMySdrow.SpinWords("Welcome"));
        }
  
        [Test]
        public static void Test2()
        {  
            Assert.AreEqual("Hey wollef sroirraw", StopGninnipsMySdrow.SpinWords("Hey fellow warriors"));
        }
  
        [Test]
        public static void Test3()
        {
            Assert.AreEqual("This is a test", StopGninnipsMySdrow.SpinWords("This is a test"));
        }
  
        [Test]
        public static void Test4()
        {
            Assert.AreEqual("This is rehtona test", StopGninnipsMySdrow.SpinWords("This is another test"));
        }
  
        [Test]
        public static void Test5()
        {
            Assert.AreEqual("You are tsomla to the last test", StopGninnipsMySdrow.SpinWords("You are almost to the last test"));
        }
  
        [Test]
        public static void Test6()
        {
            Assert.AreEqual("Just gniddik ereht is llits one more", StopGninnipsMySdrow.SpinWords("Just kidding there is still one more"));
        }
    }
}