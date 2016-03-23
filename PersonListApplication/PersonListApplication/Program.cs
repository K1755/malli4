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

namespace PersonListApplication
{
    /// <summary>
    /// This class demonstrates List collection with Person objects.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // create a list for persons
            List<Person> persons = new List<Person>();

            // add persons to list
            persons.Add(new Person { Firstname = "Kirsi", Lastname = "Mainio", SocialSecurityNumber = "010190-111A" });
            persons.Add(new Person { Firstname = "Matti", Lastname = "Husso", SocialSecurityNumber = "020292-222A" });
            persons.Add(new Person { Firstname = "Teppo", Lastname = "Vuolle", SocialSecurityNumber = "030393-333A" });

            // show one person data
            Console.WriteLine("Write one person object:");
            Console.WriteLine(persons.ElementAt(0).ToString()); // Kirsi Mainio 010190-111A

            Console.WriteLine();
            Console.WriteLine("Write whole collection:");
            // loop through all the persons
            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
            // outputs:
            // Kirsi Mainio 010190 - 111A
            // Matti Husso 020292 - 222A
            // Teppo Vuolle 030393 - 333A

            // sort by lastname
            persons.Sort((x, y) => x.Lastname.CompareTo(y.Lastname));

            Console.WriteLine();
            Console.WriteLine("Write sorted collection:");
            // loop through all the persons
            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
            // outputs:
            // Matti Husso 020292 - 222A
            // Kirsi Mainio 010190 - 111A
            // Teppo Vuolle 030393 - 333A

            // read line to keep output windows visible
            Console.WriteLine();
            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
