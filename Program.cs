internal class Program
{
    private static void Main(string[] args)
    {
        calculatefactorial(5);
    }

    static void calculatefactorial(int number)
    {
        int fact2 = 1;
        for (int i = number; i > 1; i--)
        {
            fact2 = fact2 * i;
        }
        Console.WriteLine("The factorial of " + number + " is " + fact2);
    }
}