//Friday 22nd December 2023
//Problem 98 - Anagramic Squares
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace PEProject9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("C:/Users/44784/OneDrive/Documents/words.txt");
            List<string> words = new List<string>();           
            string lineToRead = reader.ReadLine();
            string currentWord = "";
            for (int i = 0; i < lineToRead.Length; i++) ///Luckily its just one line
            {
                if (lineToRead[i] == ',')
                {
                    words.Add(currentWord);
                    currentWord = "";
                }
                else
                {
                    if (lineToRead[i] != '"')
                    {
                        currentWord += lineToRead[i];
                    }
                }
            }
            Console.WriteLine(words.Count);
            Console.ReadLine();
            ///All words are added now
            ///We need to look for permutations, sort?
            for (int i = 0; i < words.Count; i++)
            {
                char[] characters = words[i].ToArray();
                Array.Sort(characters);
                words[i] = new string(characters);
            }
            Console.WriteLine(words.Count);
            Console.ReadLine();
            ///Check if duplicates exist, if not remove them
            int counter = 0;
            string placeHolder = "";
            bool change = false;
            do
            {
              
                placeHolder = words[counter];
                words.Remove(placeHolder);
                if (words.Contains(placeHolder))
                {
                    words.Add(placeHolder);
                    change = true;
                }
                counter += 1;
                if (counter == words.Count)
                {
                    counter = 0;
                    change = false;
                }
            } while (change == false);
            Console.WriteLine(words.Count);
            Console.ReadLine();
            words.Sort();
            int longestLength = 0;
            for (int i = 0; i < words.Count; i++)
            {              
                if (words[i].Length > longestLength)
                {
                    longestLength = words[i].Length;
                    placeHolder = words[i];
                }
                else {words.Remove(words[i]); }
                Console.WriteLine(words[i]);
            }
            Console.WriteLine(placeHolder + " " + longestLength);
            Console.ReadLine();
        }
    }
}