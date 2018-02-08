using System;

namespace Sharp.Models
{
    public class Utils
    {
        public static int Sum(params int[] paramList)
        {
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
                sumTotal+= i;
            }
            return sumTotal;
        }
    }
}