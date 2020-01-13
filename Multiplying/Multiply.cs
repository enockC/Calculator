using System;
using Multiply;
using Operation;

namespace Multiplying
{
    public class Multiplying : IMultiply
    {
        public dynamic result;

        public dynamic Multiply(dynamic a, dynamic b)
        {
            result = Multiplication.Multiply(a, b);
            return result;
        }

    }
}
