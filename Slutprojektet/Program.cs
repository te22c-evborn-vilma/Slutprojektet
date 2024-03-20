using System;
using System.Collections.Generic; //för att listor ska fungera
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
        position = Places.BeachPlace(position);
    }
/* ----------------------------------------------------------------------------
    POSITION: DJUNGLE
-----------------------------------------------------------------------------*/
    if (position == "exploreDjungle")
    {
        position = Places.DjunglePlace(position);
    }
}
/* ----------------------------------------------------------------------------
    POSITION: HOUSE
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
        Console.WriteLine("Du känner att du ligger på något mjukt och hör någon som stompar runt omkring dig. Efter några misslyckade försök lyckas du sakta öppna ögonen. ");
        position = "leave";
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

static void CheckChoice()
{
    // while (choice != "a" || choice != "b" || choice != "c")
    // {

    // }
}
