﻿namespace SeeSortingAlgorithms
{
    partial class MainForm
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
            this.SelectedAlgorithm = new System.Windows.Forms.Label();
            this.NumberofElements = new System.Windows.Forms.Label();
            this.SortingSpeed = new System.Windows.Forms.Label();
            this.ONotationTime = new System.Windows.Forms.Label();
            this.SelectAlgorithm = new System.Windows.Forms.ComboBox();
            this.BarChartBox = new System.Windows.Forms.PictureBox();
            this.Shuffle = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.AdjustElements = new System.Windows.Forms.NumericUpDown();
            this.AdjustSpeed = new System.Windows.Forms.NumericUpDown();
            this.InfoBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BarChartBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdjustElements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdjustSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectedAlgorithm
            // 
            this.SelectedAlgorithm.AutoSize = true;
            this.SelectedAlgorithm.Location = new System.Drawing.Point(38, 130);
            this.SelectedAlgorithm.Name = "SelectedAlgorithm";
            this.SelectedAlgorithm.Size = new System.Drawing.Size(130, 17);
            this.SelectedAlgorithm.TabIndex = 0;
            this.SelectedAlgorithm.Text = "Selected Algorithm:";
            // 
            // NumberofElements
            // 
            this.NumberofElements.AutoSize = true;
            this.NumberofElements.Location = new System.Drawing.Point(28, 60);
            this.NumberofElements.Name = "NumberofElements";
            this.NumberofElements.Size = new System.Drawing.Size(140, 17);
            this.NumberofElements.TabIndex = 1;
            this.NumberofElements.Text = "Number of Elements:";
            // 
            // SortingSpeed
            // 
            this.SortingSpeed.AutoSize = true;
            this.SortingSpeed.Location = new System.Drawing.Point(34, 95);
            this.SortingSpeed.Name = "SortingSpeed";
            this.SortingSpeed.Size = new System.Drawing.Size(134, 17);
            this.SortingSpeed.TabIndex = 2;
            this.SortingSpeed.Text = "Sorting Speed (ms):";
            // 
            // ONotationTime
            // 
            this.ONotationTime.AutoSize = true;
            this.ONotationTime.Location = new System.Drawing.Point(100, 25);
            this.ONotationTime.Name = "ONotationTime";
            this.ONotationTime.Size = new System.Drawing.Size(68, 17);
            this.ONotationTime.TabIndex = 0;
            this.ONotationTime.Text = "Time (O):";
            // 
            // SelectAlgorithm
            // 
            this.SelectAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectAlgorithm.FormattingEnabled = true;
            this.SelectAlgorithm.Items.AddRange(new object[] {
            "Bubble Sort",
            "Insertion Sort",
            "Selection Sort"});
            this.SelectAlgorithm.Location = new System.Drawing.Point(176, 130);
            this.SelectAlgorithm.Name = "SelectAlgorithm";
            this.SelectAlgorithm.Size = new System.Drawing.Size(120, 24);
            this.SelectAlgorithm.TabIndex = 5;
            this.SelectAlgorithm.SelectedIndexChanged += new System.EventHandler(this.SelectAlgorithm_SelectedIndexChanged);
            // 
            // BarChartBox
            // 
            this.BarChartBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BarChartBox.BackColor = System.Drawing.Color.Black;
            this.BarChartBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BarChartBox.Location = new System.Drawing.Point(350, 0);
            this.BarChartBox.Margin = new System.Windows.Forms.Padding(0);
            this.BarChartBox.Name = "BarChartBox";
            this.BarChartBox.Size = new System.Drawing.Size(1032, 653);
            this.BarChartBox.TabIndex = 6;
            this.BarChartBox.TabStop = false;
            // 
            // Shuffle
            // 
            this.Shuffle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Shuffle.Location = new System.Drawing.Point(176, 181);
            this.Shuffle.Name = "Shuffle";
            this.Shuffle.Size = new System.Drawing.Size(101, 40);
            this.Shuffle.TabIndex = 8;
            this.Shuffle.Text = "Shuffle";
            this.Shuffle.UseVisualStyleBackColor = true;
            this.Shuffle.Click += new System.EventHandler(this.Shuffle_Click);
            // 
            // Sort
            // 
            this.Sort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Sort.Location = new System.Drawing.Point(69, 181);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(101, 40);
            this.Sort.TabIndex = 9;
            this.Sort.Text = "Sort!";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // AdjustElements
            // 
            this.AdjustElements.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.AdjustElements.Location = new System.Drawing.Point(176, 60);
            this.AdjustElements.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.AdjustElements.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.AdjustElements.Name = "AdjustElements";
            this.AdjustElements.Size = new System.Drawing.Size(60, 22);
            this.AdjustElements.TabIndex = 10;
            this.AdjustElements.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // AdjustSpeed
            // 
            this.AdjustSpeed.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.AdjustSpeed.Location = new System.Drawing.Point(176, 95);
            this.AdjustSpeed.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.AdjustSpeed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.AdjustSpeed.Name = "AdjustSpeed";
            this.AdjustSpeed.Size = new System.Drawing.Size(60, 22);
            this.AdjustSpeed.TabIndex = 10;
            this.AdjustSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // InfoBox
            // 
            this.InfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoBox.BackColor = System.Drawing.Color.White;
            this.InfoBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InfoBox.Location = new System.Drawing.Point(25, 250);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(300, 378);
            this.InfoBox.TabIndex = 11;
            this.InfoBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.AdjustSpeed);
            this.Controls.Add(this.AdjustElements);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.Shuffle);
            this.Controls.Add(this.BarChartBox);
            this.Controls.Add(this.SelectAlgorithm);
            this.Controls.Add(this.SortingSpeed);
            this.Controls.Add(this.NumberofElements);
            this.Controls.Add(this.ONotationTime);
            this.Controls.Add(this.SelectedAlgorithm);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1400, 700);
            this.Name = "MainForm";
            this.Text = "Visualize Sorting Algorithms";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.BarChartBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdjustElements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdjustSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectedAlgorithm;
        private System.Windows.Forms.Label NumberofElements;
        private System.Windows.Forms.Label SortingSpeed;
        private System.Windows.Forms.Label ONotationTime;
        private System.Windows.Forms.ComboBox SelectAlgorithm;
        private System.Windows.Forms.PictureBox BarChartBox;
        private System.Windows.Forms.Button Shuffle;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.NumericUpDown AdjustElements;
        private System.Windows.Forms.NumericUpDown AdjustSpeed;
        private System.Windows.Forms.PictureBox InfoBox;
    }
}

