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

namespace DictionaryApplication
{
    /// <summary>
    /// This class demonstrates Dictionary collection with Person objects.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // create persons collection
            Dictionary<string, Person> persons = new Dictionary<string, Person>();

            // create persons
            Person person1 = new Person { Firstname = "Kirsi", Lastname = "Mainio", SocialSecurityNumber = "010190-111A" };
            Person person2 = new Person { Firstname = "Matti", Lastname = "Husso", SocialSecurityNumber = "020292-222A" };
            Person person3 = new Person { Firstname = "Teppo", Lastname = "Vuolle", SocialSecurityNumber = "030393-333A" };

            // add persons to collection
            persons.Add(person1.SocialSecurityNumber, person1);
            persons.Add(person2.SocialSecurityNumber, person2);
            persons.Add(person3.SocialSecurityNumber, person3);
            
            // find person with key
            string searchKey = "020292-222A";
            if (persons.ContainsKey(searchKey))
            {
                Console.WriteLine("Person with social security number {0} is {1}.", searchKey, persons[searchKey].Firstname);
                // output
                //  Person with social security number 020292-222A is Matti.
            }

            Console.WriteLine();
            Console.WriteLine("Print all keys in collection:");
            // go through all keys
            foreach (string key in persons.Keys)
            {
                Console.WriteLine(key);
                // output
                //  010190-111A
                //  020292-222A
                //  030393-333A   
            }

            Console.WriteLine();
            Console.WriteLine("Print all objectgs in collection:");        
            //go through all values
            foreach (Person person in persons.Values)
            {
                Console.WriteLine(person);
                // output
                //  Kirsi Mainio 010190-111A
                //  Matti Husso 020292-222A
                //  Teppo Vuolle 030393-333A
            }

            Console.WriteLine();
            Console.WriteLine("Print all keys and objects in collection:");
            // go through all keys and values
            foreach (KeyValuePair<string, Person> kvp in persons)
            {
                Console.WriteLine("{0} : {1}", kvp.Key, kvp.Value);
                // output
                //  010190-111A: Kirsi Mainio 010190-111A
                //  020292-222A: Matti Husso 020292-222A
                //  030393-333A: Teppo Vuolle 030393-333A
            }

            // remove object
            if (persons.ContainsKey(searchKey))
            {
                persons.Remove(searchKey);
            }

            // size
            Console.WriteLine();
            Console.WriteLine("Collection size is {0}", persons.Count);

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
