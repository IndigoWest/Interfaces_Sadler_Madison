// System namespace needed to use Console class
using System;
// System.Collections.Generic namespace needed to use Console class
using System.Collections.Generic;
// System.Text namespace needed to use Console class
using System.Text;

// My collection of classes for this project
namespace Interfaces_Sadler_Madison
{
    // Main class for Movie.cs
    // Implements IGenre interface
    class Movie : IGenre
    {
        // The Main method is executed when the application starts
        // Takes a public string called ESRB
        public string ESRB
        {
            // Sets a getter
            get;
            // Sets a setter
            set;
        }

        // Takes a public string called Genre
        public string Genre
        {
            // Sets a getter
            get;
            // Sets a setter
            set;
        }

        // Takes a public string called Title
        public string Title
        {
            // Sets a getter
            get;
            // Sets a setter
            set;
        }

        // Creates a public Movie() that takes string parameters esrbParam, genreParam, and titleParam
        public Movie(string esrbParam, string genreParam, string titleParam)
        {
            // States ESRB is esrbParam
            ESRB = esrbParam;
            // States Genre is genreParam
            Genre = genreParam;
            // States Title is titleParam
            Title = titleParam;
        }

        // Creates a public method called PlayMovie
        public void PlayMovie()
        {
            // Prints text to console stating the movie is starting
            Console.WriteLine("Shhhhhh... The Movie is Starting... Please silence all cell phones and be courteous of those around you.");
        }

        // Adds a public Describe method
        public string Describe()
        {
            // Returns text saying the movie's title, genre, and ESRB rating
            return $"{Title} is a {Genre} movie, rated {ESRB}.";
        }
    }
}
