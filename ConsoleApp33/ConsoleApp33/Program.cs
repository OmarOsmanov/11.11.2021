using System;
using System.Collections.Generic;
using System.Linq;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = test(new List<int>(new int[] { 1, 2, 3, 4 }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
        }
        public static List<int> test(List<int> nums)
        {
            IEnumerable<int> squared = nums.Select(x => x * x * x);
            return squared.ToList();
        }
    }
}