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
    }
}
