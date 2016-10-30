namespace PegSharp.External
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MainChainProvider
    {
        private BlockData blockData;

        public long Height { get { return blockData == null ? 0 : 1; } }

        public void Add(BlockData blockData)
        {
            this.blockData = blockData;
        }

        public BlockData GetBlockData(long number)
        {
            return this.blockData;
        }
    }
}
