using System;
using System.Collections.Generic;

namespace CountVowelsModularized
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence to count the vowels of: ");
            string sentence = Console.ReadLine();
            Console.WriteLine("{0} contains {1} vowels", sentence, VowelCount(sentence));
        }

        static int VowelCount(string sentence)
        {
            HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            sentence = sentence.ToLower();
            int vowelCount = 0;
            for (int i = 0; i < sentence.Length; ++i)
            {
                if (vowels.Contains(sentence[i]))
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }
    }
}
