class Places
{
    public static string StartPlace(string position)
    {
        Console.WriteLine("Det första jag ser när jag öppnar ögonen är blått. Efter ett tag inser jag att jag kollar på en himmel.\nMen det kan väl inte stämma. Det sista jag kommer ihåg var att jag... Vad var det sista jag gjorde nu igen?\nJag kommer inte ihåg någonting. Vad ska jag göra nu?");
        Console.WriteLine("\n1. Ligga kvar på vad som känns som sand och fundera på vad som händer\n2. Resa mig upp och kolla vart jag är");

        string choice = Console.ReadLine();
        choice = choice.ToLower();

        if (choice == "1")
        {
            Console.WriteLine("hej");
            position = "layDown";
        }
        else if (choice == "2")
        {
            Console.WriteLine("hejdå");
            position = "sitUp";
        }
        else
        {
            Console.WriteLine("Jag har inget annat val. Vad ska jag göra?");
            Console.ReadLine();
        }
        return position;
    }
}