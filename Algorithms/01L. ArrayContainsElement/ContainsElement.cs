namespace _01L.ArrayContainsElement
{
    using System;
    using System.Linq;

    class ContainsElement
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int num = int.Parse(Console.ReadLine());

            bool found = false;

            foreach (var number in numbers)
            {
                if (number == num)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
