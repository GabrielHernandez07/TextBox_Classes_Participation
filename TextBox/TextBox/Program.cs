using System;

namespace TextBox
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBox one = new TextBox();
            one.Text = "Hello World";
            one.Padding = 5;
            one.BackColor = ConsoleColor.Gray;
            one.ForeColor = ConsoleColor.Blue;
            one.DisplayText();
        }
    }
}
