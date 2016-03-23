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

namespace QueueApplication
{
    /// <summary>
    /// This class demonstrates Queue collection with string objects.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // create queue instance
            Queue<string> queue = new Queue<string>();
            // add values
            queue.Enqueue("first");
            queue.Enqueue("second");
            queue.Enqueue("third");

            // get first and leave it to collection
            string first = queue.Peek();
            Console.WriteLine("1st in queue is {0}", first); // first
            Console.WriteLine("Count is {0}", queue.Count); // 3

            // get first and remove it from collecion
            first = queue.Dequeue();
            Console.WriteLine("1st in queue is {0}", first);  // first
            Console.WriteLine("Count is {0}", queue.Count); // 2

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
