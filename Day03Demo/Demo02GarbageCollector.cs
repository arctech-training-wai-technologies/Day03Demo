// See https://aka.ms/new-console-template for more information
//Demo01DataTypes.TestIntegralTypes();
//Demo01DataTypes.TestOthers();

class Demo02GarbageCollector
{
    public static void Test()
    {
        while (true)
        {
            Console.WriteLine("Banking Software");
            Console.WriteLine("1. Add new Customer");
            Console.WriteLine("2. Add new Savings Account");
            Console.WriteLine("0. Exit");

            string keyText = Console.ReadLine();
            int key = int.Parse(keyText);

            if (key == 0)
                return;

            if (key == 1)
                AddNewCustomer();
            else if (key == 2)
                AddNewSavingsAccount();
        }
    }

    private static void AddNewSavingsAccount()
    {
        
    }

    private static void AddNewCustomer()
    {
        Console.WriteLine("Enter customer name");
        string name = Console.ReadLine();

        Console.WriteLine("Enter customer age");
        string ageText = Console.ReadLine();
        int age = int.Parse(ageText);

        // Datbase code goes here
        Console.WriteLine("This data was saved successfully");
    }
}