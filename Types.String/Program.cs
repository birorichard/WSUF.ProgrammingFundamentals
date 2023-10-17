Console.WriteLine("Példák string-ekkel kapcsolatos műveletekre");

Console.WriteLine("Concatenating Strings - string típusú változók összefűzése");
string firstName = "John";
string lastName = "Doe";
string fullName = firstName + " " + lastName;
Console.WriteLine("Full Name: " + fullName);


Console.WriteLine("String Interpolation");
firstName = "John";
lastName = "Doe";
fullName = $"{firstName} {lastName}";
Console.WriteLine($"Full Name: {fullName}");


Console.WriteLine("Számok formázása String-ben");
int age = 30;
double salary = 50000.50;
Console.WriteLine($"Age: {age:D2}"); // Format as a two-digit number with leading zeros
Console.WriteLine($"Salary: {salary:C}"); // Format as currency


Console.WriteLine("String hossza");
string text = "Hello, World!";
int length = text.Length;
Console.WriteLine($"Length of the string: {length}");


Console.WriteLine("Substring");
text = "Hello, World!";
string subText = text.Substring(0, 5); // Get the first 5 characters
Console.WriteLine($"Substring: {subText}");


Console.WriteLine("String összehasonlítása");
string str1 = "apple";
string str2 = "APPLE";
bool areEqual = string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase);
Console.WriteLine($"Are equal (case-insensitive): {areEqual}");


Console.WriteLine("Szöveg kicserélése egy String-ben");
text = "The quick brown fox jumps over the lazy dog.";
string newText = text.Replace("fox", "cat");
Console.WriteLine($"New Text: {newText}");


Console.WriteLine("String elvágása több elemre");
string names = "Alice,Bob,Charlie";
string[] nameArray = names.Split(',');
foreach (string name in nameArray)
{
    Console.WriteLine($"Name: {name}");
}


Console.WriteLine("String Formatting");
double price = 29.99;
int quantity = 3;
string item = "Widget";
string formattedString = string.Format("Item: {0}, Quantity: {1}, Total Price: {2:C}", item, quantity, price * quantity);
Console.WriteLine(formattedString);


Console.WriteLine("String Padding");
string paddedString = "42".PadLeft(5, '0'); // Pad with zeros to make it 5 characters wide
Console.WriteLine($"Padded String: {paddedString}");