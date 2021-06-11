using System;

namespace Lab3
{
    class Button : Window 
    {
        public Button(int top, int left): base(top, left)
        {
        }
        public override void DrawWindow()
        {
            Console.WriteLine("Drawing a button at {0}, {1}\n", top,left);
        }
    }

}