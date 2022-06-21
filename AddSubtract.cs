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

    class AddSub
    {
        static public void Test()
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 99; i++) numbers.Add(i);
            IEnumerable<int> firstAndLastFive = numbers.Take(5).Concat(numbers.SkipWhile(i=>i<95)).Reverse();
            foreach (int i in firstAndLastFive)
            {
                Console.Write($"{i} ");
            }
            AddSubtract a = new AddSubtract() { Value = 5 }
            .Add(5)
            .Subtract(3)
            .Add(9)
            .Subtract(12);
            Console.WriteLine($"Result: {a.Value}");
        }
    }

}
