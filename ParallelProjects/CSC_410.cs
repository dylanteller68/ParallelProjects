using System;
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

			AleOutput.AppendText("Gen: 0--\r\n");
			printGrid(A);

			int gen_count, temp_row, temp_column, temp;
			int gen_limit = 10;

			GridStatus.Text = "Computing";
			StatusCopy.Text = "Computing";

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

				if (gen_count % 4 == 0) 
				{ 
					GridStatus.Text = "Computing";
					StatusCopy.Text = "Computing";
				} else { 
					GridStatus.AppendText(" .");
					StatusCopy.AppendText(" .");
				}

				AleOutput.AppendText($"\r\nGen: {gen_count}--");

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

			GridStatus.Text = "Complete!";
			StatusCopy.Text = "Complete!";


			// print out the grid
			void printGrid(int[,] MyGrid)
			{
				int row, column;

				AleOutput.AppendText("\r\n");

				for (row = 0; row < threadGrid.rows; row++)
				{
					for (column = 0; column < threadGrid.columns; column++)
					{
						AleOutput.AppendText($"{MyGrid[row, column]} ");

						if (MyGrid[row, column] < 10)
							AleOutput.AppendText(" ");
					}
					AleOutput.AppendText("\r\n");
				}
			}
		}

		private void GridStatus_TextChanged(object sender, EventArgs e)
		{

		}
	}
        private async void seed_finder_button_Click(object sender, EventArgs e)
        {
            if (seed_finder_button.Text == "Start Seed Finder")
            {
                seed_finder_textbox.Clear();
                seed_finder_button.Text = "Run";
                seed_finder_textbox.Text = "Enter 5 numbers: ";
                seed_finder_textbox.ReadOnly = false;
            }
            else if (seed_finder_button.Text == "Run")
            {
                SeedFinderProgram seedFinder = new SeedFinderProgram();
                string input = seed_finder_textbox.Text.Remove(0, 17);
                seed_finder_button.Text = "Running...";
                seed_finder_button.Enabled = false;
                seed_finder_textbox.Text += Environment.NewLine + "Finding seed...";
                seed_finder_textbox.ReadOnly = true;
                var watch = System.Diagnostics.Stopwatch.StartNew();
                var task = await Task.Run(() =>
                {
                    return seedFinder.run(input);
                });
                watch.Stop();
                seed_finder_button.Enabled = true;
                var elapsedTime = (float)watch.ElapsedMilliseconds / 1000;
                seed_finder_textbox.Text += Environment.NewLine + task + Environment.NewLine + elapsedTime.ToString() + " Seconds elapsed";
                seed_finder_button.Text = "Start Seed Finder";
            }
        }
    }
}
