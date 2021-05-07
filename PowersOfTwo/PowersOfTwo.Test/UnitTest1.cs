using System.Numerics;
using NUnit.Framework;

namespace PowersOfTwo.Test
{
    public class Tests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new BigInteger[] { 1 }, Solution.PowersOfTwo(0));
            Assert.AreEqual(new BigInteger[] { 1, 2 }, Solution.PowersOfTwo(1));
            Assert.AreEqual(new BigInteger[] { 1, 2, 4, 8, 16 }, Solution.PowersOfTwo(4));
        }
    }
}