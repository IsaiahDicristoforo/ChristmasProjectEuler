/*
 * Isaiah Dicristoforo
 *
 * Christmas Project Euler Tribute Problem
 *
 * Problem Credit:  Professor Nicholson
 */

using System;
using System.IO;

namespace ChristmasProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {

            //The file path to our file of numbers
            String testDataPath;

            testDataPath = "../../TestData/data.txt";

            //Checks to see if our file exists with our current file path.
            if (File.Exists(testDataPath))
            {
                Console.WriteLine($"File was successfully found at: {Path.GetFullPath(testDataPath)}.  Solving problem...");
                Console.WriteLine($"Solution: {ProjectEulerTributeProblem.Solve(File.ReadAllLines(testDataPath))}");
            }
            else
            {
                //Our "catch" block
                Console.WriteLine("Input file does not exist");
            }


        }
    }
}
