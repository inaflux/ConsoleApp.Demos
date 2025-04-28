using System.Security.Cryptography;

namespace ConsoleApp.Classes
{
    internal partial class Program
    {
        public partial class Person
        {
            public class Teacher : Person
            {
                public void GenerateIDNumber()
                {
                    _idNumber = "TCH-" + GetRandomNum();

                }
            }
        } 

    }
}


