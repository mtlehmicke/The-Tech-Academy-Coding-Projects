using System;
using System.Collections.Generic;
using System.Text;

namespace InstantiateMethodApp
{
    class theMethods
    {
        public static int MethodMath(int x)
        {
            return x + 10;
        }

        public static decimal MethodMath(decimal x)
        {
            return x * 3;
        }
        public static string MethodMath(string x)
        {
            int y = Convert.ToInt32(x) * 10;
            return Convert.ToString(y);
        }
    }

}
