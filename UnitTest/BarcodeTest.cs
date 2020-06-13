using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace UnitTest
{
    [TestClass]
    public class BarcodeTest
    {
        [TestMethod]
        public void CreateBarcode_IsOk()
        {
            Barcode_6602 b = new Barcode_6602("25", 10, 5);

            Assert.AreEqual(b.batch, "25");
            Assert.AreEqual(b.count, 72);
            Assert.AreEqual(b.Roz, 10);

        }

        [TestMethod]
        public void GetSerial_IsOk()
        {
            Barcode_6602 b = new Barcode_6602("25", 10, 1);

            var t = b.getSerial(10);

            Assert.AreEqual(t, "BR01AH0100010");

        }
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void GetSerial_BiggerThanCount_IsOk()
        {
            Barcode_6602 b = new Barcode_6602("25", 10, 5);

            var t = b.getSerial(73);

        }

        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void GetSerial_Zero_IsOk()
        {
            Barcode_6602 b = new Barcode_6602("25", 10, 5);

            var t = b.getSerial(0);

        }
    }
}
