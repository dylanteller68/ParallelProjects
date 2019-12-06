using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProjects
{
    class SeedFinderProgram
    {
        public string run(string input)
        {
            int[] randNums = new int[5];
            int seed = -1;
            int i;
            string result = "Seed: ";
            string[] splitInput = input.Split(' ');
            for (i = 0; i < 5; i++)
                randNums[i] = int.Parse(splitInput[i]);

            i = 0;
            int j;

            while (seed < 0)
            {
                Random random = new Random(i);
                for (j = 0; j < 5; j++)
                {
                    int genRand = random.Next();
                    if (genRand != randNums[j])
                        break;
                }
                if (j == 5)
                    seed = i;
                i++;
            }

            result += seed.ToString();

            return result;
        }
    }
}
