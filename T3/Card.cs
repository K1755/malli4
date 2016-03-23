/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 12/01/2016 
 * Authors: Pasi Manninen
 */

namespace T3
{
    /// <summary>
    /// This class holds Card properties.
    /// </summary>
    class Card
    {
        public string Suit { get; set; }
        public int Number { get; set; }

        public override string ToString()
        {
            return "Suit: " + Suit + " Number:" + Number;
        }
    }
}
