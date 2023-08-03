using System;

namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Window window = new Window(1, 2);
            window.DrawWindow();

            ListBox listBox = new ListBox(3, 4, "Ok luôn");
            listBox.DrawWindow();

            Button button = new Button(5, 6);
            window.DrawWindow();
            listBox.DrawWindow();
            button.DrawWindow();

            // Khởi tạo mảng window
            Console.WriteLine("\n");
            Console.WriteLine("Khởi tạo mảng window");

            Window[] arrWindow = new Window[3];
            arrWindow[0] = new Window(1, 2);
            arrWindow[1] = new ListBox(3, 4, "Ok luôn");
            arrWindow[2] = new Button(5, 6);

            for (int i = 0; i < arrWindow.Length; i++)
            {
                arrWindow[i].DrawWindow();
            }


            Console.ReadLine();
        }
    }
}
