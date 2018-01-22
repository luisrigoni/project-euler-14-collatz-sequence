using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exe1.Tests
{
    [TestClass]
    public class CollatzGeneratorTest
    {
        [TestMethod]
        public void CollatzGenerator_GenerateSequence_StartingWith13()
        {
            var seq = CollatzGenerator.GenerateSequence(13).ToList();

            Assert.AreEqual(10, seq.Count);
            Assert.IsTrue(seq.SequenceEqual(new ulong[] { 13, 40, 20, 10, 5, 16, 8, 4, 2, 1 }));
        }

        [TestMethod]
        public void CollatzGenerator_GenerateSequence_StartingWith837799()
        {
            var seq = CollatzGenerator.GenerateSequence(837799);

            //Assert.AreEqual(524, seq.Count()); // https://en.wikipedia.org/wiki/Collatz_conjecture
            Assert.AreEqual(525, seq.Count()); // http://www.mathblog.dk/project-euler-14/
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CollatzGenerator_GenerateSequence_StartingWithZero()
        {
            var seq = CollatzGenerator.GenerateSequence(0).ToList();

            Assert.Fail();
        }

        [TestMethod]
        public void CollatzGenerator_GenerateSequence_StartingWith1()
        {
            var seq = CollatzGenerator.GenerateSequence(1).ToList();

            Assert.AreEqual(1, seq.Count);
            Assert.IsTrue(seq.SequenceEqual(new ulong[] { 1 }));
        }
    }
}
