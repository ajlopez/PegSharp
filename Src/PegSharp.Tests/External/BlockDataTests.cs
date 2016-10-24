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
        }
    }
}
