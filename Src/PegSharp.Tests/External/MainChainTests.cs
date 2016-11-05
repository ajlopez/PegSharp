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
    }
}
