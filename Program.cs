﻿using System;


namespace jaden_case
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(ToJadenCase("How can mirrors be real if our eyes aren't real"));
        }

        private static string ToJadenCase(string phrase)
        {
            if (string.IsNullOrWhiteSpace(phrase))
            {
                throw new ArgumentException("message", nameof(phrase));
            }

            char[] characters = phrase.ToCharArray();
            foreach (var item in characters)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i] == ' ')
                {
                    Char.ToUpper(characters[i+1]);
                }
            }
            foreach (var item in characters)
            {
                Console.WriteLine(item);
            }
            string jadenString = "";
            return jadenString;
        }
    }
}
