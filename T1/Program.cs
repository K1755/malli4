/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace T1
{
    /// <summary>
    /// This class demonstrates Persons class to collect Person objects.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // create a Persons object
            Persons myFriends = new Persons();

            // create a few Person objects
            Person person1 = new Person { Firstname = "Kirsi", Lastname = "Mainio", SocialSecurityNumber = "010190-111A" };
            Person person2 = new Person { Firstname = "Matti", Lastname = "Husso", SocialSecurityNumber = "020292-222A" };
            Person person3 = new Person { Firstname = "Teppo", Lastname = "Vuolle", SocialSecurityNumber = "030393-333A" };

            // add Person objects to Persons
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            // get one person from Persons
            Console.WriteLine("Get person from first index:");
            Person person4 = myFriends.GetPerson(0);
            if (person4 != null) Console.WriteLine(person4.ToString()); // Kirsi Mainio 010190-111A
            Console.WriteLine();

            // print all collection
            Console.WriteLine("All persons data:");
            myFriends.PrintData();
            Console.WriteLine();

            // find person
            string SocialSecurityNumber = "020292-222A";
            Console.WriteLine("Find person with social security number :" + SocialSecurityNumber);
            Person person5 = myFriends.FindPerson(SocialSecurityNumber);
            if (person5 != null) Console.WriteLine(person4.ToString()); // Matti Husso 020292-222A
            else Console.WriteLine("Can't find person with that social security number.");
            Console.WriteLine();

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
