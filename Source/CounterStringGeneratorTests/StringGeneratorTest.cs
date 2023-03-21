using CounterStringGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CounterStringGeneratorTests
{
    [TestClass]
    public class StringGeneratorTest
    {
        [TestMethod]
        public void Zero_length_generates_empty_string()
        {
            Assert.AreEqual("", new StringGenerator().Generate(-1, '_'));
            Assert.AreEqual("", new StringGenerator().Generate(0, '_'));
        }

        [TestMethod]
        public void Shortest_string_without_special_character()
        {
            Assert.AreEqual("2", new StringGenerator().Generate(1, '_'));
        }

        [TestMethod]
        public void First_string_with_special_character()
        {
            Assert.AreEqual("2_", new StringGenerator().Generate(2, '_'));
        }

        [TestMethod]
        public void First_change_of_number_length()
        {
            Assert.AreEqual("2_4_6_8_11_", new StringGenerator().Generate(11, '_'));
        }

        [TestMethod]
        public void SameSpecialChars()
        {
            StringGenerator generator = new StringGenerator();
            Assert.AreEqual("2_", generator.Generate(2, '_'));
            Assert.AreEqual("2_4_", generator.Generate(4, '_'));
        }

        [TestMethod]
        public void DifferentSpecialChars()
        {
            StringGenerator generator = new StringGenerator();
            Assert.AreEqual("2_", generator.Generate(2, '_'));
            Assert.AreEqual("2-4-", generator.Generate(4, '-'));
        }
    }
}
