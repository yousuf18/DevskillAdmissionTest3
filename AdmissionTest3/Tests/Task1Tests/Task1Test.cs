using NUnit.Framework;
using Task1;

namespace Task1Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("I Love Bangladesh", "a-2, e-2, i-1, o-1, u-0")]
        [TestCase("You are an honest man", "a-3, e-2, i-0, o-2, u-1")]
        [TestCase("IT IS MY DUTY TO SERVE MY COUNTRY", "a-0, e-2, i-2, o-2, u-2")]
        public void Test1(string text, string result)
        {
            VowelCounter vowelCounter = new VowelCounter();
            var actualResult = vowelCounter.GetCounts(text);

            Assert.AreEqual(result, actualResult);
        }
    }
}