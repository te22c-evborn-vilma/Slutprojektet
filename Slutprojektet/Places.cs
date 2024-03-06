// inspiration från Bad Structure-projektet

using System.ComponentModel;

class Places
{
    public static string StartPlace(string position)
    {
        Console.WriteLine("Du ser en massa blått när du öppnar ögonen. Det är troligtvis en himmel.\nDu minns inte varför du kollar på en himmel.\nNär du tänker efter kommer du inte ihåg någonting.");
        Console.WriteLine("\n1. Kolla i föremålet som ligger bredvid dig.\n2. Ställ dig upp.");

        // Bad Structure-projektet  ------------------------------------------------------
        string choice = Console.ReadLine();
        choice = choice.ToLower();
         // ------------------------------------------------------------------------------

        if (choice == "1")
        {
            Console.WriteLine("Det verkar vara en ryggsäck med saker i.");
            position = "checkBag";
        }
        else if (choice == "2")
        {
            position = "standUp";
        }
        else
        {
            Console.WriteLine("Du har inget annat val.");
            position = "start";
        }
        return position;
    }

    public static string BeachPlace(string position)
    {
        
        
        return position;
    }
}