using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Line; 

namespace LineTest
{
    [TestClass]
    public class LineTest
    {
        [TestMethod]
        public void TestNewDefaultBoolLine()
        {
            Line<bool> testLine = new Line<bool>("pbooleanTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell();
            Assert.AreEqual(1, testLine.CellCount());
        }

        [TestMethod]
        public void TestNewMultiDefaultBoolLine()
        {
            Line<bool> testLine = new Line<bool>("pbooleanTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell();
            Assert.AreEqual(1, testLine.CellCount());

            testLine.AddCell();
            Assert.AreEqual(2, testLine.CellCount());
        }

        [TestMethod]
        public void TestNewValuedBoolLine()
        {
            Line<bool> testLine = new Line<bool>("pbooleanTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell(true);
            Assert.AreEqual(true, testLine.CellData());
        }

        [TestMethod]
        public void TestNewMultiValuedBoolLine()
        {
            Line<bool> testLine = new Line<bool>("pbooleanTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell(true);
            Assert.AreEqual(true, testLine.CellData());

            testLine.AddCell(false);
            Assert.AreEqual(false, testLine.CellData());
        }

        [TestMethod]
        public void TestNewDefaultDateTimeLine()
        {
            Line<DateTime> testLine = new Line<DateTime>("pdatetimeTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell();
            Assert.AreEqual(1, testLine.CellCount());
        }

        [TestMethod]
        public void TestNewMultiDefaultDateTimeLine()
        {
            Line<DateTime> testLine = new Line<DateTime>("pdatetimeTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell();
            Assert.AreEqual(1, testLine.CellCount());

            testLine.AddCell();
            Assert.AreEqual(2, testLine.CellCount());
        }

        [TestMethod]
        public void TestNewValuedDateTimeLine()
        {
            Line<DateTime> testLine = new Line<DateTime>("pdatetimeTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell(new DateTime(2021, 11, 21));
            Assert.AreEqual(new DateTime(2021, 11, 21), testLine.CellData());
        }

        [TestMethod]
        public void TestNewMultiValuedDateTimeLine()
        {
            Line<DateTime> testLine = new Line<DateTime>("pdatetimeTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell(new DateTime(2021, 11, 21));
            Assert.AreEqual(new DateTime(2021, 11, 21), testLine.CellData());

            testLine.AddCell(new DateTime(2021, 11, 22));
            Assert.AreEqual(new DateTime(2021, 11, 22), testLine.CellData());
        }

        [TestMethod]
        public void TestNewMultiDefaultDecimalLine()
        {
            Line<decimal> testLine = new Line<decimal>("pdecimalTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell();
            Assert.AreEqual(1, testLine.CellCount());

            testLine.AddCell();
            Assert.AreEqual(2, testLine.CellCount());
        }

        [TestMethod]
        public void TestNewValuedDecimalLine()
        {
            Line<decimal> testLine = new Line<decimal>("pdecimalTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell(12.00M);
            Assert.AreEqual(12.00M, testLine.CellData());
        }

        [TestMethod]
        public void TestNewMultiValuedDecimalLine()
        {
            Line<decimal> testLine = new Line<decimal>("pdecimalTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell(12.00M);
            Assert.AreEqual(12.00M, testLine.CellData());

            testLine.AddCell(13.00M);
            Assert.AreEqual(13.00M, testLine.CellData());
        }

        [TestMethod]
        public void TestNewMultiDefaultDoubleLine()
        {
            Line<Double> testLine = new Line<Double>("pdoubleTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell();
            Assert.AreEqual(1, testLine.CellCount());

            testLine.AddCell();
            Assert.AreEqual(2, testLine.CellCount());
        }

        [TestMethod]
        public void TestNewValuedDoubleLine()
        {
            Line<Double> testLine = new Line<Double>("pdoubleTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell(12.00D);
            Assert.AreEqual(12.00D, testLine.CellData());
        }

        [TestMethod]
        public void TestNewMultiValuedDoubleLine()
        {
            Line<Double> testLine = new Line<Double>("pdoubleTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell(12.00D);
            Assert.AreEqual(12.00D, testLine.CellData());

            testLine.AddCell(13.00D);
            Assert.AreEqual(13.00D, testLine.CellData());
        }

        [TestMethod]
        public void TestNewMultiDefaultFloatLine()
        {
            Line<float> testLine = new Line<float>("pfloatTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell();
            Assert.AreEqual(1, testLine.CellCount());

            testLine.AddCell();
            Assert.AreEqual(2, testLine.CellCount());
        }

        [TestMethod]
        public void TestNewValuedFloatLine()
        {
            Line<float> testLine = new Line<float>("pfloatTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell(12.00F);
            Assert.AreEqual(12.00F, testLine.CellData());
        }

        [TestMethod]
        public void TestNewMultiValuedFloatLine()
        {
            Line<float> testLine = new Line<float>("pfloatTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell(12.00F);
            Assert.AreEqual(12.00F, testLine.CellData());

            testLine.AddCell(13.00F);
            Assert.AreEqual(13.00F, testLine.CellData());
        }

        [TestMethod]
        public void TestNewMultiDefaultIntLine()
        {
            Line<int> testLine = new Line<int>("pintTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell();
            Assert.AreEqual(1, testLine.CellCount());

            testLine.AddCell();
            Assert.AreEqual(2, testLine.CellCount());
        }

        [TestMethod]
        public void TestNewValuedIntLine()
        {
            Line<int> testLine = new Line<int>("pintTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell(12);
            Assert.AreEqual(12, testLine.CellData());
        }

        [TestMethod]
        public void TestNewMultiValuedIntLine()
        {
            Line<int> testLine = new Line<int>("pintTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell(12);
            Assert.AreEqual(12, testLine.CellData());

            testLine.AddCell(13);
            Assert.AreEqual(13, testLine.CellData());
        }

        [TestMethod]
        public void TestNewMultiDefaultLongLine()
        {
            Line<long> testLine = new Line<long>("plongTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell();
            Assert.AreEqual(1, testLine.CellCount());

            testLine.AddCell();
            Assert.AreEqual(2, testLine.CellCount());
        }

        [TestMethod]
        public void TestNewValuedLongLine()
        {
            Line<long> testLine = new Line<long>("plongTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell(12L);
            Assert.AreEqual(12L, testLine.CellData());
        }

        [TestMethod]
        public void TestNewMultiValuedLongLine()
        {
            Line<long> testLine = new Line<long>("plongTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell(12L);
            Assert.AreEqual(12L, testLine.CellData());

            testLine.AddCell(13L);
            Assert.AreEqual(13L, testLine.CellData());
        }

        [TestMethod]
        public void TestNewMultiDefaultShortLine()
        {
            Line<short> testLine = new Line<short>("pshortTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell();
            Assert.AreEqual(1, testLine.CellCount());

            testLine.AddCell();
            Assert.AreEqual(2, testLine.CellCount());
        }

        [TestMethod]
        public void TestNewValuedShortLine()
        {
            Line<short> testLine = new Line<short>("pshortTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell(12);
            Assert.AreEqual(12, testLine.CellData());
        }

        [TestMethod]
        public void TestNewMultiValuedShortLine()
        {
            Line<short> testLine = new Line<short>("pshortTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell(12);
            Assert.AreEqual(12, testLine.CellData());

            testLine.AddCell(13);
            Assert.AreEqual(13.00M, testLine.CellData());
        }

        [TestMethod]
        public void TestNewMultiDefaultStringLine()
        {
            Line<string> testLine = new Line<string>("pstringTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell();
            Assert.AreEqual(1, testLine.CellCount());

            testLine.AddCell();
            Assert.AreEqual(2, testLine.CellCount());
        }

        [TestMethod]
        public void TestNewValuedStringLine()
        {
            Line<string> testLine = new Line<string>("pstringTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell("test");
            Assert.AreEqual("test", testLine.CellData());
        }

        [TestMethod]
        public void TestNewMultiValuedStringLine()
        {
            Line<string> testLine = new Line<string>("pstringTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddCell("test");
            Assert.AreEqual("test", testLine.CellData());

            testLine.AddCell("testing");
            Assert.AreEqual("testing", testLine.CellData());
        }

        [TestMethod]
        public void TestCellCount()
        {
            Line<bool> testLine = new Line<bool>("pbooleanTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            for (int i = 0; i < 500; i++)
            {
                testLine.AddCell();
                Assert.AreEqual(i + 1, testLine.CellCount());
            }
        }

        [TestMethod]
        public void TestAddMultipleCells()
        {
            Line<int> testLine = new Line<int>("pintTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddMultipleCells(500);
            Assert.AreEqual(500, testLine.CellCount());
        }

        [TestMethod]
        public void TestAddMultipleValuedCells()
        {
            Line<int> testLine = new Line<int>("pintTestLine");
            if (testLine == null)
            {
                throw new Exception("Failed to initialize a line object properly");
            }

            testLine.AddMultipleCells(500, 10);
            Assert.AreEqual(500, testLine.CellCount());
            testLine.FocusCell(0);
            for (int i = 0; i < 500; i++)
            {
                Assert.AreEqual(10, testLine.CellData());
                testLine.FocusNext();
            }
        }
    }
}