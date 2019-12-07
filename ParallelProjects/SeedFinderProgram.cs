using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace ParallelProjects
{
    class SeedFinderProgram
    {
        public string run(string input)
        {
            int[] randNums = new int[5];
            int seed = -1;
            bool seedHasNotBeenFound = true;
            int j, start = 0, max = 10000;
            string result = "Seed: ";
            string[] splitInput = input.Split(' ');
            for (j = 0; j < 5; j++)
                randNums[j] = int.Parse(splitInput[j]);

            while (seedHasNotBeenFound)
            {
                Parallel.For(start, max, (i, state) =>
                {
                    Random random = new Random(i);
                    for (j = 0; j < 5; j++)
                    {
                        int genRand = random.Next();
                        if (genRand != randNums[j])
                            break;
                    }
                    if (j == 5)
                    {
                        seed = i;
                        seedHasNotBeenFound = false;
                    }
                    i++;
                });
                start += 10000;
                max += 10000;
            }

            result += seed.ToString();

            return result;
        }
    }
}
