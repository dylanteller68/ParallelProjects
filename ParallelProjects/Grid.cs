using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProjects
{
	public class Grid
	{

		internal int columns { get; set; }
		internal int rows { get; set; }
		internal int thread_count { get; set; }
		internal int[] tloop_count { get; set; }
		internal int cell_count { get; set; }


		public Grid()
		{
			columns = 20;
			rows = 12;
			thread_count = 4;

			//global variables
			tloop_count = new int[thread_count];
			cell_count = rows * columns;
		}

		public int fillGrid(int[,] MyGrid, int seed, int high)
		{
			int row, column;
			Random rand = new Random(seed);

			for (row = 0; row < rows; row++)
			{
				for (column = 0; column < columns; column++)
				{
					MyGrid[row, column] = rand.Next(high);
				}
			}

			return 0;
		}


		//given grid, and an particular (x,y) location
		//compute the value of that spot in next generation
		public int checker(int[,] arr, int x, int y)
		{
			int row, column;
			int currentTotal = 0;


			//check row above
			for (row = x - 1; row <= x + 1; row++)
			{
				for (column = y - 1; column <= y + 1; column++)
				{
					//if the check value is in bounds
					if (column >= 0 && row >= 0)
					{
						if (column < columns && row < rows)
						{
							currentTotal += arr[row, column];
							//Thread.Sleep(currentTotal % 11 * 1500);
						}
					}
				}
			}

			//sum % 10 == 0 			0
			if (currentTotal % 10 == 0) { return 0; }

			//sum is under 50             add 3 to current
			if (currentTotal < 50) { return arr[x, y] + 3; }

			//sum between 50 & 150        subtract 3, but can't go below 0
			if (currentTotal <= 150)
			{
				if (arr[x, y] - 3 < 0)
				{
					return 0;
				}
				else
				{
					return arr[x, y] - 3;
				}
			}

			//sum over 150                1
			return 1;

		}

		public int get_column(int cell_loc)
		{
			return cell_loc % columns;
		}

		public int get_row(int cell_loc)
		{
			return cell_loc / columns;
		}
	}
}
