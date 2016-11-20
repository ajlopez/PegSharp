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
    }
}
