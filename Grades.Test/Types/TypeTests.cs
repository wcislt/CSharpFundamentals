using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Test.Types
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 69;
            IncrementInteger(x);

            Assert.AreEqual(69, x);
        }

        private void IncrementInteger(int num)
        {
            num++;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("Tom's Book", book1.Name);
        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "Tom's Book";
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Tom";
            string name2 = "tom";

            Assert.IsTrue(string.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase));
        }

        [TestMethod]
        public void IntVariablesHoldValues()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 200;

            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBookVariablesHoldReferences()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Test grade book";
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
