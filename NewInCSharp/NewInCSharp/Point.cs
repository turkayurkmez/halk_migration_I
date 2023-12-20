using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewInCSharp
{
    public struct Point
    {
        public int X { get; init; } = -1;
        public int Y { get; init; } = -1;
        public Point()
        {

        }



    }

    public record struct Person
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }

    }
}
