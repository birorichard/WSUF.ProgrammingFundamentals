Console.WriteLine("Típusok");

// Creating variables of different data types
int age = 30;                         // Integer
double salary = 50000.50;             // Double (floating-point number)
string name = "John Smith";           // String
bool isEmployed = true;               // Boolean
char grade = 'A';                     // Character
DateTime birthdate = new DateTime(1990, 5, 15); // DateTime

// Displaying the values of the variables
Console.WriteLine("Név: " + name);
Console.WriteLine("Kor: " + age);
Console.WriteLine("Fizetés: " + salary);
Console.WriteLine("Alkalmazott-e: " + isEmployed);
Console.WriteLine("Osztályzat (amerikai): " + grade);
Console.WriteLine("Születésnap: " + birthdate.ToShortDateString());

// Modifying variables
age = 31;
salary += 1000.75;
isEmployed = false;

// Displaying updated values
Console.WriteLine("\nFrissített kor: " + age);
Console.WriteLine("Frissített fizetés: " + salary);
Console.WriteLine("Munkavállalói státusz: " + (isEmployed ? "Alkalmazott" : "Munkanélküli"));

// Using of var keyword - Implicit type declaration
var integerNumber = 5;

Console.WriteLine($"\nA {nameof(integerNumber)} változó típusa: {integerNumber.GetType()}");