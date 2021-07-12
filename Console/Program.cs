using System;
using System.Linq;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = { 25, 23, 30, 35, 22 };

            var query = from age in ages
                        where age > 25
                        select age;
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
    public static class ExtensionMethod
    {
        public static bool IsGreaterThan(this int i, int val)
        {
            return i > val;
        }
    }
}
