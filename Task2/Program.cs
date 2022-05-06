using System;

namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                string stroka;
                string color;
                object userColor;

                Console.WriteLine("Введите текст");
                stroka = Console.ReadLine();
                Console.WriteLine("Введите цвет (синий/красный)"); 
                color = Console.ReadLine();
                if (!Enum.TryParse(typeof(CustomColor), color, out userColor))
                {
                    userColor = Console.ForegroundColor;
                }
                Task2.Print(stroka, (int)userColor);
            }
        }
    }
    static class Task2
    {
        public static void Print(string stroka, int color)
        {
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(stroka);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
    enum CustomColor
    {
        красный = 12,
        синий = 9
    }
}