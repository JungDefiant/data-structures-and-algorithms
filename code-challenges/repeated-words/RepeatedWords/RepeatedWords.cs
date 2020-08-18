using System;
using System.Collections.Generic;
using System.Text;
using HashTable;

namespace RepeatedWords
{
    public class RepeatedWords
    {        
        public static string CheckRepeatedWords(string str)
        {
            if (str == null) return null;
            
            Hashtable<int> wordsChecked = new Hashtable<int>(str.Length);
            char[] separators = new char[] { ',', '.', ' ' };
            string[] words = str.Split(separators);
            int wordMax = 1;
            string wordMode = words[0];
            wordsChecked.Add(wordMode, wordMax);
            for (int i = 1; i < words.Length; i++)
            {
                int value = 1;
                string w = words[i];

                if (w.Length < 1) continue;

                if (wordsChecked.Contains(w))
                {
                    value = wordsChecked.GetValue(w);
                    value++;
                    wordsChecked.Add(w, value);
                }
                else wordsChecked.Add(w, value);

                if (value > wordMax)
                {
                    wordMax = value;
                    wordMode = w;
                }
            }

            return wordMode;
        }
    }
}
