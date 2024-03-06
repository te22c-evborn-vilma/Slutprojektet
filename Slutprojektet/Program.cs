using System;
using System.Collections.Generic;
/* ----------------------------------------------------------------------------
    VARIABLER 
-----------------------------------------------------------------------------*/
#region WORLD STATS
string position = "start";
#endregion

while (position != "leave")
{
/* ----------------------------------------------------------------------------
    POSITION: START 
-----------------------------------------------------------------------------*/
    if (position == "start")
    {
        position = Places.StartPlace(position);
    }
/* ----------------------------------------------------------------------------
    POSITION: BEACH
-----------------------------------------------------------------------------*/  
    if (position == "checkBag")
    {
        Bag();
        position = "start";
    }
    if (position == "standUp")
    {
        Console.WriteLine("Du står på en strand som sträcker sig så långt ögat kan se åt båda håll. Framför dig ser du havet möta horisonten. Bakom dig finns en djungel med höga träd.");
        Console.WriteLine("1. Kolla i ryggsäcken\n2. Gå längs med stranden\n3. Gå och utforska djungeln");

        string choice = Console.ReadLine();
        choice = choice.ToLower();

        if (choice == "1")
        {
            Bag();
        }
        if (choice == "2")
        {
            position = "walkOnBeach";
        }
        if (choice == "3")
        {
            position = "exploreDjungle";
        }
    }
    if (position == "walkOnBeach")
    {
        Console.WriteLine("Du ser bara stranden framför dig, den verkar aldrig ta slut.Du fortsätter gå framåt.\nSplash\nEtt plötsligt ljud får dig att kolla dig omkring.");
        Console.WriteLine("1. Kolla i ryggsäcken\n2. Undersök vart ljudet kom ifrån\n3. Gå vidare");

        string choice = Console.ReadLine();
        choice = choice.ToLower();

        if (choice == "1")
        {
            Bag();
        }
        if (choice == "2")
        {
            position = "exploreSound";
        }
        if (choice == "3")
        {
            position = "continueWalkOnBeach";
        }
    }
    if (position == "continueWalkOnBeach")
    {
        Console.WriteLine("Efter några timmars promenerande märker du hur sanden börjar röra på sig under dig. Du lyckas dyka åt sidan precis innan något hoppar upp ur sanden. Det ser ut som en... jättekrabba.");
        Console.WriteLine("1. Kolla i ryggsäcken\n2. Dra fram svärdet från ryggsäcken och slå krabban.\n3. Spring därifrån.");

        string choice = Console.ReadLine();
        choice = choice.ToLower();

        if (choice == "1")
        {
            Console.WriteLine("Du hinner inte kolla i ryggsäcken innan jättekrabban attackerar dig med sina stora klor. I dina sista stunder funderar du på vad du skulle ha kunnat göra bättre.");
            position = "leave";
        }
        if (choice == "2")
        {
            Console.WriteLine("Du drar fram ditt svärd");
            position = "fightCrab";
        }
        if (choice == "3")
        {
            Console.WriteLine("Du rusar därifrån, men upptäcker snabbt att bästa sättet att komma bort från krabban är att springa in i skogen.");
            position = "hideInDjungle";
        }
    }
/* ----------------------------------------------------------------------------
    POSITION: WATER 
-----------------------------------------------------------------------------*/
    if (position == "exploreSound")
    {

    }
/* ----------------------------------------------------------------------------
    POSITION: DJUNGLE
-----------------------------------------------------------------------------*/
    if (position == "exploreDjungle")
    {

    }
    if (position == "hideInDjungle")
    {
        Console.WriteLine("");
    }
}
/* ----------------------------------------------------------------------------
    POSITION: FIGHT
-----------------------------------------------------------------------------*/
    if (position == "fightCrab")
    {
        Console.WriteLine("Slå på krabbans huvud eller en av dess klor.");
        Console.ReadLine();
        Fight();
    }

Console.ReadLine();

// ändra till en bool eller liknande
static void Fight()
{

}

static void Bag()
{
    Console.WriteLine("Min väska innehåller:");
}


// List<string> items = new List<string>();
