// Példa egy szótár létrehozására és elemek hozzáadására
Dictionary<string, int> dictionary = new();

// Hozzáadás az elemekhez
dictionary["one"] = 1;
dictionary["two"] = 2;
dictionary["three"] = 3;

// Példa: Elemek lekérése a szótárból
int value = dictionary["one"];
Console.WriteLine("Az érték a kulcs 'one' alatt: " + value); // Az érték a kulcs 'one' alatt: 1

// Ellenőrzés, hogy létezik-e egy kulcs a szótárban
bool existsKey = dictionary.ContainsKey("two");
Console.WriteLine("Létezik a kulcs 'two'? " + existsKey); // Létezik a kulcs 'two'? True

// Példa: Bejárás az összes kulcs-érték pár megjelenítésére
foreach (var key in dictionary.Keys)
{
    int valueForKey = dictionary[key];
    Console.WriteLine("Kulcs: " + key + ", Érték: " + valueForKey);
}
// Eredmény:
// Kulcs: one, Érték: 1
// Kulcs: two, Érték: 2
// Kulcs: three, Érték: 3

// Példa: Elem törlése a szótárból
dictionary.Remove("three");

// Ellenőrzés, hogy a kulcs törlésre került-e
bool keyRemoved = dictionary.ContainsKey("three");
Console.WriteLine("A kulcs 'three' törölve lett? " + keyRemoved); // A kulcs 'three' törölve lett? False
