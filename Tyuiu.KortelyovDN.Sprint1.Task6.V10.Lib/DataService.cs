using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KortelyovDN.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {

            if (string.IsNullOrEmpty(value))
            {
                return value;
            }

            string[] words = value.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                int len = words[i].Length;

                if (len % 2 != 0 && len > 0)
                {
                    int mid = len / 2; 
                    words[i] = words[i].Remove(mid, 1); 
                }
            }
            return string.Join(" ", words);
        }
    }
}