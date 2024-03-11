using System;
using System.Collections.Generic;
using System.Security.Cryptography; //för att listor ska fungera
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
    // placera allt i Places.cs - inte massa if satser här
    if (position == "standUp")
    {
        position = Places.BeachPlace(position);
    }
    if (position == "walkOnBeach")
    {
        position = Places.BeachPlace(position);
    }
    if (position == "continueWalkOnBeach")
    {
        Console.WriteLine("Efter några timmars promenerande märker du hur sanden börjar röra på sig under dig. Du lyckas dyka åt sidan precis innan något hoppar upp ur sanden. Det ser ut som en... jättekrabba.");
        Console.WriteLine("Kolla i ryggsäcken, dra fram svärdet från ryggsäcken och slå krabban eller spring därifrån (kolla, svärd, spring)");

        string choice = Console.ReadLine();
        choice = choice.ToLower();

        if (choice == "kolla")
        {
            Console.WriteLine("Du hinner inte kolla i ryggsäcken innan jättekrabban attackerar dig med sina stora klor. I dina sista stunder funderar du på vad du skulle ha kunnat göra bättre.");
            position = "leave";
        }
        if (choice == "svärd")
        {
            Console.WriteLine("Du drar fram ditt svärd");
            position = "fightCrab";
        }
        if (choice == "spring")
        {
            Console.WriteLine("Du rusar därifrån och upptäcker snabbt att bästa sättet att komma bort från krabban är att springa in i skogen.");
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
        // fight ska vara någon metod - hur?
        Console.WriteLine("Slå på krabbans huvud eller en av dess klor. (huvud, klo)");
        Console.ReadLine();

        int playerHP = 100;
        int enemyHP = 100;

        Random generator = new Random();

        while (playerHP > 0 && enemyHP > 0)
        {

        }

        Fight();
    }

Console.ReadLine();

// ändra till en bool eller liknande?
static void Fight()
{
     
}

static void Bag()
{
    Console.WriteLine("Ryggsäcken innehåller:");
    // string[] items = {"Sword", "Letter"};
    // int i = 0;

    // for (int i = 0; i < items.Length; i++)
    // {
    //     Console.WriteLine(items[i]);
    // }

    // Lista för att utrymmet i ryggsäcken inte ska vara begränsat
    List<string> items = new List<string>() {"Svärd" , "Brev"};
    
    // för att enklare kunna lägga till nya saker och så att det skrivs ut tillsammans [0], [1], [2]
    foreach (string item in items)
    {
        Console.WriteLine(item);
    }
}
