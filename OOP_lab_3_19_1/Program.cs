using System;

namespace OOP_lab_3_19_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string[] words = str.Split(new char[] { '\n', '\r', ' ', ':', ';', '.', ',', '?', '!', '(', ')', '{', '}', '[', ']', '@', '#', '№', '$', '^', '%', '&', '*', '/', '|' }, StringSplitOptions.RemoveEmptyEntries);

            int[] count = new int[words.Length];

            for (int i = 0; i < count.Length; ++i)
            {
                count[i] = 1;
            }

            for (int i = 0; i < words.Length; ++i)
            {
                for (int j = i + 1; j < words.Length; ++j)
                {
                    if (words[i] == words[j])
                    {
                        ++count[i];

                        count[j] = -999999999;
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < count.Length; ++i)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine("{0} - {1}", words[i], count[i]);
                }
            }

            Console.WriteLine("\nКiлькiсть використаних символiв: {0}", str.Length);
        }
    }
}
