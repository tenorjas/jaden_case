using System;

namespace jaden_case
{
    public static class JadenCase
    {
        public static string phrase {get; set;}
        public static string ToJadenCase(string phrase)
        {
            if (string.IsNullOrWhiteSpace(phrase))
            {
                throw new ArgumentException("message", nameof(phrase));
            }

            string[] characters = phrase.Split("");
            Console.WriteLine(characters);
            string jadenString = "";
            return jadenString;
        }
    }
}