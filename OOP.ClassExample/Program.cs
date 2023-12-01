using OOP.ClassExample;

var cat = new Cat();  // Új Cat típusú objektum létrehozása

string catsName = cat.GetName();  // A cica nevének lekérése

// A cica nevét tartalmazó változó kiírása. A cicának még nincs neve.
Console.WriteLine(catsName);  

cat.SetName("Fluffy");  // Elnevezzük a cicát.
catsName = cat.GetName();  // Frissítjük a változó tartalmát a cica nevével.

// Újra kiírjuk a cica nevét tartalmazó változó értékét.
Console.WriteLine(catsName);

cat.SetName("Felix");
catsName = cat.GetName();
Console.WriteLine(catsName);

cat.SetName("Bruce");
catsName = cat.GetName();
Console.WriteLine(catsName);

cat.SetName("Buci");
catsName = cat.GetName();
Console.WriteLine(catsName);