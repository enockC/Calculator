using System;
using Operation;

namespace Mult
{
    public interface IMultiply
    {
        public dynamic Multiply(dynamic a, dynamic b);
    }
    public class Multiple : IMultiply
    {
        public dynamic result;

        public dynamic Multiply(dynamic a, dynamic b)
        {
            result = Multiplication.Multiply(a, b);
            return result;
        }

    }
}
