using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reactive.Linq;

namespace RxFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Observable.Interval(TimeSpan.FromSeconds(1))
                .Skip(1) //skips zero
                .Subscribe(t => 
                    Console.WriteLine(t % 3 == 0 && t % 5 == 0 ? "FizzBuzz"
                                                  : t % 3 == 0 ? "Fizz"
                                                  : t % 5 == 0 ? "Buzz"
                                                  : t.ToString()));

            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();
        }
    }
}
