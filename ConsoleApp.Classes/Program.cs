using static ConsoleApp.Classes.Program.Person;

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
            var person2IDNumber = person2.GetIDNumber();
            Console.WriteLine(person2IDNumber);
            Console.WriteLine();

            var teacher = new Teacher();
            teacher.LastName = "Goobie";
            teacher.FirstName = "Hootie";
            teacher.DateOfBirth = new DateOnly(1996, 02, 07);

            teacher.PrintFullName();
            teacher.PrintInitials();
            teacher.GenerateTaxNumber();
            teacher.GenerateIDNumber();

            var teacherIDNumber = teacher.GetIDNumber();
            Console.WriteLine(teacherIDNumber);


            Console.WriteLine();


            Student student = new();
            student.LastName = "Henderson";
            student.FirstName = "Jacob";
            student.DateOfBirth = new DateOnly(1996, 02, 07);

            student.PrintFullName();
            student.PrintInitials();
            student.GenerateTaxNumber();
            student.GenerateStudentIDNum();
            var studentIDNumber = student.GetIDNumber();
            Console.WriteLine(studentIDNumber);

            // Polygon polygon = new Polygon(); //compiler error
            Rectangle rectangle = new(20, 10);
            var rectArea = rectangle.Area();
            Console.WriteLine($"Rectangle area is: {rectArea}");

            Square square = new(50);
            var squareArea = square.Area();
            Console.WriteLine($"Square area is: {squareArea}");
        }
    }




    
}


