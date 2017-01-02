namespace _02.DrawHouse
{
    using System;

    public class DrawHouse
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            DrawRoof(size);
            DrawBaseHouse(size);
        }

        public static void DrawRoof(int size)
        {
            int outside = size - 1;
            int inside = 0;
            for (int i = 0; i < size - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}*{0}",
                    new string('.', outside),
                    inside == 0 ? "" : "*",
                    new string(' ', inside));

                outside--;
                inside = inside == 0 ? 1 : inside + 2;
            }

            for (int i = 0; i < size - 1; i++)
            {
                Console.Write("* ");
            }

            Console.WriteLine("*");
        }

        public static void DrawBaseHouse(int size)
        {
            Console.WriteLine($"+{new string('-', size * 2 - 3)}+");
            for (int i = 0; i < size - 2; i++)
            {
                Console.WriteLine($"|{new string(' ', size * 2 - 3)}|");
            }

            Console.WriteLine($"+{new string('-', size * 2 - 3)}+");
        }
    }
}