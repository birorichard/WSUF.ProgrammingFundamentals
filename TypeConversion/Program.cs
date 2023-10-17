// Implicit type conversion

int intValue = 100;
double doubleValue = intValue; // Implicit conversion from int to double
Console.WriteLine($"Az eredeti Int típusú változó értéke: {intValue}");
Console.WriteLine($"Double típusra történő átalakítás után: {doubleValue}");

Console.WriteLine("\n");

// Explicit type conversion
doubleValue = 123.45;
intValue = (int)doubleValue; // Explicit conversion from double to int
Console.WriteLine($"Az eredeti Double típusu változó értéke: {doubleValue}");
Console.WriteLine($"Int típusra történő átalakítás után: {intValue}");
