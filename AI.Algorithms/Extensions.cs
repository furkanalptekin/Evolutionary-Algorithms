using AI.Core;
using System;
using System.Windows;

namespace AI.Algorithms
{
    public static class Extensions
    {
        /// <summary>
        /// ABC için besinlerin fitness değerlerini hesaplıyor.
        /// </summary>
        /// <param name="point"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static double CalculateFitnessFunction(this Point point, FunctionNames name)
        {
            var MinimizeFunction = point.CalculateFunction(name);
            if (MinimizeFunction == double.MaxValue)
                return double.MaxValue;

            if (MinimizeFunction >= 0)
                return 1 / (1 + MinimizeFunction);

            return 1 + Math.Abs(MinimizeFunction);
        }
    }
}