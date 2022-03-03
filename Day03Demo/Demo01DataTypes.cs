// See https://aka.ms/new-console-template for more information
//Demo01DataTypes.TestIntegralTypes();
//Demo01DataTypes.TestOthers();
class Demo01DataTypes
{
    public static void TestIntegralTypes()
    {
        sbyte var1 = 10;
        int age = 10;

        //sbyte numOfVoters;
        //int numOfVoters2;
        ulong numOfVoters3;
        Console.WriteLine("Enter number of voters in mumbai: ");
        string numText = Console.ReadLine();
        numOfVoters3 = ulong.Parse(numText);
        //numOfVoters2 = int.Parse(numText);
        //numOfVoters = sbyte.Parse(numText);
        Console.WriteLine("You entered " + numOfVoters3);


        long numOfMalesInIndia = -100;
        //uint x = -110;
        int y = -220;

        Int32 x1 = 10;
        int x2 = 10;

        int num1 = 10;

        Console.WriteLine(num1);
    }

    public static void TestDecimalPoints()
    {
        float x = 10.555F;
        Console.WriteLine(x);

        double y = 200933.33333D;

        decimal z = 34434344343434.34343M;
    }

    public static void TestOthers()
    {
        char gender = 'M';      // char == ascii value
        
        char ch1 = '9';         // 9, 9, 57
        char ch2 = (char)9;     // 9, 57, 9

        int x = 125;

        char ch = '#';

        Console.WriteLine(ch);
        Console.WriteLine((int)ch);
        Console.WriteLine((int)ch1);

        Console.WriteLine(" x = " + x);
        Console.WriteLine(" x = " + (char)x);

        Console.WriteLine(" gender = " + gender);
        Console.WriteLine(" gender = " + (int)gender);
        Console.WriteLine(" ch1 = " + (int)ch1);
        Console.WriteLine(" ch2 = " + (int)ch2);


        bool isMarried = true;

        if (isMarried)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }

    public void TestReferenceTypes()
    {
        //Employee e = new Employee();
        string s = "Hello";        
    }
}
