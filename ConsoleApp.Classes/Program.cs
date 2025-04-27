namespace ConsoleApp.Classes
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******* Classes and Objects *******");

            //Define an object of type Person
            Person person; // this will be null by default

            Person baby = new Person();

            baby.LastName = "Henderson";
            baby.FirstName = "Jacob";
            baby.DateOfBirth = new DateOnly(1996, 02, 07);


            // Console.WriteLine($"{baby.FirstName} {baby.LastName}"); 
            baby.PrintFullName();
            baby.PrintInitials();
            baby.GenerateTaxNumber();

            var taxNumber = baby.GetTaxNumber();
            Console.WriteLine($"Tax Number: {taxNumber}");

            var person1 = new Person("Luna", "McMittens", new DateOnly(2020, 04, 22));
            Console.WriteLine();

            person1.PrintFullName();
            person1.PrintInitials();
            person1.PrintDateOfBirth();

            var person2 = new Person("Chan", "Henderson", "2332445");
            person2.PrintFullName();
            person2.PrintInitials();
            person2.GenerateTaxNumber();



        }




    }
}


