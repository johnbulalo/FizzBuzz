using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool fizz,buzz;
            int fiz, buz;

            for (int i = 1; i<100; i++) {
                fiz = i % 3;
                buz = i % 5;

                if (fiz == 0 && buz == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    if (fiz == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if(buz == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }

            }
            
        }
    }
}
