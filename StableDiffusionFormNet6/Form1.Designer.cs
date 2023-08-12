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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(410, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 382);
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
            this.richTextBox_Log.Location = new System.Drawing.Point(12, 56);
            this.richTextBox_Log.Name = "richTextBox_Log";
            this.richTextBox_Log.ReadOnly = true;
            this.richTextBox_Log.Size = new System.Drawing.Size(392, 382);
            this.richTextBox_Log.TabIndex = 4;
            this.richTextBox_Log.Text = "";
            this.richTextBox_Log.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox_Log);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Generate);
            this.Controls.Add(this.textBox_prompt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox_prompt;
        private Button button_Generate;
        private Label label1;
        private RichTextBox richTextBox_Log;
    }
}