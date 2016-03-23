/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListApplication
{
    /// <summary>
    /// This class demonstrates List collection with int primitive types.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            bool result;
            do
            {
                // ask number from the user (read one line)
                Console.Write("Give a number > ");
                string line = Console.ReadLine();
                // try to read number from the given line
                int number;
                result = int.TryParse(line, out number);
                // number (integer) was given correctly, use it..
                if (result)
                {
                    list.Add(number);
                }
            } while (result);
            // write some statistics
            Console.WriteLine("Average : {0}", list.Average());
            Console.WriteLine("Min : {0}", list.Min());
            Console.WriteLine("Max : {0}", list.Max());
            Console.WriteLine("Numbers count : {0}", list.Count);
            // all
            list.ForEach(item => Console.Write(item + ","));
            // sort
            list.Sort();
            // all
            Console.WriteLine();
            list.ForEach(item => Console.Write(item + ","));

            Console.ReadLine();
        }
    }
}
