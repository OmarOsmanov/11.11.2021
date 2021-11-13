using System;
using System.Collections.Generic;
using System.Linq;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ededkub = new List<int>() { 1, 2, 3, 4 };
            for (int i = 0; i < ededkub.Count; i++)
            {
                ededkub[i] = (int)Math.Pow(ededkub[i], 3);
            }
        }

    }
}