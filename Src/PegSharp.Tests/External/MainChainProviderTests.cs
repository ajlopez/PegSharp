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

        [TestMethod]
        public void AddTwoBlocks()
        {
            var chain = new MainChainProvider();
            var genesis = new BlockData(0);
            var block = new BlockData(genesis);

            chain.Add(genesis);
            chain.Add(block);

            Assert.AreEqual(2, chain.Height);
            Assert.AreSame(genesis, chain.GetBlockData(0));
            Assert.AreSame(block, chain.GetBlockData(1));
        }

        [TestMethod]
        public void AddTenBlocks()
        {
            var chain = new MainChainProvider();

            chain.Add(10);

            Assert.AreEqual(10, chain.Height);

            for (long k = 0; k < 10; k++)
            {
                Assert.AreEqual(k, chain.GetBlockData(k).Number);

                if (k > 0)
                    Assert.AreEqual(chain.GetBlockData(k - 1).Hash, chain.GetBlockData(k).ParentHash);
            }
        }

        [TestMethod]
        public void AddTenBlockTwice()
        {
            var chain = new MainChainProvider();

            chain.Add(10);
            chain.Add(10);

            Assert.AreEqual(20, chain.Height);

            for (long k = 0; k < 20; k++)
            {
                Assert.AreEqual(k, chain.GetBlockData(k).Number);

                if (k > 0)
                    Assert.AreEqual(chain.GetBlockData(k - 1).Hash, chain.GetBlockData(k).ParentHash);
            }
        }

        [TestMethod]
        public void AddTenBlockAndReplaceAndAddMoreBlocks()
        {
            var chain = new MainChainProvider();

            chain.Add(10);
            chain.Add(5, 10);

            Assert.AreEqual(16, chain.Height);

            for (long k = 0; k < 16; k++)
            {
                Assert.AreEqual(k, chain.GetBlockData(k).Number);

                if (k > 0)
                    Assert.AreEqual(chain.GetBlockData(k - 1).Hash, chain.GetBlockData(k).ParentHash);
            }
        }
    }
}
