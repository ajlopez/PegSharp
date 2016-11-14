namespace PegSharp.External
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class BlockChain
    {
        private List<BlockData> blocks = new List<BlockData>();
        private List<BlockData> others = new List<BlockData>();

        public long Height { get { return blocks.Count; } }

        public BlockData BestBlock
        {
            get
            {
                return this.blocks.Last();
            }
        }

        public bool Add(BlockData block)
        {
            if (this.blocks.Count == 0 || this.BestBlock.Hash.Equals(block.ParentHash))
            {
                this.blocks.Add(block);
                return true;
            }

            others.Add(block);

            return false;
        }
    }
}
