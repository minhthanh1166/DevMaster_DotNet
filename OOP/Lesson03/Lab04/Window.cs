using System;

namespace Lab04
{
    internal class Window
    {
        protected int top;
        protected int left;

        public Window() { }
        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        public virtual void DrawWindow()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Top window: " + top);
            Console.WriteLine("Left window: " + left);
        }
    }

    internal class Button : Window
    {
        public Button() : base() { }
        public Button(int top, int left) : base(top, left) { }

        public override void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine("Top button: " + top);
            Console.WriteLine("Left button: " + left);
        }
    }

    internal class ListBox : Window
    {
        string content;

        public ListBox(int top, int left, string content) : base(top, left)
        {
            this.content = content;
        }

        public ListBox() : base() { }

        public override void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine("Top listbox: " + top);
            Console.WriteLine("Left listbox: " + left);
            Console.WriteLine("Content listbox: " + content);
        }
    }
}
