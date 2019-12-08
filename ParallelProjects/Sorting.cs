using System;
using System.Threading.Tasks;

namespace ParallelProjects
{
    class Sorting
    { 
        public void GenVals(int[] A, int n)
        {
            Random rand = new Random();
            int i, val;
            for ( i = 0; i < n; ++i)
            {
                val = rand.Next() % 100;
                A[i] = val;
            }
        }

        // Parallel use of the Insertion Sort
        public void sort(int[] A, int n)
        {

            Parallel.For(1, n, i =>
            {
                int key = A[i];
                int j = i - 1;

                while (j >= 0 && A[j] > key)
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }
                A[j + 1] = key;
            });
        }
    }
}
