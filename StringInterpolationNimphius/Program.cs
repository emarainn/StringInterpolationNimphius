using System;
using System.Globalization;

namespace StringInterpolationNimphius
{
    class Program
    {
        static void Main(string[] args)
        {


            var date = DateTime.Now;


            //ONE : January 22, 2019 (right aligned in a 40 character field)
            Console.WriteLine($"{date, 40:MMMM dd, yyyy}");

            //TWO : 2019.01.22
            Console.WriteLine($"{date:yyyy.MM.dd}");

            //THREE : Day 22 of January, 2019
            Console.WriteLine($"Day{date: dd} of {date:MMMM}, {date:yyyy}");

            //FOUR : Year: 2019, Month: 01, Day: 22
            Console.WriteLine($"Year:{date:yyyy}, Month:{date:MM}, Day:{date:dd}");

            //FIVE : Tuesday (10 spaces total, right aligned)
            Console.WriteLine($"{date, 10:dddd}");

            //SIX : 11:01 PM             Tuesday (10 spaces total for each including the day-of-week, both right-aligned)
            Console.WriteLine($"{date:t} {date, 10: dddd}");

            //SEVEN : h:11, m:01, s:27
            Console.WriteLine($"h:{date:hh}, m:{date:mm}, s:{date:ss}");

            //EIGHT : 2019.01.22.11.01.27
            Console.WriteLine($"{date:yyy}.{date:mm}.{date:dd}.{date:hh}.{date:mm}.{date:ss}");

        }
    }
}

//This shows the current time = DateTime.Now;
//for logging use UTC time = DateTime.UtcNow;