// Implicit type conversion

using TypeConversion;

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

Console.WriteLine("\n");

string strNumber = "5";
int intNumber;

int.TryParse(strNumber, out intNumber);

Console.WriteLine(intNumber);

var employeeFromDB = new EmployeeFromDatabase
{
    Id = 52231,  // long tipusu
    Name = "Richard"
};


var employee = new Employee
{
    Id = (int)employeeFromDB.Id,  // int tipusu
    Name = employeeFromDB.Name,
};