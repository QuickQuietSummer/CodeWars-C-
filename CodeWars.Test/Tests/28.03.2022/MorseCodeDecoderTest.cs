using System;
using CodeWars.Katas._28._03._2022;
using NUnit.Framework;

namespace CodeWars.Test.Tests._28._03._2022
{
    [TestFixture]
    public class MorseCodeDecoderTest
    {
        [Test]
        public void MorseCodeDecoderBasicTest_1()
        {
            try
            {
                string input = ".... . -.--   .--- ..- -.. .";
                string expected = "HEY JUDE";

                string actual = MorseCodeDecoder.Decode(input);

                Assert.AreEqual(expected, actual);
            }
            catch(Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }
    }
}