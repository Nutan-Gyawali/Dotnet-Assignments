using NetAssignments;
using System;
using static NetAssignments.DynamicPolymorphism;

internal class Program
{
    private static void Main(string[] args)
    {

        //Assignment 1 
        Loops loopsDemo = new Loops();

        //Assignment 2
        Swap swapDemo = new Swap();

        // Assignment 3 / Date : 12/2/2024
        Animal myAnimal = new Animal();
        Animal myCat = new Cat();
        Animal myDog = new Dog();         
           

        myAnimal.Sound();  
        myDog.Sound();
        myCat.Sound();
    }
}
