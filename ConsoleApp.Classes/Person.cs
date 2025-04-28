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
            private string _taxNumber;//becuase private only this class can access it
            protected string _idNumber = "N/A";// because protected both this class and the child class can access this 


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
                    _taxNumber =  GetRandomNum();
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

            public string GetIDNumber()
            {
                return _idNumber;
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

            protected string GetRandomNum()
            {
                return RandomNumberGenerator.GetInt32(100000, 9999999).ToString();
            }
        } 

    }
}


