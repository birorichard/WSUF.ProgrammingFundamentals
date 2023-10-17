// Tömbök deklarációja és inicializációja:


// int tömb deklarációja és inicializációja
int[] numbers = { 1, 2, 3, 4, 5 };


// string deklarációja és inicializációja
string[] fruits = { "Apple", "Banana", "Cherry", "Orange" };


// Hozzáférés a tömb elemeihez
int secondNumber = numbers[1]; // második elem (1-es index)
string fourthFruit = fruits[3]; // negyedik elem (3-as index)
Console.WriteLine($"Második szám: {secondNumber}.");
Console.WriteLine($"Negyedik gyümölcs: {fourthFruit}.");
Console.WriteLine("\n");


// Tömb elemeinek módosítása
numbers[1] = 99; // Második elem (index 1) megváltoztatása 99-re
fruits[3] = "Grapes"; // Negyedik elem megváltoztatása "Grapes"-re
secondNumber = numbers[1]; // második elem (1-es index)
fourthFruit = fruits[3]; // negyedik elem (3-as index)
Console.WriteLine($"Második szám a változás után: {secondNumber}.");
Console.WriteLine($"Negyedik gyümölcs a változás után: {fourthFruit}.");
Console.WriteLine("\n");


// Tömb hosszának lekérése
int lengthOfNumbers = numbers.Length;
int lengthOfFruits = fruits.Length;
Console.WriteLine($"A számokat tartalmazó tömb {lengthOfNumbers} elemet tartalmaz.");
Console.WriteLine($"A gyümölcsöket tartalmazó tömb {lengthOfFruits} elemet tartalmaz.");
Console.WriteLine("\n");


// Iterálás a tömbök elemein
Console.WriteLine("Iteráció a számokat tartalmazó tömbön:");
foreach (int num in numbers)
{
    Console.WriteLine(num);
}
Console.WriteLine("\n");

Console.WriteLine("Iteráció a gyümölcsöket tartalmazó tömbön:");
for (int i = 0; i < fruits.Length; i++)
{
    Console.WriteLine(fruits[i]);
}
Console.WriteLine("\n");

// Több dimenziós tömb
Console.WriteLine("Hozzáférés többdimenziós tömb eleméhez:");
int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int value = matrix[1, 2]; // Hozzáférés az második sor, harmadik oszlopának eleméhez (az érték 6 lesz)
Console.WriteLine($"Az első sor, második oszlop eleme: {value}");
Console.WriteLine("\n");
