using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingchallenge30qstn1
{
    internal class BitSet
    { 
            private BitArray bits;

            public BitSet(int size)
            {
                bits = new BitArray(size);
            }

            public void And(BitSet other)
            {
                bits.And(other.bits);
            }

            public void Or(BitSet other)
            {
                bits.Or(other.bits);
            }

            public void Xor(BitSet other)
            {
                bits.Xor(other.bits);
            }

            public void Flip(int index)
            {
                bits.Set(index, !bits.Get(index));
            }

            public void Set(int index)
            {
                bits.Set(index, true);
            }

            public int Cardinality()
            {
                int count = 0;
                for (int i = 0; i < bits.Count; i++)
                {
                    if (bits.Get(i))
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    
}
