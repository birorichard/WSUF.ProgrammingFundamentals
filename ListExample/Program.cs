Console.WriteLine("List adatszerkezet létrehozása, példák");

List<int> numbers = new List<int>(); // Üres integer-eket tartalmazó List adatszerkezet
// ez is ugyanugy megfelelne:
//var numbers = new List<int>();

List<string> fruits = new List<string>
{
    "Banán", "Alma", "Narancs", "Cseresznye", "Ananász"
};  // string-eket tartalmazó List adatszerkezet

Console.WriteLine("\n");
Console.WriteLine($"fruits lista elemei: { string.Join(", ", fruits) }");

Console.WriteLine("\n");

// Elemek hozzáadása és eltávolítása:
numbers.Add(1);  // Hozzáad egy elemet a lista végére
numbers.AddRange(new int[] { 5, 3, 7 });  // Hozzáad egy elemkollekciót

fruits.Remove("Cseresznye");
fruits.RemoveAll(kiscica => kiscica == "Cseresznye");

// Elemek elérése:
int elsoSzam = numbers[0];  // Az első elem elérése (0. index)

string fruitsStartsWithA = fruits.Find(fruit => fruit.StartsWith("A"));
Console.WriteLine($"Az első A betűvel kezdődő gyümölcs a listában: {fruitsStartsWithA}");

// Lista mérete:
int countOfNumbers = numbers.Count();
Console.WriteLine($"A numbers lista mérete: {countOfNumbers}");

numbers.Clear();