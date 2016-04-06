using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._02.Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var primes = new bool[n+1];

            for (int i = 2; i <= n; i++)
            {
                primes[i] = true;
            }
            for (int num = 2; num <= n; num++)
            {
                if (primes[num])
                {
                    Console.WriteLine(num);
                    // с това отивам на дясно и задрасквам числа
                    var p = 2 * num;
                    while (p<=n)
                    {
                        primes[p] = false;
                        p = p + num;
                    }
                }
            }
        }
    }
}
//Problem: Sieve of Eratosthenes

//Write a program to find all prime numbers in range[0…n]
//Sieve of Eratosthenes algorithm:
//primes[0…n] = true
//primes[0] = primes[1] = false
//Find the smallest p, whichholds primes[p] = true
//primes[2 * p] = primes[3 * p] =primes[4 * p] = … = false
//Repeat for the next smallest p