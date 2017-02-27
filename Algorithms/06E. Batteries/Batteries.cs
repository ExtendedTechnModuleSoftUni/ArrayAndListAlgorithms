namespace _06E.Batteries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Batteries
    {
        static void Main()
        {
            var batteryCapacity = Console.ReadLine().Split().Select(double.Parse).ToList();
            var usagePerHour = Console.ReadLine().Split().Select(double.Parse).ToList();
            int hours = int.Parse(Console.ReadLine());

            int[] numberOfBatteries = GetEachBatteryNumber(batteryCapacity);
            var batteryPowerLeft = new List<double>();
            batteryPowerLeft.AddRange(batteryCapacity);
            var aliveDays = new int[batteryPowerLeft.Count];
            var negativeValues = new double[batteryPowerLeft.Count];

            for (int i = 1; i <= hours; i++)
            {
                for (int r = 0; r < batteryPowerLeft.Count; r++)
                {
                    batteryPowerLeft[r] -= usagePerHour[r];

                    if (batteryPowerLeft[r] < 0)
                    {
                        negativeValues[r] = batteryPowerLeft[r];
                        batteryPowerLeft[r] = 0;
                        aliveDays[r] = i;
                        usagePerHour[r] = 0;
                    }
                }
            }

            double[] percenteges = GetBatteryPowerLeftPercenteges(batteryCapacity, batteryPowerLeft);

            PrintResults(numberOfBatteries, batteryPowerLeft, aliveDays, negativeValues, percenteges);
        }

        private static void PrintResults(int[] numberOfBatteries, List<double> batteryPowerLeft, int[] aliveDays, double[] negativeValues, double[] percenteges)
        {
            for (int i = 0; i < numberOfBatteries.Length; i++)
            {
                if (negativeValues[i] < 0)
                {
                    Console.WriteLine("Battery {0}: dead (lasted {1} hours)", numberOfBatteries[i], aliveDays[i]);
                }
                else
                {
                    Console.WriteLine("Battery {0}: {1:f2} mAh ({2:f2})%", numberOfBatteries[i], batteryPowerLeft[i], percenteges[i]);
                }
            }
        }

        private static double[] GetBatteryPowerLeftPercenteges(List<double> batteryCapacity, List<double> batteryPowerLeft)
        {
            var percenteges = new double[batteryPowerLeft.Count];

            for (int i = 0; i < batteryCapacity.Count; i++)
            {
                percenteges[i] = ((batteryPowerLeft[i] * 100.0) / batteryCapacity[i]);
            }

            return percenteges;
        }

        private static int[] GetEachBatteryNumber(List<double> batteryCapacity)
        {
            var numberOfBatteries = new int[batteryCapacity.Count];

            for (int i = 1; i <= batteryCapacity.Count; i++)
            {
                numberOfBatteries[i - 1] = i;
            }

            return numberOfBatteries;
        }
    }
}
