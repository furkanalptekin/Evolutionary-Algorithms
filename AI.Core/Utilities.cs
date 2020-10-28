using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;

namespace AI.Core
{
    public static class Utilities
    {
        #region ReflectionFunctionCalls
        /// <summary>
        /// Reflection ile test fonksiyonu ismine göre method çağırıyor.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="objs"></param>
        /// <returns></returns>
        private static double InvokeFunctionByName(FunctionNames name, object[] objs)
        {
            MethodInfo method = typeof(TestFunctions).GetMethod(name.ToString());
            if (method != null)
                return (double)method.Invoke(new TestFunctions(), objs);

            return double.MaxValue;
        }

        /// <summary>
        /// Reflection ile test fonksiyonu ismine göre method çağırıyor.
        /// </summary>
        /// <param name="point"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static double CalculateFunction(this Point point, FunctionNames name)
        {
            return InvokeFunctionByName(name, new object[] { point });
        }
        #endregion
        
        #region RandomValue
        /// <summary>
        /// X ve Y aralıklarına göre rasgele <see cref="Point"/> üretiyor.
        /// </summary>
        /// <param name="random"></param>
        /// <param name="limits"></param>
        /// <returns></returns>
        public static Point GenerateRandomPoint(Random random, IList<Point> limits)
        {
            return new Point(
                GenerateRandomValue(random, limits[0].X, limits[0].Y),
                GenerateRandomValue(random, limits[1].X, limits[1].Y));
        }

        /// <summary>
        /// Min ve max aralıklarına göre rasgele <see cref="double"/> üretiyor.
        /// </summary>
        /// <param name="random"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static double GenerateRandomValue(Random random, double min, double max)
        {
            return random.NextDouble() * (max - min) + min;
        }
        #endregion

        /// <summary>
        /// Olasılık oranlarına göre rasgele bir index seçiyor.
        /// </summary>
        /// <param name="random"></param>
        /// <param name="probabilities"></param>
        /// <returns></returns>
        public static int RouletteWheelSelection(Random random, double[] probabilities)
        {
            double randomNumber = random.NextDouble();
            double temp = 0;
            for (int i = 0; i < probabilities.Length; i++)
            {
                temp += probabilities[i];
                if (randomNumber < temp)
                    return i;
            }
            return 0;
        }

        /// <summary>
        /// Verilen değer limitlerin dışında ise limit sınırlarına eşitliyor.
        /// </summary>
        /// <param name="limits"></param>
        /// <param name="value"></param>
        /// <param name="valueToLimit"></param>
        /// <returns></returns>
        public static double LimitValue(IList<Point> limits, double value, string valueToLimit)
        {
            if (valueToLimit == "X")
                return value < limits[0].X ? limits[0].X : value > limits[0].Y ? limits[0].Y : value;

            return value < limits[1].X ? limits[1].X : value > limits[1].Y ? limits[1].Y : value;
        }
    }
}