﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ParallelProjects
{
	public partial class CSC_410 : Form
	{
		public CSC_410()
		{
			InitializeComponent();
		}

		private void mat_mul_button_Click(object sender, EventArgs e)
		{
			// run matrix multiplication program
			mat_mul_textbox.Text = "Lots of data processed";
		}

		private void seed_finder_button_Click(object sender, EventArgs e)
		{
			// run seed finder program
			seed_finder_textbox.Text = "Lot of data processed";
		}

		private void Ale_Program_Click(object sender, EventArgs e)
		{
			Grid threadGrid = new Grid();

			int[,] A = new int[threadGrid.rows, threadGrid.columns];
			int[,] B = new int[threadGrid.rows, threadGrid.columns];

			threadGrid.fillGrid(A, 2, 20);
			threadGrid.fillGrid(B, 2, 1);

			AleOutput.AppendText("Gen: 0--\n");
			printGrid(A);

			int gen_count, temp_row, temp_column, temp;
			int gen_limit = 10;

			for (gen_count = 1; gen_count <= gen_limit; gen_count++)
			{
				Parallel.For(0, threadGrid.cell_count, i =>
				{
					temp_row = threadGrid.get_row(i);
					temp_column = threadGrid.get_column(i);

					if (gen_count % 2 == 0) //B -> A
					{
						temp = threadGrid.checker(B, temp_row, temp_column);
						A[temp_row, temp_column] = temp;
					}
					else
					{
						temp = threadGrid.checker(A, temp_row, temp_column);
						B[temp_row, temp_column] = temp;
					}
				});

				AleOutput.AppendText($"\n\nGen: {gen_count}--");

				if (gen_count % 2 == 0)
				{
					AleOutput.AppendText("Grid A:");
					printGrid(A);
				}
				else
				{
					AleOutput.AppendText("Grid B:");
					printGrid(B);
				}
			}


			// print out the grid
			void printGrid(int[,] MyGrid)
			{
				int row, column;

				AleOutput.AppendText("\n");

				for (row = 0; row < threadGrid.rows; row++)
				{
					for (column = 0; column < threadGrid.columns; column++)
					{
						AleOutput.AppendText($"{MyGrid[row, column]} ");

						if (MyGrid[row, column] < 10)
							AleOutput.AppendText("\n");
					}
					AleOutput.AppendText("\n");
				}
			}
		}
	}
}
