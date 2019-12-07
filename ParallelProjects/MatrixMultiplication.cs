using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProjects
{
    class MatrixMultiplication
    {
        private int matrixSize { get; set; }

        public MatrixMultiplication(int size)
        {
            matrixSize = size;
        }

        public void Execute(int [,] inMatrixOne, int[,] inMatrixTwo, int[,] outMatrix)
        {
            // Fill Matrices
            FillMatrix(inMatrixOne);
            FillMatrix(inMatrixTwo);

            // Set Number of Threads
            var options = new ParallelOptions()
            {
                MaxDegreeOfParallelism = 2
            };
            
            // Matrix Multiplication using Parallel.For()
            Parallel.For(0, matrixSize, options, i =>
            {
                int a, b, c;
                for (a = 0; a < matrixSize; a++)
                {
                    for (b = 0; b < matrixSize; b++)
                    {
                        outMatrix[a, b] = 0;
                        for (c = 0; c < matrixSize; c++)
                        {
                            outMatrix[a, b] += inMatrixOne[a, c] * inMatrixTwo[c, b];
                        }
                    }
                }
            });
        }

        public void FillMatrix(int[,] mat)
        {
            var rnd = new Random(Guid.NewGuid().GetHashCode());
            int i, j;
            for (i = 0; i < matrixSize; ++i)
            {
                for (j = 0; j < matrixSize; ++j)
                {
                    mat[i, j] = rnd.Next(9);
                }
            }
        }
    }
}
