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

		private async void mat_mul_button_Click(object sender, EventArgs e)
		{
            int matrixSize = 6;
            int[,] inMatrixOne = new int[matrixSize, matrixSize];
            int[,] inMatrixTwo = new int[matrixSize, matrixSize];
            int[,] outMatrix = new int[matrixSize, matrixSize];

            MatrixMultiplication matrixMul = new MatrixMultiplication(matrixSize);
            mat_mul_textbox.AppendText("Calculating...\n");
            await Task.Run(() =>
            {
                Thread.Sleep(2500);
                matrixMul.Execute(inMatrixOne, inMatrixTwo, outMatrix);
            });

            // Print Input Matrices
            mat_mul_textbox.AppendText("Matrix One: \r\n");
            PrintMatrix(inMatrixOne);

            mat_mul_textbox.AppendText("Matrix Two: \r\n");
            PrintMatrix(inMatrixTwo);

            // Print Output Matrix
            mat_mul_textbox.AppendText("Output Matrix: \r\n");
            PrintMatrix(outMatrix);

            // Method to print a matrix
            void PrintMatrix(int[,] mat)
            {
                int i, j;

                for (i = 0; i < matrixSize; ++i)
                {
                    for (j = 0; j < matrixSize; ++j)
                    {
                        mat_mul_textbox.AppendText($"  {mat[i, j]}  ");
                    }
                    mat_mul_textbox.AppendText("\r\n");
                }

                mat_mul_textbox.AppendText("\r\n");
            }
        }

		private async void Ale_Program_Click(object sender, EventArgs e)
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
                await Task.Run(() =>
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

                    Thread.Sleep(2500);
                });

                if (gen_count % 4 == 0)
                {
                    GridStatus.Text = "Computing";
                    StatusCopy.Text = "Computing";
                }
                else
                {
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
                    return seedFinder.run(input) ;
                });
                watch.Stop();
                seed_finder_button.Enabled = true;
                var elapsedTime = (float)watch.ElapsedMilliseconds / 1000;
                int num;
                if (int.TryParse(task[task.Length-1].ToString(), out num))
                {
                    string output = task.Remove(task.Length - 1, 1);
                    seed_finder_textbox.Text += Environment.NewLine + output + Environment.NewLine + elapsedTime.ToString() + " Seconds elapsed" + Environment.NewLine + "Found by thread: " + task.ElementAt(task.Length - 1);
                }
                else
                {
                    string output = task;
                    seed_finder_textbox.Text += Environment.NewLine + output;
                }
                seed_finder_button.Text = "Start Seed Finder";
            }
        }

        private void CSC_410_Load(object sender, EventArgs e)
        {
            Width += 290;
            CenterToScreen();
        }

        private async void Sort_Button_Click(object sender, EventArgs e)
        {
            if (Sort_Button.Text == "Sort Start")
            {
                sortTextbox.Text = "How many values to sort? ";
                Sort_Button.Text = "Run";
                sortTextbox.ReadOnly = false;
            }
            else if (Sort_Button.Text == "Run")
            {
                Sort_Button.Text = "Reset";
                string n = sortTextbox.Text.Remove(0, 24);
                int N = 0;
                try
                {
                    N = Convert.ToInt32(n);
                    int[] A = new int[N];

                    Sorting sorting = new Sorting();

                    sorting.GenVals(A, N);
                    sortTextbox.Text += Environment.NewLine + "Array Presorting: " + Environment.NewLine;
                    int i = 0;
                    string randNums = "";
                    while (i < N)
                    {
                        await Task.Run(() =>
                        {
                            randNums = "";
                            while (i < i + 200 && i < N)
                            {
                                randNums += A[i] + " ";
                                i++;
                            }
                        });
                        Thread.Sleep(1000);
                        sortTextbox.Text += randNums;
                        i += 200;
                    }

                    string TimeTaken = "";
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    await Task.Run(() =>
                    {
                        sorting.sort(A, N);
                    });
                    watch.Stop();
                    TimeTaken = ((float)watch.ElapsedMilliseconds / 1000).ToString();
                    sortTextbox.Text += Environment.NewLine + "Array Post-sorting:" + Environment.NewLine;

                    i = 0;
                    string sortedNums = "";
                    while (i < N)
                    {
                        await Task.Run(() =>
                        {
                            sortedNums = "";
                            while (i < i + 200 && i < N)
                            {
                                sortedNums += A[i] + " ";
                                i++;
                            }
                        });
                        Thread.Sleep(1000);
                        sortTextbox.Text += sortedNums;
                        i += 200;
                    }

                    sortTextbox.Text += Environment.NewLine + "Time took to sort: " + TimeTaken;
                }
                catch
                {
                    sortTextbox.Text += Environment.NewLine + "Invalid input, enter a positive integer";
                }
            }
            else
            {
                sortTextbox.Text = "";
                Sort_Button.Text = "Sort Start";
            }
        }
    }
}
