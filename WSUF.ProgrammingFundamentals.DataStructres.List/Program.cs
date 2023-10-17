Console.WriteLine("List létrehozása és inicializálása:");


List<int> numbers = new List<int>(); // Üres integer-eket tartalmazó lista

List<string> fruits = new List<string>
{
    "Banana", "Apple", "Orange", "Cherry"
}; // string-eket tartalmazó lista létrehozása.

Console.WriteLine($"fruits lista elemei: {string.Join(", ", fruits)}");
Console.WriteLine("\n");


// Elemek hozzáadása és eltávolítása:
numbers.Add(1); // Hozzáad egy elemet a lista végére
numbers.AddRange(new int[] { 5, 3, 7 }); // Hozzáad egy elemkollekciót
Console.WriteLine($"numbers lista elemei: {string.Join(", ", numbers)}");
Console.WriteLine("\n");


fruits.Remove("Cherry"); // Törli a megadott elemet
fruits.RemoveAt(0); // Törli az elemet az 0. indexen
Console.WriteLine($"fruits lista elemei az eltávolítás után: {string.Join(", ", fruits)}");
Console.WriteLine($"numbers lista elemei az eltávolítás után: {string.Join(", ", numbers)}");
Console.WriteLine("\n");


// Elemek elérése:
int elsoSzam = numbers[0]; // Az első elem elérése (0. index)

string fruitStartsWithA = fruits.Find(fruit => fruit.StartsWith("A"));
List<string> frutisThatContainsNLetter = fruits.FindAll(fruit => fruit.Contains('n'));
Console.WriteLine($"A-val kezdődő gyümölcs: {fruitStartsWithA}");
Console.WriteLine($"n betűt tartalmazó gyümölcsök: {string.Join(", ", frutisThatContainsNLetter)}");

// Lista bejárása:
Console.WriteLine("\n");
Console.WriteLine("Lista bejárása kétféle módon (eredmény ugyanaz):");
Console.WriteLine("Számok:");
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("\n");
Console.WriteLine("Gyümölcsök:");
fruits.ForEach(fruit => Console.WriteLine(fruit));
Console.WriteLine("\n");


// Lista rendezése:
numbers.Sort(); // A lista rendezése növekvő sorrendben
fruits.Sort(); // A lista rendezése ábécé sorrendben

Console.WriteLine($"fruits list a rendezést követően: {string.Join(", ", fruits)}");
Console.WriteLine($"numbers list a rendezést követően: {string.Join(", ", numbers)}");
Console.WriteLine("\n");


// Elem létezésének ellenőrzése:
bool containsApple = fruits.Contains("Apple");
Console.WriteLine($"A fruits lista tartalmaz almát? {(containsApple ? "Igen" : "Nem")}");

// A cseresznét korábban eltávolítottuk, ellenőrizzük, hogy tartalmazza-e
bool containsCherry = fruits.Contains("Cherry");
Console.WriteLine($"A fruits lista tartalmaz cseresznyét? {(containsCherry ? "Igen" : "Nem")}");
Console.WriteLine("\n");


// Lista mérete:
int countOfNumbers = numbers.Count;
Console.WriteLine($"A numbers lista mérete: {countOfNumbers}");
Console.WriteLine("\n");


// Lista törlése:
numbers.Clear();
countOfNumbers = numbers.Count;
Console.WriteLine($"A numbers lista mérete a törlés után: {countOfNumbers}");
