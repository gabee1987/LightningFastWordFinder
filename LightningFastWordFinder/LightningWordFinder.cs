using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LightningFastWordFinder
{
    class LightningWordFinder
    {
        //The longest word: Constantinopolitan
        //Fodor Attila #1 Runs: 1000 Score: 13.5041887
        //---------------------------------------------
        //public string GetLongestWord( string text )
        //{
        //    char[] splitters = { ' ', '\n', '/', '[', ']', ',', '.', ':', '\'', '"', '-' };

        //    var tomb = text.Split( splitters, StringSplitOptions.RemoveEmptyEntries );
        //    var maxLength = tomb.Max( t => t.Length );

        //    return tomb.Where( t => t.Length == maxLength ).First();
        //}


        //The longest word:  Constantinopolitan
        //Fodor Attila #2 Runs: 1000 Score: 31.730313
        //---------------------------------------------
        //public string GetLongestWord( string text )
        //{
        //    string longestString = "";

        //    // Write your code here!
        //    char[] splitters = { ' ', '\n', '/', '[', ']', ',', '.', ':', '\'', '"', '-' };
        //    var buffer = text.ToCharArray();
        //    int count = buffer.Count();
        //    int startIndex = 0;
        //    int length = 0;
        //    for( int i = 0; i < count; i++ )
        //    {
        //        if( splitters.Contains( buffer[i] ) )
        //        {
        //            StoreLongest( startIndex, length + 1 );
        //            startIndex = i;
        //            length = 0;
        //        }
        //        else
        //        {
        //            length++;

        //        }
        //    }
        //    longestString = text.Substring( m_StartIndex, m_Length );

        //    return longestString;
        //}

        //public int m_StartIndex;
        //public int m_Length;

        //private void StoreLongest( int startIndex, int length )
        //{
        //    if( length > m_Length )
        //    {
        //        m_StartIndex = startIndex;
        //        m_Length = length;
        //    }
        //}


        //The longest word: Constantinopolitan
        //Fodor Attila #3 Runs: 1000 Score: 4.3452075
        //The longest word: Constantinopolitan
        //Fodor Attila #3 Runs: 10000 Score: 4.28305246
        //The longest word: Constantinopolitan
        //Fodor Attila #3 Runs: 100000 Score: 4.145145201
        //---------------------------------------------
        //public int m_StartIndex;
        //public int m_Length;

        //public string GetLongestWord( string text )
        //{
        //    // Write your code here!
        //    var buffer = text.ToCharArray();
        //    int count = text.Length;

        //    int startIndex = 0;
        //    int length = 0;
        //    for( int i = 0; i < count; i++ )
        //    {
        //        switch( buffer[i] )
        //        {
        //            case ' ':
        //            case '\n':
        //            case '/':
        //            case '[':
        //            case ']':
        //            case ',':
        //            case '.':
        //            case ':':
        //            case '\'':
        //            case '"':
        //            case '-':

        //                if( length > m_Length )
        //                {
        //                    m_StartIndex = startIndex;
        //                    m_Length = length;
        //                }

        //                startIndex = i + 1;
        //                length = 0;
        //                break;
        //            default:
        //                length++;
        //                break;
        //        }
        //    }
        //    return text.Substring( m_StartIndex, m_Length );
        //}


        //The longest word: Constantinopolitan
        //Koncz Gábor #1 Runs: 1000 Score: 11.706317
        //---------------------------------------------
        //public string GetLongestWord( string text )
        //{
        //    char[] splitters = { ' ', '\n', '/', '[', ']', ',', '.', ':', '\'', '"', '-' };
        //    var wordArray = text.Split( splitters, StringSplitOptions.RemoveEmptyEntries );
        //    var maxLength = 0;
        //    var result = "";

        //    for( var i = 0; i < wordArray.Length; i++ )
        //    {
        //        if( wordArray[i].Length > maxLength )
        //        {
        //            maxLength = wordArray[i].Length;
        //            result = wordArray[i];
        //        }
        //    }

        //    return result;
        //}


        //The longest word: Constantinopolitan
        //Koncz Gábor #2 Runs: 1000 Score: 50.8793444
        //---------------------------------------------
        //public string GetLongestWord( string text )
        //{
        //    string cleanText = Regex.Replace( text, "[^a-zA-Z]+", " ", RegexOptions.Compiled );
        //    string[] words = cleanText.Split( ' ' );
        //    List<int> listOfWords = words.Select( word => word.Length ).ToList();
        //    int maxIndex = listOfWords.IndexOf( listOfWords.Max() );
        //    return words[maxIndex];
        //}


        //The longest word: Constantinopolitan
        //Koncz Gábor #3 Runs: 1000 Score: 47.0166695
        //--------------------------------------------
        //public string GetLongestWord( string text )
        //{
        //    string longestString = "";
        //    string cleanText = Regex.Replace( text, "[^a-zA-Z]+", " ", RegexOptions.Compiled );
        //    string[] words = cleanText.Split( ' ' );
        //    int ctr = 0;
        //    foreach( String s in words )
        //    {
        //        if( s.Length > ctr )
        //        {
        //            longestString = s;
        //            ctr = s.Length;
        //        }
        //    }
        //    return longestString;
        //}


        //The longest word: Constantinopolitan
        //Koncz Gábor #4 Runs: 1000 Score: 5.6859573
        //---------------------------------------------
        //public string GetLongestWord( string text )
        //{
        //    string longestString = "";
        //    int charCounter = 0;
        //    int maxValue = 0;
        //    int indexCounter = 0;
        //    int indexOfLongest = 0;

        //    foreach( char ch in text )
        //    {
        //        if( ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z' )
        //        {
        //            charCounter += 1;
        //        }
        //        else
        //        {
        //            if( charCounter >= maxValue )
        //            {
        //                maxValue = charCounter;
        //                indexOfLongest = indexCounter - maxValue;
        //            }
        //            charCounter = 0;
        //        }
        //        indexCounter += 1;
        //    }
        //    longestString = text.Substring( indexOfLongest, maxValue );
        //    return longestString;
        //}


        //The longest word: Constantinopolitan
        //Koncz Gábor #5 Runs: 1000 Score: 5.2527122
        //---------------------------------------------
        //public string GetLongestWord( string text )
        //{
        //    string longestString = "";
        //    int charCounter = 0;
        //    int maxValue = 0;
        //    int indexCounter = 0;
        //    int indexOfLongest = 0;
        //    int stringLength = text.Length;

        //    for( int i = 0; i < stringLength; i++ )
        //    {
        //        if( text[i] >= 'a' && text[i] <= 'z' || text[i] >= 'A' && text[i] <= 'Z' )
        //        {
        //            charCounter++;

        //        }
        //        else
        //        {
        //            if( charCounter >= maxValue )
        //            {
        //                maxValue = charCounter;
        //                indexOfLongest = indexCounter - maxValue;

        //            }
        //            charCounter = 0;

        //        }
        //        indexCounter++;
        //    }
        //    longestString = text.Substring( indexOfLongest, maxValue );
        //    return longestString;
        //}


        //The longest word: Constantinopolitan
        //Koncz Gábor #6 Runs: 1000 Score: 19.0846991
        //---------------------------------------------
        //public string GetLongestWord( string text )
        //{
        //    string tempString = "";
        //    string longestString = "";
        //    int charCounter = 0;
        //    int maxValue = 0;
        //    int indexCounter = 0;
        //    int indexOfLongest = 0;
        //    foreach( char ch in text )
        //    {
        //        if( ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z' )
        //        {
        //            charCounter += 1;
        //            tempString += ch;
        //        }
        //        else
        //        {
        //            if( charCounter >= maxValue )
        //            {
        //                maxValue = charCounter;
        //                indexOfLongest = indexCounter - maxValue;
        //                longestString = tempString;
        //            }
        //            charCounter = 0;
        //            tempString = "";
        //        }
        //        indexCounter += 1;
        //    }
        //    longestString = text.Substring( indexOfLongest, maxValue );
        //    return longestString;
        //}


        //public string GetLongestWord( string text )
        //{
        //    char[] splitters = { ' ', '\n', '/', '[', ']', ',', '.', ':', '\'', '"', '-' };
        //    var sortedArray = text.Split( splitters, StringSplitOptions.RemoveEmptyEntries ).Sort( ( wordA, wordB ) => wordB.length - wordA.length );
        //    return sortedArray[0];
        //}



        //The longest word: Constantinopolitan
        //Internet #1 Runs: 1000 Score: 36.5304243
        //public string GetLongestWord( string text )
        //{
        //    char[] splitters = { ' ', '\n', '/', '[', ']', ',', '.', ':', '\'', '"', '-' };
        //    var sortedArray = text.Split( splitters, StringSplitOptions.RemoveEmptyEntries );
        //    return sortedArray.OrderByDescending( s => s.Length ).First();
        //}



        //The longest word: Constantinopolitan
        //Garai Márton #1 Runs: 1000 Score: 7.3774163
        //The longest word: Constantinopolitan
        //Garai Márton #1 Runs: 10000 Score: 7.35684334
        //---------------------------------------------
        //public string GetLongestWord( string text )
        //{
        //    char[] chars = text.ToCharArray();
        //    int actualIndex = 0;
        //    int actualMax = 0;
        //    int j = 0;
        //    int length = text.Length;
        //    int i = 1;
        //    while( j < length - actualMax )
        //    {
        //        if( char.IsPunctuation( chars[j + i] ) || char.IsWhiteSpace( chars[j + i] ) )
        //        {
        //            if( actualMax < i )
        //            {
        //                actualMax = i;
        //                actualIndex = j;
        //            }
        //            j += i;
        //            i = 0;
        //        }

        //        i++;
        //    }

        //    return text.Substring( actualIndex + 1, actualMax - 1 );
        //}


        //The longest word: Constantinopolitan
        //Garai Márton #2 Runs: 1000 Score: 93.8320539
        //---------------------------------------------
        //private static readonly Regex Reg = new Regex( @"\w+", RegexOptions.Compiled );

        //public string GetLongestWord( string text )
        //{
        //    var stuff = Reg.Matches( text );
        //    Match max = null;
        //    bool isFirst = true;
        //    // Write your code here!
        //    foreach( Match match in stuff )
        //    {
        //        if( isFirst )
        //        {
        //            isFirst = false;
        //            max = match;
        //            continue;
        //        }

        //        if( match.Length > max.Length )
        //        {
        //            max = match;
        //        }
        //    }

        //    return max.Value;
        //}


        //The longest word: Constantinopolitan
        //Balogh Máté #1 Runs: 1000 Score: 7.7130418
        //---------------------------------------------
        //private static char[] forbiddenWords = new char[5] { '\n', '\r', '-', '/', '.' };
        //public string GetLongestWord( string text )
        //{
        //    string longestString = "";
        //    int start = 0;

        //    while( start >= 0 )
        //    {
        //        int index = text.IndexOf( ' ', start );
        //        int length = (index < 0) ? text.Length - start : index - start;
        //        string tempString = text.Substring( start, length );

        //        if( tempString.IndexOfAny( forbiddenWords ) < 0 )
        //            longestString = longestString.Length > length ? longestString : tempString;

        //        if( index < 0 )
        //            break;

        //        start = ++index;
        //    }
        //    return longestString;
        //}


        //The longest word: Constantinopolitan
        //Balogh Máté #2 Runs: 1000 Score: 4.7560555
        //The longest word: Constantinopolitan
        //Balogh Máté #2 Runs: 10000 Score: 4.68337263
        //The longest word: Constantinopolitan
        //Balogh Máté #2 Runs: 100000 Score: 4.44221432
        //---------------------------------------------
        //private static char[] forbiddenWords = new char[5] { '\n', '\r', '-', '/', '.' };
        //public string GetLongestWord( string text )
        //{
        //    string longestString = "";

        //    // Write your code here!
        //    int start = 0;
        //    while( start >= 0 )
        //    {
        //        int index = text.IndexOf( ' ', start );
        //        int length = (index < 0) ? text.Length - start : index - start;
        //        string tempString = text.Substring( start, length );

        //        if( longestString.Length < length && tempString.IndexOfAny( forbiddenWords ) < 0 )
        //            longestString = tempString;

        //        if( index < 0 )
        //            break;

        //        start = ++index;
        //    }
        //    return longestString;
        //}


        //The longest word: Constantinopolitan\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0
        //Kovács Máté #1 Runs: 1000 Score: 5.7331449
        //---------------------------------------------
        //public string GetLongestWord( string text )
        //{
        //    // Notes: 
        //    // Azt tekintem szónak, ami csak az angol abc betűiből áll.
        //    // Megjegyzés: van néhány karakter, amit még ki kellene zárni, mert nem betűk, de ebben a konkrét feladatban nem okoznak gondot.
        //    // Komment sor mutatja a valódi angol abc-s betűkre vonatkozó feltételt

        //    string longestString = "";
        //    int counter = 0;
        //    int length = 0;
        //    int i = 0;
        //    bool foundLogerWord = false;
        //    char[] buffer = new char[40];

        //    foreach( char c in text )
        //    {
        //        if( foundLogerWord )
        //        {
        //            longestString = "";
        //            foreach( char ch in buffer )
        //            {
        //                longestString += ch;
        //            }
        //            foundLogerWord = false;
        //        }

        //        //if ( 65 <= c && c <= 90 || 97<= c && c <=122 )
        //        if( 65 <= c && c <= 122 )
        //        {
        //            buffer[counter] = c;
        //            counter++;
        //        }
        //        else
        //        {
        //            if( length < counter )
        //            {
        //                foundLogerWord = true;
        //                length = counter;
        //            }
        //            counter = 0;
        //        }
        //    }
        //    return longestString;
        //}


        //The longest word: http://www.gutenberg.org/1/7/3/2/17321/
        //Bódi Miklós #1 Runs: 1000 Score: 5.8374108
        //---------------------------------------------
        //public string GetLongestWord( string text )
        //{
        //    string longestString = "";
        //    int wordLengthCounter = 0;
        //    int longestWordLength = 0;
        //    int longestWordStartIndex = 0;

        //    for( int i = 0; i < text.Length; i++ )
        //    {
        //        if( char.IsWhiteSpace( text[i] ) )
        //        {
        //            //ha whitespace, akkor találtunk egy szót
        //            if( longestWordLength < wordLengthCounter )
        //            {
        //                longestWordLength = wordLengthCounter;
        //                longestWordStartIndex = i - wordLengthCounter;
        //            }
        //            wordLengthCounter = 0;
        //        }
        //        else
        //        {
        //            //ha nem whitespace, akkor számolunk
        //            ++wordLengthCounter;
        //        }
        //    }
        //    longestString = text.Substring( longestWordStartIndex, longestWordLength );

        //    return longestString;
        //}


        //The longest word: Constantinopolitan
        //Für Attila #1 Runs: 1000 Score: 4.0747247
        //The longest word: Constantinopolitan
        //Für Attila #1 Runs: 10000 Score: 4.04818892
        //---------------------------------------------
        //public unsafe string GetLongestWord( string text )
        //{
        //    int LongestLength = 0;
        //    string LongestString = "";
        //    char* LongestStart = null;

        //    int CurrentLength = 0;

        //    fixed ( char* startPtr = text )
        //    {
        //        char* endPtr = startPtr + text.Length;
        //        while( endPtr != startPtr )
        //        {
        //            switch( *(--endPtr) )
        //            {
        //                case ' ':
        //                case '\n':
        //                case '/':
        //                case '[':
        //                case ']':
        //                case ',':
        //                case '.':
        //                case ':':
        //                case '\'':
        //                case '"':
        //                case '-':

        //                    if( CurrentLength > LongestLength )
        //                    {
        //                        LongestStart = endPtr;
        //                        LongestLength = CurrentLength;
        //                    }

        //                    CurrentLength = 0;
        //                    break;
        //                default:
        //                    CurrentLength++;
        //                    break;
        //            }
        //            ;
        //        }

        //        if( CurrentLength > LongestLength )
        //        {
        //            while( CurrentLength-- > 0 )
        //            {
        //                LongestString += *(endPtr++ + 1);
        //            }
        //        }
        //        else
        //        {
        //            LongestStart++;
        //            while( LongestLength-- > 0 )
        //            {
        //                LongestString += *(LongestStart++);
        //            }
        //        }
        //    }

        //    return LongestString;
        //}


    }
}
