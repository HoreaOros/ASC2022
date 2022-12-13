using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _1213
{
    public static class Extension
    {
        /*
         * 00110101
         * 00001000  OR
         * --------   
         * 00111101
         */
        public static uint SetBit(this uint n, int offset)
        {
            uint mask;
            mask = 1u << offset;
            n |= mask;
            return n;
        }
        /*
         * 00111101
         * 11110111 AND
         * --------
         * 00110101
         */
        public static uint ResetBit(this uint n, int offset)
        {
            uint mask;
            mask = ~(1u << offset);
            n &= mask;
            return n;
        }
        /*
         * 00111101
         * 00000111
         * 00000001 AND
         * ---------
         */
        public static uint GetBit(this uint n, int offset)
        {
            return (n >> offset) & 1u;
        }
    }
}
