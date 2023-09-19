using System.Drawing.Printing;

namespace RazorPagesCupcakes.Models
{
    public class Date
    {
        public void PrintDays()
        {
            string longMessage = """
             This is a long message.
             It has several lines.
                 Some are indented
                         more than others.
             Some should start at the first column.
             Some have "quoted text" in them.
             """;
            Console.WriteLine(GetDay(1));
            Console.WriteLine(longMessage);
        }

        static string GetDay(int dayNum)
        {
            string dayName;
            switch (dayNum) // Convert to switch expression
            {
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednsday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saterday";
                    break;
                case 7:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid day number";
                    break;
            }
            return dayName;
        }
    }
}