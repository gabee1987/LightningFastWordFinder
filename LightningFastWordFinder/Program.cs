using System;
using System.IO;

namespace LightningFastWordFinder
{
    class Program
    {
        static string name = ""; // <- Fill in your name!
        static int numOfRuns = 1000;
        static string longestWord = "";

        static double RunParserPerformanceTests( string text )
        {
            DateTime start = DateTime.Now;
            for( int i = 0; i < numOfRuns; ++i )
            {
                Console.WriteLine( "Run: " + i );
                LightningWordFinder parser = new LightningWordFinder();
                longestWord = parser.GetLongestWord( text );
            }
            DateTime end = DateTime.Now;
            return end.Subtract( start ).TotalMilliseconds / numOfRuns;
        }

        static void StoreHighScore( double highscore, string longestWord )
        {
            StreamWriter writer = File.AppendText( @"..\..\TextFiles\highscore.txt" );
            writer.WriteLine( "The longest word: " + longestWord );
            writer.WriteLine( name + " Runs: " + numOfRuns + " Score: " + highscore );
            writer.Close();
        }

        static void Main( string[] args )
        {
            string text = File.ReadAllText( @"..\..\TextFiles\history-of-egypt-chaldea-syria-babylonia-assyria.txt" );
            Console.WriteLine( "Text length: " + text.Length );
            double avgRuntime = RunParserPerformanceTests( text );
            Console.WriteLine( "Average Running Time: " + avgRuntime );
            StoreHighScore( avgRuntime, longestWord );

            Console.ReadKey();
        }
    }
}
