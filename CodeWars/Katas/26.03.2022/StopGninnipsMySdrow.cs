using System;
using System.Linq;

namespace CodeWars.Katas._26._03._2022
{
    public class StopGninnipsMySdrow
    {
        public static string SpinWords(string sentence)
        {
            var wordsArray = sentence
                .Split(' ')
                .Select(word =>
                {
                    if (word.Length < 5) return word;
                    var letters = word.ToCharArray();
                    Array.Reverse(letters);
                    return new string(letters);
                });
            return string.Join(" ", wordsArray);
        }
    }
}