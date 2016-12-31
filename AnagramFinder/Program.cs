using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            AnagramCounter("pio");
            Console.ReadKey();
        }

        static int AnagramCounter(string word)
        {
            char[] charArray = word.ToCharArray();
            string[] anagram = new string[FindFactorial(charArray.Length)];
            int counter = 0;
            int number = 0;
            Random rand = new Random();
            for(int i = 0; i < charArray.Length; i++)
            {
                anagram[counter] = charArray[i].ToString();
                for(int j = 0; j < FindFactorial(charArray.Length); j++)
                {
                    number = rand.Next(0, charArray.Length - 1);
                    if (charArray[number] != charArray[i])
                    {
                        anagram[counter] += charArray[number]; ;
                    }
                    for(int y = 0; i < counter; i++)
                    {
                        if(anagram[y] == anagram[counter])
                        {
                            j--;
                            anagram[counter] = charArray[i].ToString();
                            counter--;
                        }
                    }
                    counter++;
                }
            }

            foreach(string w in anagram)
            {
                Console.WriteLine(w);
            }
            return FindFactorial(charArray.Length);
        }

        static int FindFactorial(int number)
        {
            if (number == 1) return 1;
            else return FindFactorial(number - 1) * number;
        }
    }
}
