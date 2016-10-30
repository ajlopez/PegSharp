namespace PegSharp.Tests.External
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PegSharp.External;

    [TestClass]
    public class MainChainProviderTests
    {
        [TestMethod]
        public void EmptyMainChain()
        {
            var chain = new MainChainProvider();

            Assert.AreEqual(0, chain.Height);
        }

        [TestMethod]
        public void AddGenesisBlock()
        {
            var chain = new MainChainProvider();
            var block = new BlockData(0);

            chain.Add(block);

            Assert.AreEqual(1, chain.Height);
            Assert.AreSame(block, chain.GetBlockData(0));
        }
    }
}
