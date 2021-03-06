using System;
using System.Text;

namespace CodeWars
{
    public class Kata
    {
        public static string PigIt(string str)
        {
            if (string.IsNullOrEmpty(str)) throw new ArgumentException($"{nameof(str)} is null or empty");
            var words = str.Split(' ');
            StringBuilder result = new StringBuilder();
            foreach (var word in words)
            {
                if (char.IsPunctuation(word, 0))
                {
                    result.Append(word + ' ');
                }
                else
                {
                    var lastChar = word[0];
                    var newWord = word.Remove(0, 1) + lastChar + "ay ";
                    result.Append(newWord);
                }
            }
            return result.ToString(0, result.Length - 1);
        }
    }
}
