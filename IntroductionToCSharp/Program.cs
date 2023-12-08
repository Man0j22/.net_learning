using System; //namespace declaration
//A namespace is used to organize your code and is collection of classes, enums, interfaces, structs, delegates.
// A Namespace can contain other Namepaces also.

class program // Any piece of code should be write inside class
{
    static void Main1()
    {
        Console.WriteLine("helloo....");
    }
    static void Main() //Main method is the entry point into the application
    { // starts here

        Console.WriteLine("Welcome to c# training");
        //Console is a class from .netframework; used to write or read messages into console window; 
        Main1();
    } // terminates here
}