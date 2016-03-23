/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Author: Pasi Manninen
 */
using System;
using System.Collections.Generic;

namespace StackApplication
{
    /// <summary>
    /// This class demonstrates Stack collection with string objects.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // create stack for strings
            Stack<string> stackStrings = new Stack<string>();
            // add strings
            stackStrings.Push("first");
            stackStrings.Push("second");
            stackStrings.Push("third");

            // get first
            Console.WriteLine("Print first in stack:");
            Console.WriteLine(stackStrings.Peek()); // third

            // print all
            Console.WriteLine();
            Console.WriteLine("Print all in stack:");
            foreach (string s in stackStrings)
            {
                Console.WriteLine(s);
            }
            // outputs
            //  third
            //  second
            //  first

            // get and delete first
            Console.WriteLine();
            Console.WriteLine("get and delete first:");
            string temp = stackStrings.Pop();
            Console.WriteLine("temp is {0}", temp); // temp is third
            Console.WriteLine("Count is {0}", stackStrings.Count); // count is 2

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
