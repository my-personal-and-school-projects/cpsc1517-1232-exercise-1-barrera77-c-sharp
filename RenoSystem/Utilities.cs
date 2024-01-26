using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenoSystem
{
    public class Utilities
    {
        public static bool IsNonZeroPositive(int value) => value > 0;

        public static bool IsValidMinimum(int value1, int value2) => value1 >= value2;

        public static bool IsZeroPositive(int value) => value >= 0;
    }
}
