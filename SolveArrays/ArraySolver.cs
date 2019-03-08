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
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
    }
}
