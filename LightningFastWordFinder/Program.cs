﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LightningFastWordFinder
{
    class Program
    {
        static string name = ""; // <- Fill in your name!
        static int numOfRuns = 1000;

        static double RunParserPerformanceTests( string text )
        {
            string longestWord;
            DateTime start = DateTime.Now;
            for( int i = 0; i < numOfRuns; ++i )
            {
                Console.WriteLine( "Run: " + i );
                LightningWordFinder parser = new LightningWordFinder();
                longestWord = parser.GetLongestWord( text );

                if( longestWord != "Constantinopolitan" )
                {
                    Console.WriteLine( "The longest word is not what I wanted to see.." );
                    Thread.Sleep( 20 );
                }
            }
            DateTime end = DateTime.Now;
            return end.Subtract( start ).TotalMilliseconds / numOfRuns;
        }

        static void StoreHighScore( double highscore )
        {
            StreamWriter writer = File.AppendText( @"..\..\TextFiles\highscore.txt" );
            writer.WriteLine( name + " Runs: " + numOfRuns + " Score: " + highscore );
            writer.Close();
        }

        static void Main( string[] args )
        {
            string text = File.ReadAllText( @"..\..\TextFiles\history-of-egypt-chaldea-syria-babylonia-assyria.txt" );
            Console.WriteLine( "Text length: " + text.Length );
            double avgRuntime = RunParserPerformanceTests( text );
            Console.WriteLine( "Average Running Time: " + avgRuntime );
            StoreHighScore( avgRuntime );

            Console.ReadKey();
        }
    }
}
