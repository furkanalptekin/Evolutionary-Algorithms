using System.Windows;
using System.Collections.Generic;

namespace AI.Core
{
    public static class FunctionLimits
    {
        private static readonly Dictionary<FunctionNames, IList<Point>> _functionLimits = new Dictionary<FunctionNames, IList<Point>>
        {
            { 
                FunctionNames.ACKLEYS_FUNCTION, 
                CreateList(-5, 5) 
            },
            { 
                FunctionNames.BEALES_FUNCTION, 
                CreateList(-4.5, 4.5)
            },
            { 
                FunctionNames.GOLDSTEIN_PRICE_FUNCTION, 
                CreateList(-2, 2)
            },
            { 
                FunctionNames.BOOTHS_FUNCTION, 
                CreateList(-10, 10)
            },
            { 
                FunctionNames.BUKIN_FUNCTION, 
                CreateList(-15, -5, -3, 3)
            },
            { 
                FunctionNames.MATYAS_FUNCTION,
                CreateList(-10, 10)
            },
            { 
                FunctionNames.LÉVI_FUNCTION,
                CreateList(-10, 10) 
            },
            { 
                FunctionNames.THREE_HUMP_CAMEL, 
                CreateList(-5, 5) 
            },
            { 
                FunctionNames.EASOM_FUNCTION,
                CreateList(-100, 100)
            },
            { 
                FunctionNames.CROSS_IN_TRAY_FUNCTION, 
                CreateList(-10, 10) 
            },
            { 
                FunctionNames.EGGHOLDER_FUNCTION, 
                CreateList(-512, 512) 
            },
            { 
                FunctionNames.HÖLDER_TABLE_FUNCTION,
                CreateList(-10, 10) 
            },
            { 
                FunctionNames.MCCORMICK_FUNCTION, 
                CreateList(-1.5, 4, -3, 4) 
            },
            { 
                FunctionNames.SCHAFFER_FUNCTION_N2, 
                CreateList(-100, 100) 
            },
            { 
                FunctionNames.SCHAFFER_FUNCTION_N4, 
                CreateList(-100, 100) 
            },
            { 
                FunctionNames.SIMIONESCU_FUNCTION, 
                CreateList(-1.25, 1.25) 
            }
        };

        public static IList<Point> GetLimits(FunctionNames name)
        {
            if (_functionLimits.TryGetValue(name, out IList<Point> limits))
                return limits;

            return null;
        }

        private static IList<Point> CreateList(double min, double max)
        {
            return new List<Point> { new Point(min, max), new Point(min, max) };
        }

        private static IList<Point> CreateList(double xMin, double xMax, double yMin, double yMax)
        {
            return new List<Point> { new Point(xMin, xMax), new Point(yMin, yMax) };
        }
    }
}