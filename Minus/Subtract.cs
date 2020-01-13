using System;
using Operation;

namespace Minus
{
    public interface ISubtract
    {
        public dynamic Difference(dynamic a, dynamic b);
    }
    public class Sub : ISubtract
    {
        public dynamic result;

        public dynamic Difference(dynamic a, dynamic b)
        {
            result = Subtraction.Subtract(a, b);
            return result;
        }

    }
}
