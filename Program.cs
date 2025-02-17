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

            bool inputValid = false;
            while (!inputValid)
            {
                try
                {
                    Console.WriteLine("Enter a string to encrypt:");
                    string userInput = Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid string");
                }
                catch (Exception)
                {
                    Console.WriteLine("Unknown error, try again");
                }
                finally
                {
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                }
            }
        }

        static string EncryptString(string inputString)
        {
            // Guard clause to check if input is a valid string
            if (string.IsNullOrEmpty(inputString))
            {
                throw new ArgumentNullException(nameof(inputString), "cant' be null.");
            }
            // Reverse the string
            

            // Convert every second charatcer to uppercase
           

            // Interpolateion and concatenation
          

            // String conversion using ASCII values to shift each character by 1
            
            
            string finalEncryption = new string(finalEncryptionChars);
            return finalEncryption;
        }
    }
}
