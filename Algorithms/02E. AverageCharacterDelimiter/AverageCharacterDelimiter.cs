namespace _02E.AverageCharacterDelimiter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AverageCharacterDelimiter
    {
        static void Main()
        {
            var inputString = Console.ReadLine().Split(' ').ToArray();
            int sum = 0;
            var charArray = new List<char>();

            FillingCharArray(inputString, charArray);
            sum = SumCharArrayElements(sum, charArray);

            string delimeter = GetDelimeterChar(sum, charArray);

            Console.WriteLine(string.Join($"{delimeter}", inputString));
        }

        private static string GetDelimeterChar(int sum, List<char> charArray)
        {
            int asciiNumber = sum / charArray.Count;
            string delimeter = ((char)asciiNumber).ToString().ToUpper();
            return delimeter;
        }

        private static int SumCharArrayElements(int sum, List<char> charArray)
        {
            foreach (var item in charArray)
            {
                sum += item;
            }

            return sum;
        }

        private static void FillingCharArray(string[] inputString, List<char> charArray)
        {
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] != " ")
                {
                    charArray.AddRange(inputString[i]);
                }
            }
        }
    }
}
