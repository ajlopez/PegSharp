﻿namespace PegSharp.Tests.External
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PegSharp.External;

    [TestClass]
    public class BlockChainTests
    {
        [TestMethod]
        public void CreateEmptyMainChain()
        {
            var chain = new BlockChain();

            Assert.AreEqual(0, chain.Height);
        }

        [TestMethod]
        public void AddGenesisBlock()
        {
            var chain = new BlockChain();
            var genesis = new BlockData(0);

            chain.Add(genesis);

            Assert.AreEqual(1, chain.Height);
            Assert.AreSame(genesis, chain.BestBlock);
        }

        [TestMethod]
        public void AddGenesisAndBlock()
        {
            var chain = new BlockChain();
            var genesis = new BlockData(0);
            var block = new BlockData(genesis);

            chain.Add(genesis);
            chain.Add(block);

            Assert.AreEqual(2, chain.Height);
            Assert.AreSame(block, chain.BestBlock);
        }
    }
}
