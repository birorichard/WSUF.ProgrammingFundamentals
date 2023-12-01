Console.WriteLine("Vezérlő szerkezetek");
Console.WriteLine("Órai munka - 2023.09.23.");

// Létrehozunk egy tömb típusú változót, amibe integer típusú értékeket tudunk tenni.
// Tömbök indexelése 0-val kezdődik
int[] temperatureInCelsiusToday = new int[] 
{ 
    /*0. elem: */17, /*1. elem: */16, /*2. elem: */14, /*3. elem: */13, 15, 17, 22, 25, 27, 32
};

int temperatureValueWithIndexThree = temperatureInCelsiusToday[3];
int thirdTtemperatureValue = temperatureInCelsiusToday[2];

// 13 lesz az eredmény:
Console.WriteLine($"A tömb hármas indexű eleme: {temperatureValueWithIndexThree}");

// 14 lesz az eredmény:
Console.WriteLine($"Ami nem egyezik meg a harmadik elemmel (annak az index-e kettő): {thirdTtemperatureValue}");

foreach (var item in temperatureInCelsiusToday)
{
    Console.WriteLine(item);
}

// Ciklusvezérlés
for (/*Ciklusváltozó, csak a for cikluson belül létezik */ int i = 0; /*Végfeltétel: */i < temperatureInCelsiusToday.Length - 1; i++)
{
    #region Ciklusmag
    Console.WriteLine($"Az {i}. elem értéke: {temperatureInCelsiusToday[i]}");
    
    // HA kisebb vagy egyenlő mint 15, akkor irjuk ki, hogy "Az érték 15-nél kisebb vagy egyenlő!"
    // KÜLÖNBEN írjuk ki: "Az érték nagyobb mint 15."
    if(temperatureInCelsiusToday[i] <= 15)
    {
        Console.WriteLine("Az érték 15-nél kisebb vagy egyenlő!");
    }
    else
    {
        Console.WriteLine("Az érték nagyobb mint 15.");
    }
    // Új sor jel
    Console.WriteLine("\n");
    #endregion Ciklusmag
}
