using System;
using System.Collections.Generic;
using System.Text;

namespace Operation
{
    public class Randomising
    {
        

        public int Randomise(int min, int max)
        {
            Random random = new Random(0);
            return random.Next(min, max);
        }
    }
}
