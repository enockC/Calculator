using System;
using Operation;

namespace Squres
{
   


    public interface ISquared
    {
        public dynamic Square(dynamic a);
    }
    public class Squares : ISquared
    {
        public dynamic result;

        public dynamic Square(dynamic a)
        {
            result = Squaring.Square(a);
            return result;
        }

    }
}

