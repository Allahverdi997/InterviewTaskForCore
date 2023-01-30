using System;
using System.Collections.Generic;

namespace PITaskDemoLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToUpper();


            //First Version
            //var letters = new List<char>();

            //letters.Add('T');
            //letters.Add('E');
            //letters.Add('S');

            //Dictionary<char, int> keyValues = new Dictionary<char, int>();


            //foreach (var item in word)
            //{
            //    if(letters.Contains(item))
            //    {
            //        int count = 0;
            //        keyValues.TryGetValue(item, out count);
            //        if (count == 0)
            //        {
            //            keyValues.Add(item, 1);
            //        }
            //        else
            //        {
            //            count = keyValues[item];
            //            count++;
            //            keyValues[item] = count;
            //        }
            //    }
            //}

            //foreach (var item in keyValues)
            //{
            //    Console.WriteLine($"{item.Key}-{item.Value}");
            //}


            //Second Version
            Dictionary<char, int> keyValues = new Dictionary<char, int>();


            foreach (var item in word)
            {
                if (65 <= (int)item && (int)item <= 90)
                {
                    int count = 0;
                    keyValues.TryGetValue(item, out count);
                    if (count == 0)
                    {
                        keyValues.Add(item, 1);
                    }
                    else
                    {
                        count = keyValues[item];
                        count++;
                        keyValues[item] = count;
                    }
                }
            }

            foreach (var item in keyValues)
            {
                Console.WriteLine($"{item.Key}-{item.Value}");
            }

        }
    }
}
