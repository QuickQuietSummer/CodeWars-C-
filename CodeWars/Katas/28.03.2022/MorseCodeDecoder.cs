using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Katas._28._03._2022
{
    public class MorseCodeDecoder
    {
        public static string Decode(string morseCode)
        {
            var result = "";
            var words = morseCode.Split(new[] {"  "}, StringSplitOptions.None);
            
            foreach (var word in words)
            {
                var letters = word.Trim().Split(' ');
                var translatedWord = letters.Aggregate("", (current, letter) => current + MorseCode.Get(letter));

                result += " " + translatedWord;
            }

            result = result.Trim();

            return result;
        }
    }

    public static class MorseCode
    {
        public static string Get(string str)
        {
            return _morse.FirstOrDefault(x => x.Value == str).Key.ToString();
        }

        static Dictionary<char, String> _morse = new Dictionary<char, String>()
        {
            {'A', ".-"},
            {'B', "-..."},
            {'C', "-.-."},
            {'D', "-.."},
            {'E', "."},
            {'F', "..-."},
            {'G', "--."},
            {'H', "...."},
            {'I', ".."},
            {'J', ".---"},
            {'K', "-.-"},
            {'L', ".-.."},
            {'M', "--"},
            {'N', "-."},
            {'O', "---"},
            {'P', ".--."},
            {'Q', "--.-"},
            {'R', ".-."},
            {'S', "..."},
            {'T', "-"},
            {'U', "..-"},
            {'V', "...-"},
            {'W', ".--"},
            {'X', "-..-"},
            {'Y', "-.--"},
            {'Z', "--.."},
            {'0', "-----"},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."},
        };
    }
}