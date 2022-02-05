
using System;
using Microsoft.VisualBasic;

namespace String_stuff
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var thisDay = DateTime.Now;
            Console.WriteLine("{0,40:MMMM d, yyyy}", thisDay);
            Console.WriteLine(thisDay.ToString("yyyy.MM.dd"));
            Console.WriteLine($"Day{thisDay: d} of {thisDay:MMMM}, {thisDay:yyyy}");
            Console.WriteLine($"Year:{thisDay:yyyy}, Month:{thisDay:MM}, Day:{thisDay:dd}");
            Console.WriteLine($"{"",-10}{thisDay:dddd}");
            Console.WriteLine("{0,10:hh:mm tt}{0,10:dddd}", thisDay);
            Console.WriteLine("h:{0:hh}, m:{0:mm}, s:{0:ss}", thisDay);
            Console.WriteLine("{0:yyyy}.{0:MM}.{0:dd}.{0:HH}.{0:mm}.{0:ss}", thisDay);
            
            const double pi = Math.PI;
            Console.WriteLine("{0:$#.##}",pi);
            Console.WriteLine("{0,10:#.###}",pi); //10 spaces total? I did total here. This assignment is very hard to understand
        }
    }
}