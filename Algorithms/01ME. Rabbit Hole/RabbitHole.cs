namespace _01ME.Rabbit_Hole
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class RabbitHole
    {
        static void Main()
        {
            var obstaclesArray = Console.ReadLine().Split().ToList();
            int energy = int.Parse(Console.ReadLine());

            int currentIndex = 0;
            bool isDeadFromBomb = false;

            while (energy > 0)
            {
                string[] command = obstaclesArray[currentIndex].Split('|');

                if (obstaclesArray[currentIndex].Contains("Left"))
                {
                    currentIndex = JumpLeft(command, energy, currentIndex, obstaclesArray);
                    energy -= int.Parse(command[1]);
                }
                else if (obstaclesArray[currentIndex].Contains("Right"))
                {
                    currentIndex = JumpRight(command, energy, currentIndex, obstaclesArray);
                    energy -= int.Parse(command[1]);
                }
                else if (obstaclesArray[currentIndex].Contains("Bomb"))
                {
                    energy -= int.Parse(command[1]);
                    obstaclesArray.RemoveAt(currentIndex);
                    currentIndex = 0;

                    if (energy <= 0)
                    {
                        isDeadFromBomb = true;
                    }
                }
                else if (obstaclesArray[currentIndex].Contains("RabbitHole"))
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    return;
                }

                if (obstaclesArray[obstaclesArray.Count - 1] != "RabbitHole")
                {
                    obstaclesArray.RemoveAt(obstaclesArray.Count - 1);
                }

                obstaclesArray.Add("Bomb|" + energy);
            }

            if (isDeadFromBomb)
            {
                Console.WriteLine("You are dead due to bomb explosion!");
            }
            else
            {
                Console.WriteLine("You are tired. You can't continue the mission.");
            }
        }

        private static int JumpLeft(string[] command, int energy, int currentIndex, List<string> obstaclesArray)
        {
            int cellPossition = Math.Abs(int.Parse(command[1]) - currentIndex) % obstaclesArray.Count;

            return cellPossition;
        }

        private static int JumpRight(string[] command, int energy, int currentIndex, List<string> obstaclesArray)
        {
            int cellPossition = (int.Parse(command[1]) + currentIndex) % obstaclesArray.Count;

            return cellPossition;
        }
    }
}
