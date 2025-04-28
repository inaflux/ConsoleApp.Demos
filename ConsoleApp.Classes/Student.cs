namespace ConsoleApp.Classes
{
    internal partial class Program
    {
        public partial class Person
        {
            public class Student : Person
            {
                public void GenerateStudentIDNum()
                {
                    _idNumber = "STU-" + GetRandomNum();
                }
            }
        } 

    }
}


