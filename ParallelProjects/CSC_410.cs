﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            mat_mul_textbox.Text += "Lots of data processed" + Environment.NewLine;
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
