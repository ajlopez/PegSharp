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

        public TransactionData(Hash hash)
        {
            this.hash = hash;
        }

        public Hash Hash { get { return this.hash; } }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is TransactionData))
                return false;

            return this.hash.Equals(((TransactionData)obj).hash);
        }

        public override int GetHashCode()
        {
            return this.hash.GetHashCode();
        }
    }
}
