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

namespace T1
{
    /// <summary> 
    /// This class holds person objects in a collection.
    /// </summary>
    class Persons
    {
        /// <summary>
        /// Person collection to store person objects
        /// </summary>
        private List<Person> persons;

        /// <summary>
        /// Default constructor initializes a collection
        /// </summary>
        public Persons()
        {
            persons = new List<Person>();
        }

        /// <summary>
        /// Add persons to collection
        /// </summary>
        /// <param name="person">Added person</param>
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        /// <summary>
        /// Returns a person to caller application.
        /// </summary>
        /// <param name="index">Person index in collection</param>
        /// <returns></returns>
        public Person GetPerson(int index)
        {
            if (index < persons.Count) return persons.ElementAt(index);
            else return null;
        }

        /// <summary>
        /// Returns a person to caller application
        /// </summary>
        /// <param name="SocialSecurityNumber">Finded person social security number</param>
        /// <returns></returns>
        public Person FindPerson(string SocialSecurityNumber)
        {
            foreach(Person person in persons)
            {
                if (SocialSecurityNumber.Equals(person.SocialSecurityNumber))
                {
                    return person;
                }
            }
            return null;
        }

        /// <summary>
        /// Print person collection data to the console
        /// </summary>
        public void PrintData()
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
