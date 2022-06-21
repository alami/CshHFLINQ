using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshHFLINQ
{
    class SandwichTest
    {
        static public void Action ()
        {
            var sandwiches = new[] { "ham and cheese", "salami with mayo",
                                     "turkey and swiss", "chicken cutlet" };
            var sandwichesOnRye =
                from sandwich in sandwiches
                select $"{sandwich} on rye";
            foreach (var sandwich in sandwichesOnRye)
                Console.WriteLine(sandwich);

            Console.WriteLine();
            var random = new Random();
            var numbers = new List<int>();
            int length = random.Next(50, 150);
            for (int i = 0; i < length; i++)
                numbers.Add(random.Next(100));
            Console.WriteLine($@"
                All for {length} / {numbers.Count()} numbers: {String.Join(", ", numbers.Take(length))}
                The first 5 numbers: {String.Join(", ", numbers.Take(5))}
                The last 5 numbers: {String.Join(", ", numbers.SkipWhile((q,i) =>i<(length-5)))}
                The first is {numbers.First()} and the last is {numbers.Last()}
                The smallest is {numbers.Min()}, and the biggest is {numbers.Max()}
                The sum is {numbers.Sum()}
                The average is {numbers.Average():F2}");
        }
    }
}
