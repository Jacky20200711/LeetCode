using System;

namespace Q191_Number_of_1_Bits_
{
    public class Program
    {
        static void Main() { }
           
        public int HammingWeight(uint n)
        {
            int numberOfBit1 = 0;

            while(n > 0)
            {
                uint nAnd1 = n & 1;

                if (nAnd1 > 0)
                {
                    numberOfBit1++;
                }

                n >>= 1;
            }

            return numberOfBit1;
        }
    }
}
