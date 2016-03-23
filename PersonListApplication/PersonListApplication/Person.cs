/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */

namespace PersonListApplication
{
    /// <summary>
    /// This class holds Person properties.
    /// </summary>
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string SocialSecurityNumber { get; set; }

        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + SocialSecurityNumber;
        }
    }
}
