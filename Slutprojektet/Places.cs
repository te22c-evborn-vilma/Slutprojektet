// inspiration från Bad Structure-projektet

using System.ComponentModel;

class Places
{
    public static string StartPlace(string position)
    {
        if (position == "start")
        {
            Console.WriteLine("Du ser en massa blått när du öppnar ögonen. Det är troligtvis en himmel.\nDu minns inte varför du kollar på en himmel.\nNär du tänker efter kommer du inte ihåg någonting.");
            Console.WriteLine("\nKolla i föremålet som ligger bredvid dig eller ställ dig upp. (kolla, stå upp)");

            // Bad Structure-projektet  ------------------------------------------------------
            string choice = Console.ReadLine();
            choice = choice.ToLower();
            // ------------------------------------------------------------------------------

            if (choice == "kolla")
            {
                Console.WriteLine("Det verkar vara en ryggsäck med saker i.");
                position = "checkBag"; //använda metoden bag() här?
            }
            else if (choice == "stå upp")
            {
                position = "standUp";
            }
            else
            {
                Console.WriteLine("Du har inget annat val.");
                position = "start";
            }
        }

        return position;
    }

    public static string BeachPlace(string position)
    {
        if (position == "standUp")
        {
            Console.WriteLine("Du står på en strand som sträcker sig så långt ögat kan se åt båda håll. Framför dig ser du havet möta horisonten. Bakom dig finns en djungel med höga träd.");
            Console.WriteLine("Kolla i ryggsäcken, gå längs med stranden eller utforska djungeln (kolla, stranden, djungeln)");

            string choice = Console.ReadLine();
            choice = choice.ToLower();

            if (choice == "kolla")
            {
                // Bag();
                position = "checkBag";
            }
            if (choice == "stranden")
            {
                position = "walkOnBeach";
            }
            if (choice == "djungeln")
            {
                position = "exploreDjungle";
            }
        }
        if (position == "walkOnBeach")
        {
            Console.WriteLine("Du ser bara stranden framför dig, den verkar aldrig ta slut.Du fortsätter gå framåt.\nSplash\nEtt plötsligt ljud får dig att kolla dig omkring.");
            Console.WriteLine("Kolla i ryggsäcken, undersök vart ljudet kom ifrån eler gå vidare (kolla, undersök, gå vidare)");

            string choice = Console.ReadLine();
            choice = choice.ToLower();

            if (choice == "kolla")
            {
                // Bag();
                position = "checkBag";
            }
            if (choice == "undersök")
            {
                position = "exploreSound";
            }
            if (choice == "gå vidare")
            {
                position = "continueWalkOnBeach";
            }
        }

        
        return position;
    }
}