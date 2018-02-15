using System;
using System.Collections.Generic;

namespace Sharp.Models
{
    public static class Kata
    {
        static Kata()
        {
            
        }
        public static string AlphabetPosition(string text)
        {
            const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string outstring = string.Empty;
            foreach (char item in text)
            {
                outstring+= char.IsLetter(item) ? Alphabet.IndexOf(item.ToString(), StringComparison.CurrentCultureIgnoreCase) + 1 + " " : "";
            }
            return outstring.Trim();
        }
    } 
    
}