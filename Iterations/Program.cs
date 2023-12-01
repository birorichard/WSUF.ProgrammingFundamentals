int[] temperatureInCelsiusToday = new int[]
{ 
    /*0. elem: */17, /*1. elem: */16, /*2. elem: */14, /*3. elem: */13, 15, 17, 22, 25, 27, 32
};

foreach (var item in temperatureInCelsiusToday)
{
    Console.WriteLine(item + 1);
}

Console.WriteLine("\n");

for (int i = 0; i < temperatureInCelsiusToday.Length; i++)
{
    Console.WriteLine(temperatureInCelsiusToday[i] + 1);
}