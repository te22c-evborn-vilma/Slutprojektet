using System;
// using System.Collections.Generic; //för att listor ska fungera
using System.Security.Cryptography;
using System.Xml.Serialization;
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
    if (position == "standUp")
    {
        position = Places.BeachPlace(position);
    }
/* ----------------------------------------------------------------------------
    POSITION: WATER 
-----------------------------------------------------------------------------*/
    if (position == "exploreSound")
    {
        position = Places.WaterPlace(position);
    }
/* ----------------------------------------------------------------------------
    POSITION: DJUNGLE
-----------------------------------------------------------------------------*/
    if (position == "exploreDjungle")
    {
        position = Places.DjunglePlace(position);
    }
/* ----------------------------------------------------------------------------
    POSITION: HOUSE
-----------------------------------------------------------------------------*/
    if (position == "wakeUp")
    {
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine("......");
            i++;
            Console.ReadLine();
        }

        Console.WriteLine("Du känner att du ligger på något mjukt och hör någon som stompar runt omkring dig. Efter några misslyckade försök lyckas du sakta öppna ögonen.");
        position = "leave";
    } 
}

/* ----------------------------------------------------------------------------
    POSITION: FIGHT
-----------------------------------------------------------------------------*/
    if (position == "fightCrab")
    {
        // fight ska vara någon metod - hur?
        Console.WriteLine("a) Slå på krabbans huvud eller b) en av dess klor");
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
    // en array eftersom jag vill att den ska ha ett bestämt antal platser
    string[] items = new string[3];
    items[0] = "Svärd";
    items[1] = "Banan";
    // skriver ut varje string element
    foreach (string i in items)
    {
        Console.WriteLine(i);
    }
}

static void CheckAnswer()
{
    // while (choice != "a" || choice != "b" || choice != "c")
    // {

    // }
}

static string Answer() {
    string choice = Console.ReadLine();
    choice = choice.ToLower();

    if (choice != "a" | choice != "b" | choice != "c")
    {
        Console.WriteLine("Du måste svara.");
    }

    return choice;
}