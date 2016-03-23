/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */

namespace T7
{
    /// <summary> 
    /// Song class...
    /// </summary> 
    class Song
    {
        public string Name { get; set; }
        public int LengthInSeconds { get; set; }
        public override string ToString()
        {
            int min = LengthInSeconds / 60;
            int sec = LengthInSeconds % 60;
            string duration = min.ToString("00") + ":"+ sec.ToString("00");
            return "- Name: " + Name + " - " + duration;
        }
    }
}
