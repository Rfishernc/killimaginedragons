using System;
using System.Collections.Generic;
using System.Linq;
using killimagineDragons.Songs;

namespace killimagineDragons
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodSongs = new List<Song>();
            var allSongs = new List<Song>();
            allSongs.Add(new Song("Bleeding Out", "Imagine Dragons"));
            allSongs.Add(new Song("Whatever It Takes", "Imagine Dragons"));
            allSongs.Add(new Song("Friction", "Imagine Dragons"));
            allSongs.Add(new Song("Song4", "Artist2"));
            allSongs.Add(new Song("Song5", "Artist2"));
            allSongs.Add(new Song("Song6", "Artist3"));
            allSongs.Add(new Song("Song7", "Artist3"));
            allSongs.Add(new Song("Song8", "Artist2"));
            allSongs.Add(new Song("Song9", "Artist4"));
            allSongs.Add(new Song("Song10", "Artist3"));
            allSongs.Add(new Song("Song11", "Artist5"));
            allSongs.Add(new Song("Amsterdam", "Imagine Dragons"));

            goodSongs = allSongs.Where(song => song.Artist != "Imagine Dragons").ToList();

            foreach(Song song in goodSongs)
            {
                Console.WriteLine($"{song.Name}: {song.Artist}");
            }

            Console.ReadLine();
        }
    }
}
