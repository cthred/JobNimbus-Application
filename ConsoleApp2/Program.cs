using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(problem1OpenCloseScan("{}") + " = True");
            Console.WriteLine(problem1OpenCloseScan("}{") + " = False (closed bracket can't proceed all open brackets.)");
            Console.WriteLine(problem1OpenCloseScan("{{}") + " = False (one bracket pair was not closed)");
            Console.WriteLine(problem1OpenCloseScan("\"\"") + " = True. (no brackets in the string will return True)");
            Console.WriteLine(problem1OpenCloseScan("{{{}}}") + " = True. (Number Of open and closed pairs does not matter)");
            Console.WriteLine(problem1OpenCloseScan("{}{{}}") + " = True. (Can Have a completing pair befor others)");
            Console.WriteLine(problem1OpenCloseScan("for (var i = 0; i < toScan.Length; i++){if (toScan[i] == '}'){ if (open <= 0){return false;}else open--;}else if (toScan[i] == '{'){open++;}}") + " = True. (Works with code)");
            List<int> arrayToTest = new List<int>() { 3, 5 };
            Console.WriteLine(problem2SumOfMultiples(arrayToTest, 1000));
            arrayToTest = new List<int>() {2, 3, 5 };
            Console.WriteLine(problem2SumOfMultiples(arrayToTest, 1000));
            Console.ReadLine();
        }

        public static int problem2SumOfMultiples(List<int> multiples, int range)
        {
            var toReturn = 0;
            for (var i = 0; i < range; i++)
            {
                foreach(var mul in multiples)
                {
                    if (i % mul == 0)
                    {
                        toReturn = toReturn + i;
                        break;
                    }
                }
            }
            return toReturn;
        }
        public static bool problem1OpenCloseScan(string toScan)
        {
            var pairCount = 0;
            foreach (char c in toScan)
            {
                if (c == '}')
                {
                    if (pairCount <= 0)
                    {
                        return false;
                    }
                    else pairCount--;
                }
                else if (c == '{')
                {
                    pairCount++;
                }
            }
            if (pairCount == 0)
                return true;
            else
                return false;
        }
    }
}
