namespace _05E.DecodeRadioFrequencies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class DecodeRadioFrequencies
    {
        static void Main()
        {
            var frequencies = Console.ReadLine().Split(new char[] { ' ', '.' }).Select(int.Parse).ToList();
            var resultList = new List<char>();
            DecodeFrequencies(frequencies, resultList);

            Console.WriteLine(string.Join("", resultList));
        }

        private static void DecodeFrequencies(List<int> frequencies, List<char> resultList)
        {
            int insertIndex = 0;

            for (int i = 0; i < frequencies.Count; i++)
            {
                if (frequencies[i] != 0 && i % 2 == 0)
                {
                    resultList.Insert(insertIndex, (char)(frequencies[i]));
                }
                else if (frequencies[i] != 0)
                {
                    resultList.Insert(insertIndex, (char)(frequencies[i]));
                    char temp = resultList[insertIndex];
                    resultList[insertIndex] = resultList[insertIndex + 1];
                    resultList[insertIndex + 1] = temp;
                    insertIndex++;
                }
            }
        }
    }
}
