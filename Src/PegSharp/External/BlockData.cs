namespace PegSharp.External
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class BlockData
    {
        private long number;
        private Hash hash;

        public BlockData()
        {
            this.hash = new Hash();
        }

        public BlockData(long number)
        {
            this.number = number;
            this.hash = new Hash();
        }

        public long Number { get { return this.number; } }

        public Hash Hash { get { return this.hash; } }
    }
}
