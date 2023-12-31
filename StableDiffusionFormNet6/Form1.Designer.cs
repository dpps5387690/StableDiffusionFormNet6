﻿namespace StableDiffusionFormNet6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_prompt = new System.Windows.Forms.TextBox();
            this.button_Generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_Log = new System.Windows.Forms.RichTextBox();
            this.trackBar_Width = new System.Windows.Forms.TrackBar();
            this.trackBar_Height = new System.Windows.Forms.TrackBar();
            this.numericUpDown_Width = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Height = new System.Windows.Forms.NumericUpDown();
            this.label_width = new System.Windows.Forms.Label();
            this.label_height = new System.Windows.Forms.Label();
            this.numericUpDown_Scale = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSteps = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSteps)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(456, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_prompt
            // 
            this.textBox_prompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_prompt.Location = new System.Drawing.Point(63, 5);
            this.textBox_prompt.Name = "textBox_prompt";
            this.textBox_prompt.Size = new System.Drawing.Size(474, 23);
            this.textBox_prompt.TabIndex = 1;
            this.textBox_prompt.Text = "a fireplace in an old cabin in the woods";
            // 
            // button_Generate
            // 
            this.button_Generate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_Generate.Location = new System.Drawing.Point(543, 5);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(74, 23);
            this.button_Generate.TabIndex = 2;
            this.button_Generate.Text = "Generate";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.Click += new System.EventHandler(this.button_Generate_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "prompt";
            // 
            // richTextBox_Log
            // 
            this.richTextBox_Log.Location = new System.Drawing.Point(0, 228);
            this.richTextBox_Log.Name = "richTextBox_Log";
            this.richTextBox_Log.ReadOnly = true;
            this.richTextBox_Log.Size = new System.Drawing.Size(450, 320);
            this.richTextBox_Log.TabIndex = 4;
            this.richTextBox_Log.Text = "";
            this.richTextBox_Log.WordWrap = false;
            // 
            // trackBar_Width
            // 
            this.trackBar_Width.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.trackBar_Width.LargeChange = 256;
            this.trackBar_Width.Location = new System.Drawing.Point(133, 3);
            this.trackBar_Width.Maximum = 4096;
            this.trackBar_Width.Minimum = 256;
            this.trackBar_Width.Name = "trackBar_Width";
            this.trackBar_Width.Size = new System.Drawing.Size(127, 39);
            this.trackBar_Width.SmallChange = 128;
            this.trackBar_Width.TabIndex = 13;
            this.trackBar_Width.Value = 512;
            this.trackBar_Width.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // trackBar_Height
            // 
            this.trackBar_Height.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.trackBar_Height.LargeChange = 256;
            this.trackBar_Height.Location = new System.Drawing.Point(133, 48);
            this.trackBar_Height.Maximum = 4096;
            this.trackBar_Height.Minimum = 256;
            this.trackBar_Height.Name = "trackBar_Height";
            this.trackBar_Height.Size = new System.Drawing.Size(127, 39);
            this.trackBar_Height.SmallChange = 128;
            this.trackBar_Height.TabIndex = 14;
            this.trackBar_Height.Value = 512;
            this.trackBar_Height.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // numericUpDown_Width
            // 
            this.numericUpDown_Width.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_Width.Increment = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericUpDown_Width.Location = new System.Drawing.Point(63, 11);
            this.numericUpDown_Width.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.numericUpDown_Width.Minimum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericUpDown_Width.Name = "numericUpDown_Width";
            this.numericUpDown_Width.Size = new System.Drawing.Size(50, 23);
            this.numericUpDown_Width.TabIndex = 15;
            this.numericUpDown_Width.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numericUpDown_Width.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDown_Height
            // 
            this.numericUpDown_Height.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_Height.Increment = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericUpDown_Height.Location = new System.Drawing.Point(63, 56);
            this.numericUpDown_Height.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.numericUpDown_Height.Minimum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericUpDown_Height.Name = "numericUpDown_Height";
            this.numericUpDown_Height.Size = new System.Drawing.Size(50, 23);
            this.numericUpDown_Height.TabIndex = 15;
            this.numericUpDown_Height.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numericUpDown_Height.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label_width
            // 
            this.label_width.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_width.AutoSize = true;
            this.label_width.Location = new System.Drawing.Point(3, 15);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(41, 15);
            this.label_width.TabIndex = 16;
            this.label_width.Text = "Width";
            // 
            // label_height
            // 
            this.label_height.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_height.AutoSize = true;
            this.label_height.Location = new System.Drawing.Point(3, 60);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(45, 15);
            this.label_height.TabIndex = 17;
            this.label_height.Text = "Height";
            // 
            // numericUpDown_Scale
            // 
            this.numericUpDown_Scale.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_Scale.DecimalPlaces = 1;
            this.numericUpDown_Scale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_Scale.Location = new System.Drawing.Point(63, 149);
            this.numericUpDown_Scale.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Scale.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_Scale.Name = "numericUpDown_Scale";
            this.numericUpDown_Scale.Size = new System.Drawing.Size(50, 23);
            this.numericUpDown_Scale.TabIndex = 18;
            this.numericUpDown_Scale.Value = new decimal(new int[] {
            75,
            0,
            0,
            65536});
            // 
            // numericUpDownSteps
            // 
            this.numericUpDownSteps.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownSteps.Location = new System.Drawing.Point(63, 101);
            this.numericUpDownSteps.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSteps.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownSteps.Name = "numericUpDownSteps";
            this.numericUpDownSteps.Size = new System.Drawing.Size(50, 23);
            this.numericUpDownSteps.TabIndex = 18;
            this.numericUpDownSteps.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Scale";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Steps";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_prompt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_Generate, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(620, 33);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutPanel2.Controls.Add(this.label_width, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_Width, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_Scale, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownSteps, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.trackBar_Width, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_height, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_Height, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.trackBar_Height, 2, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 41);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(292, 186);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 552);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.richTextBox_Log);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Scale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSteps)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox_prompt;
        private Button button_Generate;
        private Label label1;
        private RichTextBox richTextBox_Log;
        private TrackBar trackBar_Width;
        private TrackBar trackBar_Height;
        private NumericUpDown numericUpDown_Width;
        private NumericUpDown numericUpDown_Height;
        private Label label_width;
        private Label label_height;
        private NumericUpDown numericUpDown_Scale;
        private NumericUpDown numericUpDownSteps;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}