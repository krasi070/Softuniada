namespace _03.SumTime
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SumTime
    {
        public static void Main()
        {
            int firstTimeInMin = ParseTimeInMinutes(Console.ReadLine());
            int secondTimeInMin = ParseTimeInMinutes(Console.ReadLine());
            int sumTimeInMin = firstTimeInMin + secondTimeInMin;

            int days = sumTimeInMin / (24 * 60);
            int hours = sumTimeInMin % (24 * 60) / 60;
            int minutes = sumTimeInMin % (24 * 60) % 60;

            string result = "";
            if (days > 0)
            {
                result += days + "::";
            }

            result += hours + ":";
            result += minutes.ToString().PadLeft(2, '0');

            Console.WriteLine(result);
        }

        public static int ParseTimeInMinutes(string time)
        {
            int[] args = time
                .Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int timeInMin = 0;
            if (args.Length > 2)
            {
                timeInMin += args[0] * 24 * 60;
                timeInMin += args[1] * 60;
                timeInMin += args[2];
            }
            else
            {
                timeInMin += args[0] * 60;
                timeInMin += args[1];
            }

            return timeInMin;
        }
    }
}