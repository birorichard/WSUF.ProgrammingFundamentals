Console.WriteLine("A modulus operátor visszatérési értéke két szám osztása utáni maradék.");
int dividend = 17;
int divisor = 5;
int remainder = dividend % divisor;
Console.WriteLine("A {0} és {1} osztása után a maradék: {2}", dividend, divisor, remainder);

Console.WriteLine("\n");

Console.WriteLine("Inkrementáló operátor megnöveli a változó értékét eggyel, míg a dekrementáló ugyanennyivel csökkenti");
int number = 10;
// Increment the number by 1
Console.WriteLine("A szám értéke inkrementálás előtt: " + number);
number++;
Console.WriteLine("A szám értéke inkrementálás után: " + number);

// Decrement the number by 1
number--;
Console.WriteLine("A szám éréke dekrementálás után: " + number);
