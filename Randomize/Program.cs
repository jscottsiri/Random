using System;

namespace Randomize
{
    class Program
    {
        public static int RandInt()
        {
            Random rand = new Random(25);
            return rand.Next();
        }
        public static decimal RandDec()
        {
            Random rand = new Random(25);
            var item = new decimal(rand.Next()*rand.NextDouble());
            return item;
        }

        public static int RandIntRange(int range1, int range2)
        {
            Random rand = new Random(25);
            return rand.Next(range1, range2);
        }
        public static decimal RandDecRange(int dec1, int dec2)
        {
            Random rand = new Random(25);
            var item = new decimal(rand.Next(dec1, dec2) * rand.NextDouble());
            return item;
        }
        public static int[] RandListInt(int x)
        {
            Random rand = new Random(25);
            int[] result = new int[x];
            for (int ctr = 0; ctr <= x; ctr++)
            {
                result[ctr] = rand.Next();
            }
            return result;

        }
        public static decimal[] RandListDec(int x)
        {
            Random rand = new Random(25);
            decimal[] result = new decimal[x];
            for (int ctr = 0; ctr <= x; ctr++)
            {
                result[ctr] = (decimal)(rand.NextDouble() * rand.Next());
            }
            return result;
        }

    }
}
