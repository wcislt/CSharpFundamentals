using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Test.Types
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void UpperCaseString()
        {
            string name = "Tom";

            name = name.ToUpper();

            Assert.AreEqual("TOM", name);
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2017, 7, 11);
            date = date.AddDays(1);

            Assert.AreEqual(12, date.Day);
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 69;
            // ref keyword passes variable by reference instead of pass by value
            IncrementInteger(ref x);

            Assert.AreEqual(70, x);
        }

        private void IncrementInteger(ref int num)
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
