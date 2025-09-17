namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, fullName;
            Console.WriteLine("What is your First name?");
            firstName = Console.ReadLine();
            Console.WriteLine("What is your Last name?");
            lastName = Console.ReadLine();
            fullName = firstName + " " + lastName;
            Console.WriteLine("Hello " + fullName);
            Console.WriteLine("Give me a number!");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give me a second number!");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give me a third number!");
            double z = Convert.ToDouble(Console.ReadLine());
            double a = x + y + z;
            Console.WriteLine("If you add those numbers together it equals " + a);
            Console.WriteLine("If you subtract the second number from the first, it equals " + (x -
            y));
            Console.WriteLine("If you multiply the first two numbers, it equals " + (x * y));
            Console.WriteLine("If you divide the first number by the second, it equals " + (x / y));
            Console.ReadLine(); // Keeps the window open
        }
    }
}