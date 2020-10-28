using System;
using System.Windows;

namespace AI.Core
{
    public class TestFunctions
    {
        public double ACKLEYS_FUNCTION(Point point)
        {
            return -20 * Math.Exp(-0.2 * Math.Sqrt(0.5 * (Math.Pow(point.X, 2) + Math.Pow(point.Y, 2)))) - Math.Exp(0.5 * (Math.Cos(2 * Math.PI * point.X) + Math.Cos(2 * Math.PI * point.Y))) + Math.E + 20;
        }

        public double BEALES_FUNCTION(Point point)
        {
            return Math.Pow(1.5 - point.X + point.X * point.Y, 2) + Math.Pow(2.25 - point.X + point.X * Math.Pow(point.Y, 2), 2) + Math.Pow(2.625 - point.X + point.X * Math.Pow(point.Y, 3), 2);
        }

        public double GOLDSTEIN_PRICE_FUNCTION(Point point)
        {
            return (1 + Math.Pow(point.X + point.Y + 1, 2) * (19 - 14 * point.X + 3 * Math.Pow(point.X, 2) - 14 * point.Y + 6 * point.X * point.Y + 3 * Math.Pow(point.Y, 2))) * (30 + Math.Pow(2 * point.X - 3 * point.Y, 2) * (18 - 32 * point.X + 12 * Math.Pow(point.X, 2) + 48 * point.Y - 36 * point.X * point.Y + 27 * Math.Pow(point.Y, 2)));
        }

        public double BOOTHS_FUNCTION(Point point)
        {
            return Math.Pow(point.X + 2 * point.Y - 7, 2) + Math.Pow(2 * point.X + point.Y - 5, 2);
        }

        public double BUKIN_FUNCTION(Point point)
        {
            return 100 * Math.Sqrt(Math.Abs(point.Y - (0.01 * Math.Pow(point.X, 2)))) + 0.01 * Math.Abs(point.X + 10);
        }

        public double MATYAS_FUNCTION(Point point)
        {
            return 0.26 * (Math.Pow(point.X, 2) + Math.Pow(point.Y, 2)) - 0.48 * point.X * point.Y;
        }

        public double LÉVI_FUNCTION(Point point)
        {
            return Math.Pow(Math.Sin(3 * Math.PI * point.X), 2) + Math.Pow(point.X - 1, 2) * (1 + Math.Pow(Math.Sin(3 * Math.PI * point.Y), 2)) + Math.Pow(point.Y - 1, 2) * (1 + Math.Pow(Math.Sin(2 * Math.PI * point.Y), 2));
        }

        public double THREE_HUMP_CAMEL(Point point)
        {
            return 2 * Math.Pow(point.X, 2) - 1.05 * Math.Pow(point.X, 4) + Math.Pow(point.X, 6) / 6 + point.X * point.Y + Math.Pow(point.Y, 2);
        }

        public double EASOM_FUNCTION(Point point)
        {
            return -Math.Cos(point.X) * Math.Cos(point.Y) * Math.Exp(-(Math.Pow(point.X - Math.PI, 2) + Math.Pow(point.Y - Math.PI, 2)));
        }

        public double CROSS_IN_TRAY_FUNCTION(Point point)
        {
            return -0.0001 * Math.Pow(Math.Abs(Math.Sin(point.X) * Math.Sin(point.Y) * Math.Exp(Math.Abs(100 - Math.Pow(Math.Pow(point.X, 2) + Math.Pow(point.Y, 2), 1 / 2) / Math.PI))) + 1, 0.1);
        }

        public double EGGHOLDER_FUNCTION(Point point)
        {
            return -(point.Y + 47) * Math.Sin(Math.Sqrt(Math.Abs(point.X / 2 + (point.Y + 47)))) - point.X * Math.Sin(Math.Sqrt(Math.Abs(point.X - (point.Y + 47))));
        }

        public double HÖLDER_TABLE_FUNCTION(Point point)
        {
            return -Math.Abs(Math.Sin(point.X) * Math.Cos(point.Y) * Math.Exp(Math.Abs(1 - Math.Sqrt(Math.Pow(point.X, 2) + Math.Pow(point.Y, 2)) / Math.PI)));
        }

        public double MCCORMICK_FUNCTION(Point point)
        {
            return Math.Sin(point.X + point.Y) + Math.Pow(point.X - point.Y, 2) - 1.5 * point.X + 2.5 * point.Y + 1;
        }

        public double SCHAFFER_FUNCTION_N2(Point point)
        {
            return 0.5 + (Math.Pow(Math.Sin(Math.Pow(point.X, 2) - Math.Pow(point.Y, 2)), 2) - 0.5) / Math.Pow(1 + 0.001 * (Math.Pow(point.X, 2) + Math.Pow(point.Y, 2)), 2);
        }

        public double SCHAFFER_FUNCTION_N4(Point point)
        {
            return 0.5 + (Math.Pow(Math.Cos(Math.Sin(Math.Abs(Math.Pow(point.X, 2) - Math.Pow(point.Y, 2)))), 2) - 0.5) / Math.Pow(1 + 0.001 * (Math.Pow(point.X, 2) + Math.Pow(point.Y, 2)), 2);
        }

        public double SIMIONESCU_FUNCTION(Point point)
        {
            double rT = 1, rS = 0.2, n = 8;
            if (Math.Pow(point.X, 2) + Math.Pow(point.Y, 2) <= Math.Pow(rT + rS * Math.Cos(n * Math.Atan(point.X / point.Y)), 2))
                return 0.1 * point.X * point.Y;

            return float.MaxValue;
        }
    }
}