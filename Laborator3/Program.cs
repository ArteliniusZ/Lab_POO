using System;

namespace Lab3POO
{
    public static class Text
    {

 

        public static int countSentences(string text)
        {
            int sentence = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.' || text[i] == '?' || text[i] == '!')
                {
                    sentence++;
                }
            }
            return sentence;
        }

        public static int countWords(string text)
        {
            int count = 1;
            for (int i = 0; i <= text.Length - 1; i++)
            {
                if (text[i] == ' ' && text[i + 1] != ' ')
                {
                    count++;
                }
            }
            return count;
        }

        public static int countLetters(string text)
        {
            int letter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                    letter++;
            }
            return letter;
        }


        public static int countVowels(string text)
        {
            int vowel = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'A' || text[i] == 'a' || text[i] == 'E' || text[i] == 'e'
                        || text[i] == 'I' || text[i] == 'i' || text[i] == 'O'
                        || text[i] == 'o' || text[i] == 'U' || text[i] == 'u')
                {
                    vowel++;
                }
            }
            return vowel;
        }

        public static int countConsonants(string text)
        {
            return (countLetters(text) - countVowels(text)) / 2;
        }


        public static string getLongest(string text)
        {
            string[] words = text.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (string s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }
            return word;
        }

        class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Basic Level:");
                Console.WriteLine("Enter your text here:");

                string Scanner = Console.ReadLine();

                string text = Scanner;




                Console.WriteLine("Number of sentences: " + Text.countSentences(text));
                Console.WriteLine("Number of words:" + Text.countWords(text));

                Console.WriteLine("\nAdvanced Level (1):");
                Console.WriteLine("Letters: " + Text.countLetters(text));
                Console.WriteLine("Vowels: " + Text.countVowels(text));
                Console.WriteLine("Consonants: " + Text.countConsonants(text));

                Console.WriteLine("\nAdvanced Level (2):");
                Console.WriteLine("Longest word is: " + Text.getLongest(text));

            }
        }
    }
}



    

