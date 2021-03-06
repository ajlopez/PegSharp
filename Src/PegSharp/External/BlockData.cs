﻿namespace PegSharp.External
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class BlockData
    {
        private long number;
        private Hash hash;
        private Hash parentHash;

        public BlockData()
        {
            this.hash = new Hash();
        }

        public BlockData(Hash hash)
        {
            this.hash = hash;
        }

        public BlockData(long number)
        {
            this.number = number;
            this.hash = new Hash();
        }

        public BlockData(long number, Hash parentHash)
        {
            this.number = number;
            this.hash = new Hash();
            this.parentHash = parentHash;
        }

        public BlockData(BlockData parent)
        {
            this.number = parent.Number + 1;
            this.hash = new Hash();
            this.parentHash = parent.Hash;
        }

        public long Number { get { return this.number; } }

        public Hash Hash { get { return this.hash; } }

        public Hash ParentHash { get { return this.parentHash; } }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is BlockData))
                return false;

            return this.hash.Equals(((BlockData)obj).hash);
        }

        public override int GetHashCode()
        {
            return this.hash.GetHashCode();
        }
    }
}
