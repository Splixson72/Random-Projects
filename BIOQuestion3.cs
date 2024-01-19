using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIOQuestion3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> wordList = new List<string>();
            Console.Write("Enter a word: ");
            string word = Console.ReadLine().ToUpper();
            int score = 0;
            for (int i = 0; i < word.Length; i++)
            {
                score += Convert.ToInt32(word[i] - 64);
            }
            Console.WriteLine(score);
            char lastLetter = ' ';
            string currentWord = "";
            nextLetter(score, lastLetter,currentWord, wordList, score);
            Console.WriteLine(wordList.Count);
            Console.ReadLine();
        }
        static string nextLetter(int currentScore, char lastLetter, string currentWord, List<string> wordList, int score)
        {     
            for (int i = score; i > 0 ; i--)
            {
                Console.WriteLine(i + " " + currentScore);
                Console.ReadLine();
                if (currentScore - i >= 0 && i != Convert.ToInt32(lastLetter)-64)
                {
                    currentWord += Convert.ToChar(i + 64);
                    Console.WriteLine(Convert.ToChar(i + 64));
                    lastLetter = Convert.ToChar(i + 64);
                    currentScore -= i;
                    wordList.Add(nextLetter(currentScore, lastLetter, currentWord, wordList, score));
                    currentScore = score;
                    currentWord = "";
                    lastLetter = ' ';
                }
            }
            if (currentScore == 0)
            {
                Console.WriteLine(currentWord);
                return currentWord;
            }
            return "";
        }
    }
}
