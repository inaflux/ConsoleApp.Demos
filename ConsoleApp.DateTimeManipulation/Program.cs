using System.Net.Http.Headers;

namespace ConsoleApp.DateTimeManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* DateTime mainipulation **********");
            //Empty DateTime
              DateTime dateTime = new DateTime();

            //Create a DateTime from date and time
            var dateofBirth = new DateTime(1980, 12, 23);
            Console.WriteLine($"My DOB is: {dateofBirth}");


            var dateAndTimeofBirth = new DateTime(1980,12,23, 14, 33, 56);
            Console.WriteLine($"My DOB is: {dateAndTimeofBirth}");

            Console.WriteLine($"Day of week: {dateofBirth.DayOfWeek}");
            Console.WriteLine($"Day of Year: {dateofBirth.DayOfYear}");
            Console.WriteLine($"Time of Day: {dateAndTimeofBirth.TimeOfDay}");
            Console.WriteLine($"Tick: {dateAndTimeofBirth.Ticks}");
            Console.WriteLine($"Kind: {dateAndTimeofBirth.Kind}");

            //Create a DateTime from current timestamp
            DateTime now = DateTime.Now;
            Console.WriteLine($"The current time is: {now}");

            ////Create a DateTime from a String
            //Console.WriteLine("What is your DOB (MM/dd/yyyy): ");
            //string dob = Console.ReadLine();

            //var userDob = DateTime.Parse(dob);

            //Console.WriteLine($"Day of week: {userDob.DayOfWeek}");
            //Console.WriteLine($"Day of Year: {userDob.DayOfYear}");
            //Console.WriteLine($"Time of Day: {userDob.TimeOfDay}");
            //Console.WriteLine($"Tick: {userDob.Ticks}");
            //Console.WriteLine($"Kind: {userDob.Kind}");


            ////Change Format DateTime 
            //Console.WriteLine($"Formatted Date: {userDob.ToString("MM/dd/yyyy")} ");
            ////Add additional Time
            //Console.WriteLine($"One hour from now is: {now.AddHours(1)}");
            //Console.WriteLine($"One day  from now is: {now.AddDays(1)}");



            Console.WriteLine("********* DateTime Offset mainipulation **********");


            //UTC
            var utcNow = DateTime.UtcNow;
            Console.WriteLine($"Now Date Time: {now}");
            Console.WriteLine($"UTC Now Date Time: {utcNow}");

            //DateTimeOffSet and TimeZone Info
            var tz = TimeZoneInfo.Local.GetUtcOffset(utcNow);
            Console.WriteLine($"User time zone: {tz}");

            var dto = new DateTimeOffset(now, tz);
            Console.WriteLine($"User Time Zone with UTC offset: {dto}");
            Console.WriteLine($"UTC Time of Action: {dto.UtcDateTime}");

            var indiaTz = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            var indiaDateTime = TimeZoneInfo.ConvertTimeFromUtc(dto.UtcDateTime, indiaTz);
            Console.WriteLine($"Action was completed in India at: {indiaDateTime}");

            Console.WriteLine("********* Date only and Time only mainipulation **********");

            //DateOnly

            //Time Only


        }
    }
}
