namespace _01.MinThreeNumbers
{
    using System;

    class MinThreeNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int min1 = int.MaxValue;
            int min2 = int.MaxValue;
            int min3 = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());
                if (currNumber < min1)
                {
                    min3 = min2;
                    min2 = min1;
                    min1 = currNumber;
                }
                else if (currNumber < min2)
                {
                    min3 = min2;
                    min2 = currNumber;
                }
                else if (currNumber < min3)
                {
                    min3 = currNumber;
                }
            }

            if (n > 0)
            {
                Console.WriteLine(min1);
            }

            if (n > 1)
            {
                Console.WriteLine(min2);
            }

            if (n > 2)
            {
                Console.WriteLine(min3);
            }
        }
    }
}