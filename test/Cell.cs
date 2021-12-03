using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Cell;
namespace CellTest
{
    [TestClass]
    public class CellTest
    {
        #region "Clear"
        [TestMethod]
        public void TestBoolClear()
        {
            Cell<bool> objTestCell = new Cell<bool>(true);
            if (objTestCell.Data == false)
            {
                throw new Exception("Failed to set value properly");
            }
            objTestCell.Clear();
            Assert.AreEqual(false, objTestCell.Data);
        }

        [TestMethod]
        public void TestDateClear()
        {
            Cell<DateTime> objTestCell = new Cell<DateTime>(new DateTime(2021, 11, 21));
            DateTime defaultDate = new DateTime(0001, 1, 1);
            if (objTestCell.Data == defaultDate)
            {
                throw new AssertFailedException("Failed to set value properly");
            }
            objTestCell.Clear();
            Assert.AreEqual(defaultDate, objTestCell.Data);
        }

        [TestMethod]
        public void TestDecimalClear()
        {
            Cell<decimal> objTestCell = new Cell<decimal>(12.00M);
            if (objTestCell.Data == 0.0M)
            {
                throw new AssertFailedException("Failed to set value properly");
            }

            objTestCell.Clear();
            Assert.AreEqual(0.0M, objTestCell.Data);
        }

        [TestMethod]
        public void TestDoubleClear()
        {
            Cell<double> objTestCell = new Cell<double>(12.00D);
            if (objTestCell.Data == 0.0D)
            {
                throw new AssertFailedException("Failed to set value properly");
            }

            objTestCell.Clear();
            Assert.AreEqual(0.0D, objTestCell.Data);
        }

        [TestMethod]
        public void TestFloatClear()
        {
            Cell<float> objTestCell = new Cell<float>(12.00F);
            if (objTestCell.Data == 0.0F)
            {
                throw new AssertFailedException("Failed to set value properly");
            }

            objTestCell.Clear();
            Assert.AreEqual(0.0F, objTestCell.Data);
        }

        [TestMethod]
        public void TestIntClear()
        {
            Cell<int> objTestCell = new Cell<int>(12);

            if (objTestCell.Data == 0)
            {
                throw new AssertFailedException("Failed to set value properly");
            }

            objTestCell.Clear();
            Assert.AreEqual(0, objTestCell.Data);
        }

        [TestMethod]
        public void TestLongClear()
        {
            Cell<long> objTestCell = new Cell<long>(12L);
            if (objTestCell.Data == 0L)
            {
                throw new AssertFailedException("Failed to set value properly");
            }

            objTestCell.Clear();
            Assert.AreEqual(0L, objTestCell.Data);
        }

        [TestMethod]
        public void TestShortClear()
        {
            Cell<short> objTestCell = new Cell<short>(12);
            if (objTestCell.Data == 0)
            {
                throw new AssertFailedException("Failed to set value properly");
            }

            objTestCell.Clear();
            Assert.AreEqual(0, objTestCell.Data);
        }

        [TestMethod]
        public void TestStringClear()
        {
            Cell<string> objTestCell = new Cell<string>("test");

            if (objTestCell.Data == string.Empty || objTestCell == null)
            {
                throw new AssertFailedException("Failed to set value properly");
            }

            objTestCell.Clear();
            Assert.AreEqual(null, objTestCell.Data);
        }
        #endregion

        #region "Set"
        [TestMethod]
        public void TestSetBoolValue()
        {
            Cell<bool> objTestCell = new Cell<bool>();
            objTestCell.SetValue(true);
            Assert.AreEqual(true, objTestCell.Data);
        }


        [TestMethod]
        public void TestSetDecimalValue()
        {
            Cell<decimal> objTestCell = new Cell<decimal>();
            objTestCell.SetValue(10.25M);
            Assert.AreEqual(10.25M, objTestCell.Data);
        }

        [TestMethod]
        public void TestSetDoubleValue()
        {
            Cell<double> objTestCell = new Cell<double>();
            objTestCell.SetValue(1000000000000000.25D);
            Assert.AreEqual(1000000000000000.25D, objTestCell.Data);
        }

        [TestMethod]
        public void TestSetFloatValue()
        {
            Cell<float> objTestCell = new Cell<float>();
            objTestCell.SetValue(1000000000000000.25F);
            Assert.AreEqual(1000000000000000.25F, objTestCell.Data);
        }

        [TestMethod]
        public void TestSetIntValue()
        {
            Cell<int> objTestCell = new Cell<int>();
            objTestCell.SetValue(16);
            Assert.AreEqual(16, objTestCell.Data);
        }

        [TestMethod]
        public void TestSetLongValue()
        {
            Cell<long> objTestCell = new Cell<long>();
            objTestCell.SetValue(125L);
            Assert.AreEqual(125L, objTestCell.Data);
        }

        [TestMethod]
        public void TestSetShortValue()
        {
            Cell<short> objTestCell = new Cell<short>();
            objTestCell.SetValue(16);
            Assert.AreEqual(16, objTestCell.Data);
        }

        [TestMethod]
        public void TestSetStringValue()
        {
            Cell<string> objTestCell = new Cell<string>();
            objTestCell.SetValue("test");
            Assert.AreEqual("test", objTestCell.Data);
        }
        #endregion
    }
}