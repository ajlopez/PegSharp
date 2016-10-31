namespace PegSharp.External
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MainChainProvider
    {
        private List<BlockData> blocksData = new List<BlockData>();

        public long Height { get { return blocksData.Count; } }

        public void Add(BlockData blockData)
        {
            this.blocksData.Add(blockData);
        }

        public BlockData GetBlockData(long number)
        {
            if (number >= this.blocksData.Count)
                return null;

            return this.blocksData[(int)number];
        }
    }
}
