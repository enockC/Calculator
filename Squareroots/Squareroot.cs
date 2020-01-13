using System;
using Operation;

namespace Squareroots
{
    public interface ISquarerooting
    {
        public dynamic Sqrt(dynamic a);
    }
    public class SquareRoots : ISquarerooting
    {
        public dynamic solution;

        public dynamic Sqrt(dynamic a)
        {
            solution = Math.Sqrt(a);
            return solution;
        }
    }
}
