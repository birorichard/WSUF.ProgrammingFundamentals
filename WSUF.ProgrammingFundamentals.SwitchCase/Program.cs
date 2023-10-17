Console.WriteLine("Közlekedési lámpa szimulálás");


bool running = true;
string color;

do
{

    Console.WriteLine("\nMilyen színű a lámpa (piros, sárga, vagy zöld)? A kilépéshez írja be, hogy exit.");
    color = Console.ReadLine();

    switch (color.ToLower())
    {
        case "piros":
            Console.WriteLine("Állj! A lámpa piros.");
            break;
        case "sárga":
            Console.WriteLine("Lassíts! A lámpa sárga.");
            break;
        case "zöld":
            Console.WriteLine("Mehetsz! A lámpa zöld.");
            break;
        case "exit":
            running = false;
            break;
        default:
            Console.WriteLine("Helytelen szín. A lámpa csak piros, sárga vagy zöld lehet.");
            break;
    }

} while (running);

