namespace PegSharp.Tests.External
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PegSharp.External;

    [TestClass]
    public class BlockDataTests
    {
        [TestMethod]
        public void CreateWithNumberHash()
        {
            var block = new BlockData();

            Assert.AreEqual(0, block.Number);
            Assert.IsNotNull(block.Hash);
            Assert.IsNotNull(block.Hash.Bytes);
            Assert.AreEqual(32, block.Hash.Bytes.Length);
            Assert.IsNull(block.ParentHash);
        }

        [TestMethod]
        public void CreateWithNumber()
        {
            var block = new BlockData(10);

            Assert.AreEqual(10, block.Number);
            Assert.IsNotNull(block.Hash);
            Assert.IsNotNull(block.Hash.Bytes);
            Assert.AreEqual(32, block.Hash.Bytes.Length);
        }

        [TestMethod]
        public void CreateWithNumberAndParentHash()
        {
            var parentHash = new Hash();
            var block = new BlockData(10, parentHash);

            Assert.AreEqual(10, block.Number);
            Assert.IsNotNull(block.Hash);
            Assert.IsNotNull(block.Hash.Bytes);
            Assert.AreEqual(32, block.Hash.Bytes.Length);
            Assert.IsNotNull(block.ParentHash);
            Assert.AreEqual(parentHash, block.ParentHash);
        }
    }
}
