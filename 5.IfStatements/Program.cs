using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a num ");
        int num = int.Parse(Console.ReadLine());//Parse -> converts string to int

        if (num == 0)
        {
            Console.WriteLine("Zero");
        }
        else if (num == 1)
        {
            Console.WriteLine("one");
        }
        else if (num == 2)
        {
            Console.WriteLine("two");
        }
        else if(num != 5 && num != 6)
        {
            Console.WriteLine("other");
        }
        else 
        { 
            Console.WriteLine("OTHER");
        }

        //Mulitple else if statements can be replaced by switch statement
        switch(num)
        {
            case 10:
                Console.WriteLine("ten");
                break;
            case 11:
            case 12:
                Console.WriteLine("num {0}", num);
                break;
            default:
                Console.WriteLine(">12");
                break;
        }
    }
}