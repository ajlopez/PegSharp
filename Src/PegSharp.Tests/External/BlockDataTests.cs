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

        [TestMethod]
        public void CreateWithParent()
        {
            var parent = new BlockData(10);
            var block = new BlockData(parent);

            Assert.AreEqual(11, block.Number);
            Assert.IsNotNull(block.Hash);
            Assert.IsNotNull(block.Hash.Bytes);
            Assert.AreEqual(32, block.Hash.Bytes.Length);
            Assert.IsNotNull(block.ParentHash);
            Assert.AreEqual(parent.Hash, block.ParentHash);
        }

        [TestMethod]
        public void Equals()
        {
            var block1 = new BlockData();
            var block2 = new BlockData(block1.Hash);
            var block3 = new BlockData();

            Assert.AreEqual(block1, block2);
            Assert.AreEqual(block2, block1);
            Assert.AreNotEqual(block1, block3);
            Assert.AreNotEqual(block1, 42);
            Assert.AreNotEqual(block1, "foo");

            Assert.AreEqual(block1.GetHashCode(), block2.GetHashCode());
        }
    }
}
