using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV04
{
    internal class StringStatistics
    {
        private string text { get; set; }

        public StringStatistics(string text)
        {
            this.text = text;
        }

        public int wordsCount()
        {
            string[] wordsArray = text.Split();
            /*foreach (string word in wordsArray)
            
                Console.WriteLine(word);
            }*/
            return wordsArray.Length;
        }

        public int RowCount()
        {
            string[] lineArray = text.Split('\n');
            return lineArray.Length;
        }       
        public int sentenceCount()
        {
            bool flag = false;
            int count = -1;
            foreach (char itm in text)
            {
                if (char.IsUpper(itm))
                    flag = true;                  
                if ((itm == '.' || itm == '?' || itm == '!') && flag)
                    count++;                
            }
            return count;   
        }

        public StringBuilder shortesWord()
        {            
            string[] wordsArray = text.Split();
            StringBuilder shortestWords = new StringBuilder();
            int shortestLength = wordsArray[0].Length;
            foreach (string word in wordsArray)
            {
                if (word.Length < shortestLength)
                    shortestLength = word.Length;
            } 
            foreach (string word in wordsArray)
            {
                if (word.Length == shortestLength)
                    shortestWords.Append(word);
            }

            return shortestWords;
        }

        public StringBuilder longestWord()
        {
            string[] wordsArray = text.Split();
            StringBuilder shortestWords = new StringBuilder();
            int shortestLength = 0;
            foreach (string word in wordsArray)
            {
                if (word.Length > shortestLength)
                    shortestLength = word.Length;
            }
            foreach (string word in wordsArray)
            {
                if (word.Length == shortestLength)
                    shortestWords.Append(word);
            }

            return shortestWords;
        }

        public string[] sorted()
        {
            string[] wordsArray = text.Split();
            var charsToRemove = new char[] { ',', ')', '.', '!', '(', '?'};
            for (int i = 0; i < wordsArray.Length; i++)
            {
                wordsArray[i] = wordsArray[i].Trim(charsToRemove);
            }
            Array.Sort(wordsArray);
            return wordsArray;
        }

        public string occurances()
        {
            int count = 0;
            string word = "";
            int best = 0;
            for (int i = 1; i < wordsCount(); i++)
            {
                if (sorted()[i] == sorted()[i - 1]) count++;
                else
                {
                    if (best < count)
                    {
                        word = sorted()[i - 1];
                        best = count;
                        count = 0;
                    }
                }
            }

            return word;
        }


    }   
}
