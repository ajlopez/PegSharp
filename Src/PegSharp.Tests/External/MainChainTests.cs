namespace PegSharp.Tests.External
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PegSharp.External;

    [TestClass]
    public class MainChainTests
    {
        [TestMethod]
        public void CreateEmptyMainChain()
        {
            var chain = new MainChain();

            Assert.AreEqual(0, chain.Height);
        }

        [TestMethod]
        public void AddGenesisBlock()
        {
            var chain = new MainChain();
            var genesis = new BlockData(0);

            chain.Add(genesis);

            Assert.AreEqual(1, chain.Height);
            Assert.AreSame(genesis, chain.BestBlock);
        }
    }
}
