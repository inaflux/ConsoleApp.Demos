namespace ConsoleApp.StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initalize with a regular string literal
            string s1 = "This is a literal string";

            //delcare without initalizing 
            string s2;

            //initialize to null
            string? s3 = null;

            //intialize as empty string
            string s4 = string.Empty;
            string s5 = " ";

            //escape sequences and characters
            string sentence = "She said, \"Boooody\"";

            //verbatim string literal
            string oldPath = "C:\\program files\\programfolder\\";
            string newPath = @"C:\program files\programfolder\";

            //use a const string to prevent modification to a string
            const string  path = "C:\\program files\\programfolder\\";

            //raw string literals
            string rawLiteral = """reggr\rvgr rkr hi, shaid "dde" """;

            //Review concatenation and interpolation
            s1 = s1 + sentence ; //bad practice 
            string newString = $"hi {s1}";

            /* string maniuplation methods */

            //Substring

            //null or empty checks

            //splitting string

            //
        }
    }
}
