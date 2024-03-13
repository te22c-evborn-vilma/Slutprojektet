using System;
using System.Collections.Generic; //för att listor ska fungera
using System.Security.Cryptography; 
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
    POSITION: BAG
-----------------------------------------------------------------------------*/
    
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
        Console.WriteLine("Ljudet kom från havet. Hmmm... Du ser något som glittrar under vatten ytan. Kolla i ryggsäcken, plocka upp det glittrande föremålet eller gå vidare. (kolla, plocka upp, gå vidare)");
        
        string choice = Console.ReadLine();
        choice = choice.ToLower();

        if (choice == "kolla")
        {
            Bag();
        }
        if (choice == "plocka upp")
        {
            position = "pickUp";
        }
        if (choice == "gå vidare")
        {
            position = "continueWalkOnBeach";
        }
    }
    if (position == "pickUp")
    {
        Console.WriteLine("Det är en silvrig sten som är formad som en fyrklöver. Du lägger den i ryggsäcken och fortsätter vidare längs med stranden.");
        // items.Add("Sten");
        position = "continueWalkOnBeach";
    }
/* ----------------------------------------------------------------------------
    POSITION: DJUNGLE
-----------------------------------------------------------------------------*/
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
        Console.WriteLine("Du går förbi stenen och fortsätter framåt i djungeln. Plötsligt hör du en skrik. Ljudet kom uppifrån. När du kollar upp ser du en stor apa som sitter i ett träd och kollar på dig. När era ögon möts ger apan ifrån sig ett liknande skrik och hoppar ner från trädet, rakt mot dig. Kolla i ryggsäcken, dra fram svärdet eller spring därifrån (kolla, svärd, spring)");
        
        string choice = Console.ReadLine();
        choice = choice.ToLower();

        if (choice == "kolla")
        {
            Console.WriteLine("Du hinner inte börja kolla i ryggsäcken innan apan greppar tag i dig, runt din hals, och klämmer livet ur dig");
            position = "leave";
        }
        if (choice == "svärd")
        {

        }
        if (choice == "spring")
        {
            Console.WriteLine("Du hinner vända dig och börja springa åt ett annat håll innan du blir träffad av något tungt som får dig att ramla och slå i huvudet på en sten. Innan allt blir svart ser du hur apan närmar dig.");
            position = "wakeUp";
        }
    }
}
/* ----------------------------------------------------------------------------
    POSITION: FIGHT
-----------------------------------------------------------------------------*/
    if (position == "wakeUp")
    {
        Console.WriteLine("...");
        Console.ReadLine();
        Console.WriteLine(".........");
        Console.ReadLine();
        Console.WriteLine("...............");
        Console.ReadLine();
        Console.WriteLine(".....................");
        Console.ReadLine();
        Console.WriteLine("...........................");
        Console.ReadLine();
        Console.WriteLine("Du känner att du ligger på något mjukt och hör någon som stompar runt omkring dig. Ett några misslyckade försök lyckas du sakta öppna ögonen. ");
        position = "leave";
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
    List<string> items = new List<string>() {"Svärd" , "Banan"};
    
    // för att enklare kunna lägga till nya saker och så att det skrivs ut tillsammans [0], [1], [2]
    foreach (string item in items)
    {
        Console.WriteLine(item);
    }
}
