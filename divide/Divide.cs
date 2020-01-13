using System;
using Divide;
using Operation;

namespace divide
{
    public class Dividing : IDivide
    {
        public double result;

        public double Divide(dynamic a, dynamic b)
        {
            result = Division.Quotient(a, b);
            return result;
        }
    }
}
