using System;
using Operation;

namespace Cube1
{
    public interface ICubed
    {
        public dynamic Cubed(dynamic a);
    }
    public class Cubes : ICubed
    {
        public dynamic result;

        public dynamic Cubed(dynamic a)
        {
            result = Cube.Cubed(a);
            return result;
        }
    }
}
