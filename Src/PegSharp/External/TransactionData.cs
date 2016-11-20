namespace PegSharp.External
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class TransactionData
    {
        private Hash hash;

        public TransactionData()
        {
            this.hash = new Hash();
        }

        public Hash Hash { get { return this.hash; } }
    }
}
