namespace _03ME.IncreasingCrisis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class IncreasingCrisis
    {
        static void Main()
        {
            int numberOfSequences = int.Parse(Console.ReadLine());
            var increasingSequence = new List<int>();

            for (int i = 0; i < numberOfSequences; i++)
            {
                var currentSequence = Console.ReadLine().Split().Select(int.Parse).ToList();

                AddingCurrentSequence(increasingSequence, i, currentSequence);
            }

            Console.WriteLine(string.Join(" ", increasingSequence));
        }

        private static void AddingCurrentSequence(List<int> increasingSequence, int i, List<int> currentSequence)
        {
            if (i != 0)
            {
                int firstFromCurrentSequence = currentSequence.First();
                int mostRightLowerElement = increasingSequence.Last(last => last <= firstFromCurrentSequence);
                int insertingIndex = increasingSequence.LastIndexOf(mostRightLowerElement);

                for (int r = 0; r < currentSequence.Count; r++)
                {
                    insertingIndex++;
                    increasingSequence.Insert(insertingIndex, currentSequence[r]);

                    if (r < currentSequence.Count - 1 && currentSequence[r] > currentSequence[r + 1])
                    {
                        increasingSequence.RemoveRange(insertingIndex + 1, (increasingSequence.Count - 1) - insertingIndex);
                        break;
                    }
                }

            }
            else
            {
                increasingSequence.AddRange(currentSequence);
            }
        }
    }
}
