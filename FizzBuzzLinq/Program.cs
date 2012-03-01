namespace FizzBuzzLinq
{
    using System;
    using System.Linq;

    using System.Globalization;

    class Program
    {
        static void Main()
        {
            Console.WriteLine(String.Join("\n", Enumerable.Range(1, 100).Select((i) => ((i % 3 == 0) && (i % 5 == 0)) ? "FizzBuzz" : (i % 3 == 0) ? "Fizz" : (i % 5 == 0) ? "Buzz" : i.ToString(CultureInfo.InvariantCulture)).ToArray()));
        }
    }
}
