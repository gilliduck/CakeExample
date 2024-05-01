namespace CakeTest.ConsoleApp;

internal class Program
{
    private static void Main()
    {
#if DEBUG
        Console.WriteLine("Hello from Dev");
#endif
#if RELEASE
            Console.WriteLine("Hello from Release");
#endif
    }
}