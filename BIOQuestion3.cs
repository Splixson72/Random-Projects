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
            //The score is 5, biggest letter is E
            //Then D, current score 1, all there is A
            //Then C, all there is is B or A, A leads to another A so it doesnt work
            //Then B, all there is C,B,A; B doesn't work, and A (current score 2) leads to another B count it
            //The A, leads to D,C,B,A; C leads to another A, B leads to an AorB, both of which don't work, and A doesn't work
            ///Final total - 7
            nextLetter(score, 0, "", wordList, score);
            Console.WriteLine("The number of ways is: " + wordList.Count);
            wordList.Sort();
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < wordList.Count; i++)
            {
                Console.WriteLine(wordList[i]);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine((wordList.IndexOf(word)+1) + " is your final score");
            Console.ReadLine();
        }
        static string nextLetter(int currentScore, int lastLetter, string currentWord, List<string> wordList, int score)
        {
            if (currentScore == 0)
            {
                //Console.WriteLine(currentWord);
                return currentWord;
            }
            for (int i = currentScore; i > 0; i--)
            {
                //Console.Write(i + " " + currentScore);
                //Console.ReadLine();
                if (currentScore - i >= 0 && i != lastLetter)
                {
                    //currentWord += Convert.ToChar(i + 64);
                    //.WriteLine(Convert.ToChar(i + 64));
                    //lastLetter = Convert.ToChar(i + 64);
                    //currentScore -= i;
                    if (nextLetter(currentScore - i, i, currentWord + Convert.ToChar(i + 64), wordList, score).Length > 0)
                    {
                        lastLetter = i;
                        wordList.Add(nextLetter(currentScore - i, lastLetter, currentWord + Convert.ToChar(i + 64), wordList, score));
                    }                   
                    currentScore = score;
                    currentWord = "";
                    lastLetter = 0;
                }
            }
            Console.WriteLine("over.");
            return "";
        }
    }
}
