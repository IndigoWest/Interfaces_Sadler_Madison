// System namespace needed to use Console class
using System;
// System.Collections.Generic namespace needed to use Console class
using System.Collections.Generic;
// System.Text namespace needed to use Console class
using System.Text;

// My collection of classes for this project
namespace Interfaces_Sadler_Madison
{
    // Main class for IGenre.cs
    // Labels IGenre as an interface
    interface IGenre
    {
        // The Main method is executed when the application starts
        // Declares a public string called ESRB
        public string ESRB
        {
            // Sets a getter
            get;
            // Sets a setter
            set;
        }

        // Declares a public string called Genre
        public string Genre
        {
            // Sets a getter
            get;
            // Sets a setter
            set;
        }

        // Declares a public string called Title
        public string Title
        {
            // Sets a getter
            get;
            // Sets a setter
            set;
        }

        // Declares a Describe method
        public string Describe();
    }
}
