// System namespace needed to use Console class
using System;

// My collection of classes for this project
namespace Interfaces_Sadler_Madison
{
    // Main class for Program.cs
    class Program
    {
        // The Main method is executed when the application starts
        static void Main(string[] args)
        {
            // Creates a new Game under Game myGame that has an ESRB rating of "E", a genre of "Survival/Sandbox", and the title as "Minecraft"
            Game myGame = new Game("E", "Survival/Sandbox", "Minecraft");
            // Prints to console myGame.Describe() text
            Console.WriteLine(myGame.Describe());
            // Calls the PlayGame method for myGame
            myGame.PlayGame();

            // Creates a new Movie under Movie myMovie that has an ESRB rating of "PG", a genre of "Adventure/Comedy", and the title as "The Super Mario Bros. Movie"
            Movie myMovie = new Movie("PG", "Adventure/Comedy", "The Super Mario Bros. Movie");
            // Print to console myMovie.Describe() text
            Console.WriteLine(myMovie.Describe());
            // Calls the PlayMovie method for myMovie
            myMovie.PlayMovie();
        }
    }
}
