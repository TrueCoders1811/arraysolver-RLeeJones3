using System;
using System.Collections.Generic;

namespace SolveArrays
{
    public class ArraySolver
    {
        public int Sum(int[] numbers)
        {
            int total = 0;
           foreach (int num in numbers)
            {
                total += num;
            }

            return total;
        }

        public int SumEvens(int[] numbers)
        {
            int total = 0;
            foreach (int num in numbers)
            {
                if (num %2 == 0)
                {
                    total += num;
                }
            }

            return total;

        }

        public double AverageEvens(int[] numbers)
        {
            double total = 0;
            double count = 0;
            foreach (int num in numbers)
            {
                if (num %2 == 0)
                {
                    total += num;
                    count++;
                }
            }

            if (count == 0)
            {
                return 0; 
            }
            return total / count;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int total = 0;
            foreach (int num in numbers)
            {
                total += num;
            }
            if (total % 2 != 0)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }
    }
}
