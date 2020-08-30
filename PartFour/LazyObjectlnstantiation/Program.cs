using System;

namespace LazyObjectlnstantiation
{
    class Program
    {
        static void Main(string[] args)
        {
            //// This caller does not care about getting all songs,
            //// but indirectly created 10,000 objects!
            //MediaPlayer myPlayer = new MediaPlayer();
            //myPlayer.Play();

            // No allocation of AllTracks object here!
            MediaPlayer myPlayer = new MediaPlayer();
            myPlayer.Play();
            // Allocation of AllTracks happens when you call GetAllTracks().
            MediaPlayer yourPlayer = new MediaPlayer();
            AllTracks yourMusic = yourPlayer.GetAllTracks();

            Console.ReadLine();
        }

        class Song
        {
            public string Artist { get; set; }
            public string TrackName { get; set; }
            public double TrackLength { get; set; }
        }
        // Represents all songs on a player.
        class AllTracks
        {
            // Our media player can have a maximum
            // of 10,000 songs.
            private Song[] allSongs = new Song[10000];
            public AllTracks()
            {
                // Assume we fill up the array
                // of Song objects here.
                Console.WriteLine("Filling up the songs!");
            }
        }
        // The MediaPlayer has-an AllTracks object.
        class MediaPlayer
        {
            // Assume these methods do something useful.
            public void Play() { /* Play a song */ }
            public void Pause() { /* Pause the song */ }
            public void Stop() { /* Stop playback */ }
            //private Lazy<AllTracks> allSongs = new Lazy<AllTracks>();

            // Use a lambda expression to add additional code
            // when the AllTracks object is made.
            private Lazy<AllTracks> allSongs = new Lazy<AllTracks>(() =>
            {
                Console.WriteLine("Creating AllTracks object!");
                return new AllTracks();
            }
            );
            public AllTracks GetAllTracks()
            {
                // Return all of the songs.
                return allSongs.Value;
            }
            //private AllTracks allSongs = new AllTracks();
            //public AllTracks GetAllTracks()
            //{
            //    // Return all of the songs.
            //    return allSongs;
            //}
        }
    }
}
