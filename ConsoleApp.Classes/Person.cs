using System.Security.Cryptography;

namespace ConsoleApp.Classes
{
    internal partial class Program
    {
        //Define a class
        public partial class Person
        {

            //cosntructor
            public Person()
            {

            }

            public Person(string firstName, string lastName, DateOnly dob)
            {
                FirstName = firstName;
                LastName = lastName;
                DateOfBirth = dob;
            }

            public Person(string firstName, string lastName, string taxNumber)
            {
                FirstName = firstName;
                LastName = lastName;
                _taxNumber = taxNumber;
            }

            //Properties/Data Members
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateOnly DateOfBirth { get; set; }

            //Field Member
            private string _taxNumber;
            private string _idNumber;


            public void PrintFullName()
            {
                Console.WriteLine($"{FirstName} {LastName}");
            }

            public void PrintInitials()
            {
                var firstInitial = FirstName[0];
                var lastInitial = LastName[0];
                Console.WriteLine($"{firstInitial} {lastInitial}");
            }

            public void GenerateTaxNumber()

            {
                if (string.IsNullOrEmpty(_taxNumber))
                {
                    _taxNumber = RandomNumberGenerator.GetInt32(100000, 9999999).ToString();
                }

                else
                {
                    Console.WriteLine("Tax number already exists");
                }
            }

            public string GetTaxNumber()
            {
                return _taxNumber;
            }

            public void PrintDateOfBirth()
            {
                var dob = DateOfBirth;
                Console.WriteLine($"Date of Birth: {dob}");

            }

            public int GetAge()
            {
                var age = DateTime.Now.Year - DateOfBirth.Year;
                return age;
            }

            public int GetAge(int year)
            {
                var age = year - DateOfBirth.Year;
                return age;
            }
        } 

    }
}


