/*
 * Isaiah Dicristoforo
 *
 * Project Euler Christmas Tribute Problem
 *
 * Problem credit:  Professor Nicholson
 *
 */
using System;
using System.Linq;


namespace ChristmasProjectEuler
{
    
    class ProjectEulerTributeProblem
    {
      
        /// <summary>
        /// Finds the largest prime number made up of all prime digits.  Each array element represents a line in a file.
        /// </summary>
        /// <param name="numLines">Lines of number from a text file</param>
        /// <returns>The largest prime number made up of all prime digits</returns>
        public static long Solve(string[] numLines)
        {
            long largestPrime = 0;
            foreach (var lineOfInput in numLines)  //Loops through each "line" in the array, representing a line in a text file.  A prime cannot continue from one line to the next per the rules of the problem.
            {
                for (int j = 0; j < lineOfInput.Length; j++)  //Loops through each digit in the string of numbers
                {
                    bool containsAllPrimes = true;
                        for (int k = 2 ; IsPrime(Convert.ToInt64(lineOfInput.Substring(j, 1))) && k < lineOfInput.Length && containsAllPrimes; k++)
                        {
                            long newNum = Convert.ToInt64(lineOfInput.ToString().Substring(j, k));
                            if (IsPrime(newNum) && ContainsAllPrimeDigits(newNum))
                                largestPrime = newNum > largestPrime ? newNum : largestPrime;
                            if (!ContainsAllPrimeDigits(newNum)) containsAllPrimes = false;
                        }
                }
            }
            return largestPrime;
        }

        /// <summary>
        /// Determines whether a number contains all prime digits
        /// </summary>
        /// <param name="num">The number to check if it contains all prime digits</param>
        /// <returns>True if the number contains all prime digits, false otherwise</returns>
        public static bool ContainsAllPrimeDigits(long num)
        { 
            //I figured out how to do this with LINQ, but a for-loop would have worked just as well.
            return num.ToString().ToArray().Where(x => IsPrime(Convert.ToInt64(x.ToString()))).ToArray().Length == num.ToString().Length;
        }
        
        /// <summary>
        /// Determines whether a number is prime
        /// </summary>
        /// <param name="num">The number to check for primality</param>
        /// <returns>True if num is prime, false otherwise</returns>
        public static bool IsPrime(long num)
        {
            bool isPrime = !(num == 0 || num % 2 == 0);
            if (num == 1 || num == 2)
            {
                isPrime = true;
            }
            else
            {
                for (int i = 3; i <= Math.Sqrt(num); i += 2)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                    }
                }
            }

            return isPrime;
        }

       
        }

    }

