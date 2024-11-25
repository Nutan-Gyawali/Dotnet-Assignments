// Program to swap variables without using a temporary variable
internal class Program
{
    private static void Main(string[] args)
    {
        int a = 10;
        int b = 20;
        Console.WriteLine($"Before Swapping a = {a} and b = {b}");

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine($"Before Swapping a = {a} and b = {b}");

    }
}