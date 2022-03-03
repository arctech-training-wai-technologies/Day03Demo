// See https://aka.ms/new-console-template for more information
using System.Text;

class Demo03Literals
{
    public static void TestStringOthers()
    {
        string s = new string('=', 50);
        Console.WriteLine(s);

        string name = "Raman Gujral";
        double salary = 23500;
        DateTime dateOfBirth = new DateTime(1976, 8, 17);

        string s2 = string.Format("s2 => Salary of {0} is {1:N0} and his DOB is {2:D}", name, salary, dateOfBirth);
        Console.WriteLine(s2);

        string s3 = $"s3 => Salary of {name} is {salary:N0} and his dob is {dateOfBirth:dd-MMM-yyyy}";
        Console.WriteLine(s3);
    }

    public static void TestStringConcatenation()
    {
        string firstName = "James", lastName = "Bond", code = "007";

        {
            // Simple + concatenation. Very inefficent
            string agent = "Mr. " + firstName + " " + lastName + ", {" + code + "}";
            Console.WriteLine("Simple contactenation: " + agent);
        }

        {
            // String Concat method
            string agent = string.Format("Mr. {0} {1}, {{{2}}}", firstName, lastName, code);
            Console.WriteLine("string.Format method: " + agent);
        }

        {
            // Simple concatenation. Using StringBuilder
            StringBuilder sb = new StringBuilder();
            sb.Append("Mr. ").Append(firstName).Append(" ").Append(lastName).Append(", {").Append(code).Append("}");
            Console.WriteLine("using StringBuider: " + sb.ToString());
        }

        {
            // Simple concatenation. Using String Interpolation only post C# verion 6
            string agent = $"Mr. {firstName} {lastName}, {{{code}}}";
            Console.WriteLine("string Interpolation: " + agent);
        }
    }

    public static void TestStrings()
    {
        string s1 = "Hello World Mr. Jagan";
        string s2 = "Hello World\"Mr.Jagan\"";

        Console.WriteLine("Sound coming now \a");

        Console.Write("Testing backspace\b\b\b");

        Console.WriteLine("This is a slash. \\ Wow!! ");

        string path1 = "C:\\logs\\testing.txt";
        string path2 = @"C:\logs\testing.txt";

        Console.WriteLine("path1 = " + path1);
        Console.WriteLine("path2 = " + path2);

        string s3 = "Hello World\"Mr.Jagan\"";

        string s4 = "The red fox ran down the rabbit hole.\nNow his friends looked for him all over.\nWho goes there he says!!\nI am the fox stuck in a rabbit hole";

        string s5 = @"The red fox ran down the rabbit hole.
Now his friends looked for him all over.
Who goes there he says!!
I am the fox stuck in a rabbit hole";

        Console.WriteLine("s4 = " + s5);
    }

    public static void TestNumbers()
    {
        int num1 = 65;
        int num2 = 'A';
        int num3 = 0b01000001;
        int num4 = 0x41;

        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);
        Console.WriteLine("num3 = " + num3);
        Console.WriteLine("num4 = " + num4);
    }
}