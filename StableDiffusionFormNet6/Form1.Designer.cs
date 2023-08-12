namespace StableDiffusionFormNet6
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSteps)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(456, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_prompt
            // 
            this.textBox_prompt.Location = new System.Drawing.Point(68, 6);
            this.textBox_prompt.Name = "textBox_prompt";
            this.textBox_prompt.Size = new System.Drawing.Size(582, 23);
            this.textBox_prompt.TabIndex = 1;
            this.textBox_prompt.Text = "a fireplace in an old cabin in the woods";
            // 
            // button_Generate
            // 
            this.button_Generate.Location = new System.Drawing.Point(656, 6);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(75, 23);
            this.button_Generate.TabIndex = 2;
            this.button_Generate.Text = "Generate";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.Click += new System.EventHandler(this.button_Generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "prompt";
            // 
            // richTextBox_Log
            // 
            this.richTextBox_Log.Location = new System.Drawing.Point(0, 186);
            this.richTextBox_Log.Name = "richTextBox_Log";
            this.richTextBox_Log.ReadOnly = true;
            this.richTextBox_Log.Size = new System.Drawing.Size(450, 382);
            this.richTextBox_Log.TabIndex = 4;
            this.richTextBox_Log.Text = "";
            this.richTextBox_Log.WordWrap = false;
            // 
            // trackBar_Width
            // 
            this.trackBar_Width.LargeChange = 256;
            this.trackBar_Width.Location = new System.Drawing.Point(113, 32);
            this.trackBar_Width.Maximum = 4096;
            this.trackBar_Width.Minimum = 256;
            this.trackBar_Width.Name = "trackBar_Width";
            this.trackBar_Width.Size = new System.Drawing.Size(127, 45);
            this.trackBar_Width.SmallChange = 128;
            this.trackBar_Width.TabIndex = 13;
            this.trackBar_Width.Value = 512;
            this.trackBar_Width.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // trackBar_Height
            // 
            this.trackBar_Height.LargeChange = 256;
            this.trackBar_Height.Location = new System.Drawing.Point(113, 83);
            this.trackBar_Height.Maximum = 4096;
            this.trackBar_Height.Minimum = 256;
            this.trackBar_Height.Name = "trackBar_Height";
            this.trackBar_Height.Size = new System.Drawing.Size(127, 45);
            this.trackBar_Height.SmallChange = 128;
            this.trackBar_Height.TabIndex = 14;
            this.trackBar_Height.Value = 512;
            this.trackBar_Height.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // numericUpDown_Width
            // 
            this.numericUpDown_Width.Increment = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericUpDown_Width.Location = new System.Drawing.Point(57, 35);
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
            this.numericUpDown_Height.Increment = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericUpDown_Height.Location = new System.Drawing.Point(57, 83);
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
            this.label_width.AutoSize = true;
            this.label_width.Location = new System.Drawing.Point(8, 37);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(41, 15);
            this.label_width.TabIndex = 16;
            this.label_width.Text = "Width";
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.Location = new System.Drawing.Point(4, 85);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(45, 15);
            this.label_height.TabIndex = 17;
            this.label_height.Text = "Height";
            // 
            // numericUpDown_Scale
            // 
            this.numericUpDown_Scale.DecimalPlaces = 1;
            this.numericUpDown_Scale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_Scale.Location = new System.Drawing.Point(57, 155);
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
            this.numericUpDownSteps.Location = new System.Drawing.Point(57, 120);
            this.numericUpDownSteps.Maximum = new decimal(new int[] {
            20,
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
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Scale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Steps";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 571);
            this.Controls.Add(this.numericUpDownSteps);
            this.Controls.Add(this.numericUpDown_Scale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_height);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_width);
            this.Controls.Add(this.numericUpDown_Height);
            this.Controls.Add(this.numericUpDown_Width);
            this.Controls.Add(this.trackBar_Height);
            this.Controls.Add(this.trackBar_Width);
            this.Controls.Add(this.richTextBox_Log);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Generate);
            this.Controls.Add(this.textBox_prompt);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}