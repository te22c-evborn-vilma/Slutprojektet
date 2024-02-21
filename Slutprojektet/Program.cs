using System;
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
    if (position == "layDown")
    {
        Console.WriteLine("Varför ska jag ens försöka göra något? Lika bra att ge upp.");
        position = "leave";
    }
    if (position == "sitUp")
    {
        Console.WriteLine("Hmmm... Det ser ut som att jag sitter på en strand, med havet som sträcker sig så långt jag kan se...Hmmm...Är den här ryggsäcken min? Den ligger ju bredvid mig.");
        Console.WriteLine("\n1. Kolla vad som finns i ryggsäcken\n2. Resa mig upp");

        string choice = Console.ReadLine();
        choice = choice.ToLower();

        if (choice == "1")
        {
            Bag();
            // class eller metod??
            position = "sitUp";
        }
        if (choice == "2")
        {
            position = "standUp";
        }
    }
    if (position == "standUp")
    {
        Console.WriteLine("Wow! Stranden är så stor. Och djungeln bakom mig har så höga träd. Vad ska jag göra nu?");
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
        Console.WriteLine("Inget märkvärdigt att se förutom havet till höger och djungeln till vänster. Timmarna går. Jag fortsätter gå.\nSplash\nVad var det?");
        Console.WriteLine("1. Kolla i ryggsäcken\n2. Undersök vart ljudet kom ifrån\n3. Gå vidare");

        string choice = Console.ReadLine();
        choice = choice.ToLower();

        if (choice == "1")
        {
            Bag();
        }
        if (choice == "2")
        {
            position = "";
        }
        if (choice == "3")
        {
            position = "continueWalkOnBeach";
        }
    }
    if (position == "continueWalkOnBeach")
    {
        Console.WriteLine("Efter ytterliggare några timmars promenerande ser jag hur sanden börjar röra sig under mig. Jag dyker åt sidan precis innan något hoppar upp ur sanden framför mig. Det ser ut som att... en jättekrabbe försöker attackera mig! Ånej, vad ska jag göra?");
        Console.WriteLine("1. Kolla i ryggsäcken\n2. Dra fram mitt svärd från ryggsäcken och försvara mig\n3. Spring därifrån!!");

        string choice = Console.ReadLine();
        choice = choice.ToLower();

        if (choice == "1")
        {
            Console.WriteLine("Jag hinner inte kolla i ryggsäcken innan jättekrabban attackerar mig med sina stora klor. I mina sista stunder funderar jag på vad jag skulle ha kunnat göra bättre.");
            position = "leave";
        }
        
    }
/* ----------------------------------------------------------------------------
    POSITION: WATER 
-----------------------------------------------------------------------------*/
    if (position == "")
    {

    }
/* ----------------------------------------------------------------------------
    POSITION: DJUNGLE
-----------------------------------------------------------------------------*/
    if (position == "exploreDjungle")
    {

    }
}
Console.ReadLine();


static void Bag()
{
    Console.WriteLine("Min väska innehåller:");
}