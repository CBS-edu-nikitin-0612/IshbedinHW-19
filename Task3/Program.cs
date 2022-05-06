using System;

namespace Task3
{
    internal class Program
    {
        static void Main()
        {
            foreach (Post worker in new [] { Post.Boss, Post.Staff})
            {
                foreach (int hoursh in new[] {25, 30, 45})
                {
                    Console.WriteLine(String.Format("Должность {0,7} часы {1,4} повышение {2}", worker, hoursh, Accountant.AskForBonus(worker, hoursh)));
                }
            }
            //Delay
            Console.ReadKey();
        }
    }

    class Accountant
    {
        public static bool AskForBonus(Post worker, int hours)
        {
            return hours > (int)worker;
        }
    }

    enum Post
    {
        Boss = 40,
        Staff = 30
    }
}
