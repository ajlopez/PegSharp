namespace PegSharp.External
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MainChain
    {
        private List<BlockData> blocks = new List<BlockData>();

        public long Height { get { return blocks.Count; } }

        public BlockData BestBlock
        {
            get
            {
                return this.blocks.Last();
            }
        }

        public void Add(BlockData block)
        {
            this.blocks.Add(block);
        }
    }
}
