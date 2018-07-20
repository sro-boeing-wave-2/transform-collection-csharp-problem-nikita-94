using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public static class Transform 
    {
        public static List<int> Map(this int[] x,Func<int,int>twice)
        {
            List<int> number =new List<int>();
            foreach (int item in x)
            {
                number.Add(twice(item));
            }
            return number;
            throw new NotImplementedException();
        }
    }
}
