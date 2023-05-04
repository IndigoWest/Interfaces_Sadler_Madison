// System namespace needed to use Console class
using System;
// System.Collections.Generic namespace needed to use Console class
using System.Collections.Generic;
// System.Text namespace needed to use Console class
using System.Text;

// My collection of classes for this project
namespace Interfaces_Sadler_Madison
{
    // Main class for Game.cs
    // Implements IGenre interface
    class Game : IGenre
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
        
        // Creates a public Game() that takes string parameters esrbParam, genreParam, and titleParam
        public Game(string esrbParam, string genreParam, string titleParam)
        {
            // States ESRB is esrbParam
            ESRB = esrbParam;
            // States Genre is genreParam
            Genre = genreParam;
            // States Title is titleParam
            Title = titleParam;
        }

        // Creates a public method called PlayGame
        public void PlayGame()
        {
            // Prints to console a message that the game is starting
            Console.WriteLine("The Game is Starting... Get your controllers and your headsets because it's time to game on!");
        }

        // Adds a public Describe method
        public string Describe()
        {
            // Returns text saying the game's title, genre, and ESRB rating
            return $"{Title} is a {Genre} game, rated {ESRB}.";
        }
    }
}
