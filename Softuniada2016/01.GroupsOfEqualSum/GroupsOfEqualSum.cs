namespace _01.GroupsOfEqualSum
{
    using System;
    using System.Linq;

    public class GroupsOfEqualSum
    {
        public static void Main()
        {
            int[] numbers = new int[4];
            for (int i = 0; i < 4; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 4; i++)
            {
                int currSum = numbers[i];
                int otherSum = numbers.Sum() - numbers[i];
                if (otherSum == currSum)
                {
                    Console.WriteLine($"Yes\n{currSum}");
                    return;
                }

                for (int j = 0; j < 4; j++)
                {
                    if (i != j)
                    {
                        currSum += numbers[j];
                        otherSum -= numbers[j];

                        if (otherSum == currSum)
                        {
                            Console.WriteLine($"Yes\n{currSum}");
                            return;
                        }
                    }
                }
            }

            Console.WriteLine("No");
        }
    }
}