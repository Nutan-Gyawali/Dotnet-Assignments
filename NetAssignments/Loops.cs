using System;

public class Loops
{
    public Loops()
    {
        // While loop demonstration
        int a = 0;
        while (a < 5)
        {
            Console.WriteLine("Demonstration of While Loop \t" + a); // Print numbers from 0 to 9
            a++;
        }

        Console.WriteLine("\n");
        
        for (int b = 0; b < 5; b++ )
        {
            Console.WriteLine("Demonstraion of For Loop \t" + b);
        }
        Console.WriteLine("\n");
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        foreach (string c in cars)
        {
            Console.WriteLine("Demonstration of ForEach Loop \t" + c);
        }
    }
}
