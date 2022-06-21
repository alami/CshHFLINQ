using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshHFLINQ
{
    class AddSubtract
    {
        public int Value { get; set; }
        public AddSubtract Add(int i)
        {
            Console.WriteLine($"Value: {Value}, adding {i}");
            return new AddSubtract() { Value = Value + i };
        }
        public AddSubtract Subtract(int i)
        {
            Console.WriteLine(
            $"Value: {Value}, subtracting {i}");
            return new AddSubtract() { Value = Value - i };
        }
    }
}
