namespace ParallelProjects
{
    partial class CSC_410
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mat_mul_button = new System.Windows.Forms.Button();
            this.seed_finder_button = new System.Windows.Forms.Button();
            this.Ale_Program = new System.Windows.Forms.Button();
            this.Sort_Button = new System.Windows.Forms.Button();
            this.mat_mul_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seed_finder_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AleOutput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sortTextbox = new System.Windows.Forms.TextBox();
            this.GridStatus = new System.Windows.Forms.TextBox();
            this.StatusCopy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mat_mul_button
            // 
            this.mat_mul_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mat_mul_button.Location = new System.Drawing.Point(12, 12);
            this.mat_mul_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mat_mul_button.Name = "mat_mul_button";
            this.mat_mul_button.Size = new System.Drawing.Size(400, 64);
            this.mat_mul_button.TabIndex = 0;
            this.mat_mul_button.Text = "Matrix Multiplication";
            this.mat_mul_button.UseVisualStyleBackColor = true;
            this.mat_mul_button.Click += new System.EventHandler(this.mat_mul_button_Click);
            // 
            // seed_finder_button
            // 
            this.seed_finder_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seed_finder_button.Location = new System.Drawing.Point(509, 15);
            this.seed_finder_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seed_finder_button.Name = "seed_finder_button";
            this.seed_finder_button.Size = new System.Drawing.Size(400, 64);
            this.seed_finder_button.TabIndex = 1;
            this.seed_finder_button.Text = "Start Seed Finder";
            this.seed_finder_button.UseVisualStyleBackColor = true;
            this.seed_finder_button.Click += new System.EventHandler(this.seed_finder_button_Click);
            // 
            // Ale_Program
            // 
            this.Ale_Program.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ale_Program.Location = new System.Drawing.Point(1013, 15);
            this.Ale_Program.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ale_Program.Name = "Ale_Program";
            this.Ale_Program.Size = new System.Drawing.Size(400, 64);
            this.Ale_Program.TabIndex = 2;
            this.Ale_Program.Text = "Grid Manipulator";
            this.Ale_Program.UseVisualStyleBackColor = true;
            this.Ale_Program.Click += new System.EventHandler(this.Ale_Program_Click);
            // 
            // Sort_Button
            // 
            this.Sort_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sort_Button.Location = new System.Drawing.Point(1513, 15);
            this.Sort_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sort_Button.Name = "Sort_Button";
            this.Sort_Button.Size = new System.Drawing.Size(400, 64);
            this.Sort_Button.TabIndex = 3;
            this.Sort_Button.Text = "Sort Start";
            this.Sort_Button.UseVisualStyleBackColor = true;
            this.Sort_Button.Click += new System.EventHandler(this.Sort_Button_Click);
            // 
            // mat_mul_textbox
            // 
            this.mat_mul_textbox.Location = new System.Drawing.Point(12, 132);
            this.mat_mul_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mat_mul_textbox.Multiline = true;
            this.mat_mul_textbox.Name = "mat_mul_textbox";
            this.mat_mul_textbox.ReadOnly = true;
            this.mat_mul_textbox.Size = new System.Drawing.Size(399, 697);
            this.mat_mul_textbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(655, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Terminal";
            // 
            // seed_finder_textbox
            // 
            this.seed_finder_textbox.BackColor = System.Drawing.SystemColors.Control;
            this.seed_finder_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.seed_finder_textbox.Location = new System.Drawing.Point(510, 135);
            this.seed_finder_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.seed_finder_textbox.Multiline = true;
            this.seed_finder_textbox.Name = "seed_finder_textbox";
            this.seed_finder_textbox.ReadOnly = true;
            this.seed_finder_textbox.Size = new System.Drawing.Size(399, 697);
            this.seed_finder_textbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1169, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Output";
            // 
            // AleOutput
            // 
            this.AleOutput.Location = new System.Drawing.Point(1013, 135);
            this.AleOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AleOutput.Multiline = true;
            this.AleOutput.Name = "AleOutput";
            this.AleOutput.ReadOnly = true;
            this.AleOutput.Size = new System.Drawing.Size(399, 697);
            this.AleOutput.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1670, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Output";
            // 
            // sortTextbox
            // 
            this.sortTextbox.Location = new System.Drawing.Point(1513, 132);
            this.sortTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortTextbox.Multiline = true;
            this.sortTextbox.Name = "sortTextbox";
            this.sortTextbox.ReadOnly = true;
            this.sortTextbox.Size = new System.Drawing.Size(399, 697);
            this.sortTextbox.TabIndex = 10;
            // 
            // GridStatus
            // 
            this.GridStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridStatus.Location = new System.Drawing.Point(1013, 108);
            this.GridStatus.Margin = new System.Windows.Forms.Padding(4);
            this.GridStatus.Name = "GridStatus";
            this.GridStatus.ReadOnly = true;
            this.GridStatus.Size = new System.Drawing.Size(148, 19);
            this.GridStatus.TabIndex = 13;
            this.GridStatus.TextChanged += new System.EventHandler(this.GridStatus_TextChanged);
            // 
            // StatusCopy
            // 
            this.StatusCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusCopy.Location = new System.Drawing.Point(1263, 108);
            this.StatusCopy.Margin = new System.Windows.Forms.Padding(4);
            this.StatusCopy.Name = "StatusCopy";
            this.StatusCopy.ReadOnly = true;
            this.StatusCopy.Size = new System.Drawing.Size(148, 19);
            this.StatusCopy.TabIndex = 14;
            // 
            // CSC_410
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 843);
            this.Controls.Add(this.StatusCopy);
            this.Controls.Add(this.GridStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sortTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AleOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seed_finder_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mat_mul_textbox);
            this.Controls.Add(this.Sort_Button);
            this.Controls.Add(this.Ale_Program);
            this.Controls.Add(this.seed_finder_button);
            this.Controls.Add(this.mat_mul_button);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CSC_410";
            this.Text = "CSC 410";
            this.Load += new System.EventHandler(this.CSC_410_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mat_mul_button;
        private System.Windows.Forms.Button seed_finder_button;
        private System.Windows.Forms.Button Ale_Program;
        private System.Windows.Forms.Button Sort_Button;
        private System.Windows.Forms.TextBox mat_mul_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox seed_finder_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AleOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sortTextbox;
        private System.Windows.Forms.TextBox GridStatus;
        private System.Windows.Forms.TextBox StatusCopy;
    }
}

