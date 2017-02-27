namespace _04E.ArrayHistogram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ArrayHistogram
    {
        static void Main()
        {
            var wordsLine = Console.ReadLine().Split(' ').ToArray();
            var words = new List<string>();
            var occurrencesCount = new List<int>();

            FillingWordsAndOccurencesCountLists(wordsLine, words, occurrencesCount);
            SortListsInDescendingOrder(words, occurrencesCount);
            PrintResult(wordsLine, words, occurrencesCount);
        }

        private static void PrintResult(string[] wordsLine, List<string> words, List<int> occurrencesCount)
        {
            for (int i = 0; i < words.Count; i++)
            {
                double percentage = (occurrencesCount[i] * 100.0) / wordsLine.Length;
                Console.WriteLine($"{words[i]} -> {occurrencesCount[i]} times ({percentage:f2}%)");
            }
        }

        private static void SortListsInDescendingOrder(List<string> words, List<int> occurrencesCount)
        {
            bool check = false;

            for (int i = 0; i < words.Count - 1; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    string currentWord = words[j - 1];
                    int currentCount = occurrencesCount[j - 1];
                    string nextWord = words[j];
                    int nextCount = occurrencesCount[j];

                    if (nextCount > currentCount)
                    {
                        occurrencesCount[j] = currentCount;
                        occurrencesCount[j - 1] = nextCount;
                        check = true;

                        if (check)
                        {
                            words[j - 1] = nextWord;
                            words[j] = currentWord;
                        }
                    }

                    j--;
                }
            }
        }

        private static void FillingWordsAndOccurencesCountLists(string[] wordsLine, List<string> words, List<int> occurrencesCount)
        {
            for (int i = 0; i < wordsLine.Length; i++)
            {

                if (!words.Contains(wordsLine[i]))
                {
                    words.Add(wordsLine[i]);
                    occurrencesCount.Add(1);

                }
                else
                {
                    occurrencesCount[words.IndexOf(wordsLine[i])]++;
                }
            }
        }
    }
}
