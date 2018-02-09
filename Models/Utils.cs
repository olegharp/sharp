using System;

namespace Sharp.Models
{
    public class Utils
    {
        public static string message;
        public static int Sum(params int[] paramList)
        {
            message = "Using parameter list";
            if (paramList == null)
            {
                throw new ArgumentException("Utils.Sum: null parameter list");
            }
            if (paramList.Length == 0)
            {
                throw new ArgumentException("Utils.Sum: empty parameter list");
            }
            int sumTotal = 0;
            foreach (int i in paramList)
            {
                sumTotal += i;
            }
            return sumTotal;
        }
        public static int Sum(int param1 = 0, int param2 = 0, int param3 = 0, int param4 = 0)
        {
            message = "Using optional parameters";
            int sumTotal = param1 + param2 + param3 + param4;
            return sumTotal;
        }
    }
}