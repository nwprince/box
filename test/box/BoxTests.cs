using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using box;

namespace box.Tests
{
    [TestClass()]
    public class BoxTests
    {
        [TestMethod()]
        public void AddIntColumnTest()
        {
            Box box = new Box();
            if (box == null)
            {
                throw new Exception("Failed to create box object");
            }
            box.AddIntColumn("pintTestColumn");
            Assert.AreEqual(1, box.ColumnCount());
        }

        [TestMethod()]
        public void ContainsColumnTest()
        {
            Box testbox = new Box();
            if (testbox == null)
            {
                throw new Exception("Failed to create box object");
            }

            testbox.AddBooleanColumn("pbooleanTestColumn");
            Assert.IsTrue(testbox.ColumnExists("pbooleanTestColumn"));
        }
    }
}