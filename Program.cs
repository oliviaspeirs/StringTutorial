using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines =
            {
                "        It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife.   ",  // Pride and Prejudice
                "   Look like the innocent flower, but be the serpent under it.                                                                  ",  // Macbeth
                "  O Romeo, Romeo! wherefore art thou Romeo?                                                                                     ",  // Romeo and Juliet
                "Vex not his ghost: O, let him pass! he hates him                                                                                ",  // Othello
                "Exceeding expectations is the root of all excellence.                                                                           ",  // Inspired by various works
                "Objects, classes, methods – these define the essence of programming.                                                            ",  // Custom added
                "Being is the essence of life, and code is the language of machines.                                                             ",  // Custom added
                "Join not with grief, for time heals all things.                                                                                 "   // Inspired by classical wisdom
            };
            // The result variable would store the hidden message
            string result = "";

            // Processing each line and extracting a character
            foreach (string line in lines)
            {
                // Step 1: Trim spaces

                // Step 2: Convert to lowercase

                // Step 3: remove punctuation

                // Step 4: Find the first vowel and extract it

                // Step 5: Append the character to the final result
            }

            // Final step: Correct spacing and formatting

            // Display final message
            Console.WriteLine("Final Message: "+result);
        }
    }
}
