using System;

class program
{
    static void Main()
    {
        Console.WriteLine("Enter ur name: ");

        string name = Console.ReadLine();
        string name1 = Console.ReadLine();

        Console.WriteLine("Hello " + name +" "+ name1); //concatenation

        Console.WriteLine("Hello {0}, {1}", name, name1); //place holder syntax

    }
}
//note : c# is case-sensitive language
