namespace _03E.SortArrayOfStrings
{
    using System;
    using System.Linq;

    class SortArrayOfStrings
    {
        static void Main()
        {
            var wordsLine = Console.ReadLine().Split(' ').ToArray();
            bool swaped = false;

            swaped = ImplementBubbleSortAlgorithm(wordsLine);

            Console.WriteLine(string.Join(" ", wordsLine));
        }

        private static bool ImplementBubbleSortAlgorithm(string[] wordsLine)
        {
            bool swaped;
            do
            {
                swaped = false;

                for (int i = 0; i < wordsLine.Length - 1; i++)
                {
                    int next = i + 1;
                    int current = i;

                    int biggerString = wordsLine[next].CompareTo(wordsLine[current]);

                    if (biggerString == -1)
                    {
                        string temp = wordsLine[current];
                        wordsLine[current] = wordsLine[next];
                        wordsLine[next] = temp;
                        swaped = true;
                    }
                }
            } while (swaped);
            return swaped;
        }
    }
}
