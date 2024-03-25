// inspiration från Bad Structure-projektet

using System.ComponentModel;

class Places
{
    public static string StartPlace(string position)
    {
        if (position == "start")
        {
            Console.WriteLine("Du ser en massa blått när du öppnar ögonen. Det är troligtvis en himmel.\nDu minns inte varför du kollar på en himmel.\nNär du tänker efter kommer du inte ihåg någonting.");
            Console.WriteLine("\na) Kolla i föremålet som ligger bredvid dig\nb) Ställ dig upp");

            // Bad Structure-projektet  ------------------------------------------------------
            string choice = Console.ReadLine();
            choice = choice.ToLower();
            // ------------------------------------------------------------------------------

            if (choice == "a")
            {
                Console.WriteLine("Det verkar vara en ryggsäck med saker i.");
                position = "checkBag"; //använda metoden bag() här?
            }
            else if (choice == "b")
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
            Console.WriteLine("a) Kolla i ryggsäcken\nb) Gå längs med stranden\nc) Utforska djungeln");

            string choice = Console.ReadLine();
            choice = choice.ToLower();

            if (choice == "a")
            {
                // Bag();
                position = "checkBag";
            }
            if (choice == "b")
            {
                position = "walkOnBeach";
            }
            if (choice == "c")
            {
                position = "exploreDjungle";
            }
        }
        if (position == "walkOnBeach")
        {
            Console.WriteLine("Du ser bara stranden framför dig, den verkar aldrig ta slut.Du fortsätter gå framåt.\nSplash\nEtt plötsligt ljud får dig att kolla dig omkring.");
            Console.WriteLine("a) Kolla i ryggsäcken\nb) Undersök vart ljudet kom ifrån\nc) Gå vidare");

            string choice = Console.ReadLine();
            choice = choice.ToLower();

            if (choice == "a")
            {
                // Bag();
                position = "checkBag";
            }
            if (choice == "b")
            {
                position = "exploreSound";
            }
            if (choice == "c")
            {
                position = "continueWalkOnBeach";
            }
        }
        if (position == "continueWalkOnBeach")
    {
        Console.WriteLine("Efter några timmars promenerande märker du hur sanden börjar röra på sig under dig. Du lyckas dyka åt sidan precis innan något hoppar upp ur sanden. Det ser ut som en... jättekrabba.");
        Console.WriteLine("a) Kolla i ryggsäcken\nb) Dra fram svärdet från ryggsäcken och slå krabban\nc) Spring därifrån");

        string choice = Console.ReadLine();
        choice = choice.ToLower();

        if (choice == "a")
        {
            Console.WriteLine("Du hinner inte kolla i ryggsäcken innan jättekrabban attackerar dig med sina stora klor. I dina sista stunder funderar du på vad du skulle ha kunnat göra bättre.");
            position = "leave";
        }
        if (choice == "b")
        {
            Console.WriteLine("Du drar fram ditt svärd");
            position = "fightCrab";
        }
        if (choice == "c")
        {
            Console.WriteLine("Du rusar därifrån och upptäcker snabbt att bästa sättet att komma bort från krabban är att springa in i skogen.");
            position = "hideInDjungle";
        }
    }
        
        return position;
    }

    public static string WaterPlace(string position)
    {
        if (position == "exploreSound")
        {
            Console.WriteLine("Ljudet kom från havet. Hmmm... Du ser något som glittrar under vatten ytan. \na) Kolla i ryggsäcken\nb) Plocka upp det glittrande föremålet\nc) Gå vidare");
            
            string choice = Console.ReadLine();
            choice = choice.ToLower();

            if (choice == "a")
            {
                // Bag();
                position = "checkBag";
            }
            if (choice == "b")
            {
                position = "pickUp";
            }
            if (choice == "c")
            {
                position = "continueWalkOnBeach";
            }
        }

        if (position == "pickUp")
        {
            Console.WriteLine("Det är en silvrig sten som är formad som en fyrklöver. Du lägger den i ryggsäcken och fortsätter vidare längs med stranden.");
            // items[2] = "Sten";
            position = "continueWalkOnBeach";
        }

        return position;
    }

    public static string DjunglePlace(string position)
    {
        if (position == "exploreDjungle")
        {
            Console.WriteLine("Du går in bland träden, hör fåglar som kvittrar och insekter som flyger förbi. Det är trångt att gå mellan träden, men du fortsätter framåt. Efter ett tag kommer du fram till en stor sten med vad ser ut som en dörr på.");
            // Om spelaren har stenen: använd den som nyckel.
            // Om spelaren inte har stenen: undersök och gå vidare. 
            position = "continueInDjungle";
        }

        if (position == "hideInDjungle")
    {
        Console.WriteLine("Du springer in i djungeln och upptäcker att jättekrabban inte följer efter dig. Vilken lättnad för dig. För din egen säkerhet är det nog bäst att du fortsätter framåt i djungeln.");

        position = "exploreDjungle";
    }
    if (position == "continueInDjungle")
    {
        Console.WriteLine("Du går förbi stenen och fortsätter framåt i djungeln. Plötsligt hör du ett skrik. Ljudet kom uppifrån. När du kollar upp ser du en stor apa som sitter i ett träd och kollar på dig. När era ögon möts ger apan ifrån sig ett liknande skrik och hoppar ner från trädet, rakt mot dig. \na) Kolla i ryggsäcken\nb) Dra fram svärdet\nc) Spring därifrån");
        
        string choice = Console.ReadLine();
        choice = choice.ToLower();

        if (choice == "a")
        {
            Console.WriteLine("Du hinner inte börja kolla i ryggsäcken innan apan greppar tag i dig, runt din hals, och klämmer livet ur dig");
            position = "leave";
        }
        if (choice == "b")
        {
            
        }
        if (choice == "c")
        {
            Console.WriteLine("Du hinner vända dig och börja springa åt ett annat håll innan du blir träffad av något tungt som får dig att ramla och slå i huvudet på en sten. Innan allt blir svart ser du hur apan närmar dig.");
            position = "wakeUp";
        }
    }
        return position;
    }
}
