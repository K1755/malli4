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

namespace T7
{
    /// <summary> 
    /// CD class...
    /// </summary> 
    class CD
    {
        public string Artist { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }
        public List<Song> Songs;

        public CD()
        {
            Songs = new List<Song>();
        }
        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public override string ToString()
        {
            string data = "CD:";
            data += "\n-Artist: " + Artist + "\n-Name: " + Name + "\n-Genre: " + Genre + "\n-Price: " + Price +"$";
            data += "\nSongs:";

            int totalLength = 0;
            foreach(Song song in Songs)
            {
                if (song != null)
                {
                    data += "\n--" + song.ToString();
                    totalLength += song.LengthInSeconds;
                }
            }

            int min = totalLength / 60;
            int sec = totalLength % 60;
            string duration = min.ToString("00") + ":" + sec.ToString("00");
            data += "\n-Total duration: " + duration;

            return data;
        }
    }
}
