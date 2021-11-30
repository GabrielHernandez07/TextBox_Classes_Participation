using System;
using System.Collections.Generic;
using System.Text;

namespace TextBox
{
    class TextBox
    {
        public int Padding { get; set; }
        public ConsoleColor BackColor { get; set; }
        public ConsoleColor ForeColor { get; set; }
        public string Text { get; set; }
        public TextBox()
        {
            Padding = 0;
            BackColor = ConsoleColor.Red;
            ForeColor = ConsoleColor.Green;
            Text = string.Empty;
        }
        public void DisplayText()
        {
            string padding = " ";
            for (int i = 0; i < Padding; i++)
            {
                padding += padding;
            }
            string result = padding + Text + padding;
            Console.BackgroundColor = BackColor;
            Console.ForegroundColor = ForeColor;
            Console.WriteLine(result);
            //Text.PadLeft(Padding, ' ');
            //Console.WriteLine(Text);
            //Text.PadRight(Padding, ' ');
        }
    }
}
