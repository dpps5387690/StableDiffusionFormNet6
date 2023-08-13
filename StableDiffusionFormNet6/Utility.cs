using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StableDiffusionFormNet6
{
    internal class Utility
    {
        public static void WriteStatus(RichTextBox richTextBox, string str)
        {
            Debug.WriteLine(str);
            richTextBox.Invoke(new Action(() =>
            {
                richTextBox.Text = richTextBox.Text + str + Environment.NewLine;
                //if (GlobalVariable.IsEndLine)
                richTextBox.SelectionStart = richTextBox.Text.Length;
                richTextBox.ScrollToCaret();
            }));
        }
    }
}
