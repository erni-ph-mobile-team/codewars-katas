using NUnit.Framework;

namespace SumStringsAsNumbers.Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("579", Solution.SumStrings("123", "456"));
            
        }
    }
}