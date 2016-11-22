namespace PegSharp.Tests.External
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PegSharp.External;

    [TestClass]
    public class TransactionDataTests
    {
        [TestMethod]
        public void CreateWithHash()
        {
            var data = new TransactionData();

            Assert.IsNotNull(data.Hash);
        }

        [TestMethod]
        public void Equals()
        {
            var tx1 = new TransactionData();
            var tx2 = new TransactionData(tx1.Hash);
            var tx3 = new TransactionData();

            Assert.AreEqual(tx1, tx2);
            Assert.AreEqual(tx2, tx1);
            Assert.AreNotEqual(tx1, tx3);
            Assert.AreNotEqual(tx1, 42);
            Assert.AreNotEqual(tx1, "foo");

            Assert.AreEqual(tx1.GetHashCode(), tx2.GetHashCode());
        }
    }
}
