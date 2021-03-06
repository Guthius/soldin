#region Using Statements
using System;
using Soldin.Net;
#endregion

namespace Soldin
{
    class Program
    {
        #region Methods

        /// <summary>
        /// Main entry point of the application.
        /// </summary>
        /// <param name="args"></param>
        static void Main( string[] args )
        {
            PrintBanner();

            Server.Run();
        }

        /// <summary>
        /// Outputs the server info banner to the console.
        /// </summary>
        static void PrintBanner()
        {
            Console.Title = "Gateway - Soldin Revived";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write( @"              ___      _    _ _        ___         _            _               " );
            Console.Write( @"             / __| ___| |__| (_)_ _   | _ \_____ _(_)_ _____ __| |              " );
            Console.Write( @"             \__ \/ _ \ / _` | | ' \  |   / -_) V / \ V / -_) _` |              " );
            Console.Write( @"             |___/\___/_\__,_|_|_||_| |_|_\___|\_/|_|\_/\___\__,_|              " );
            Console.Write( @"                                                                                " );
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write( "▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓" );
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write( "                                                         [GATEWAY]              " );
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write( "▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n" );
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        #endregion
    }
}
