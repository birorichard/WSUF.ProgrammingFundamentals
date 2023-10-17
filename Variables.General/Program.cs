int localVariable = 20;

Console.WriteLine("Main Local Variable: " + localVariable);

if (true)
{
    // This is a local variable within the if block.
    int ifLocalVariable = 30;

    Console.WriteLine("\nInside If Block:");
    Console.WriteLine("Main Local Variable: " + localVariable); // Accessing the Main method's local variable
    Console.WriteLine("If Local Variable: " + ifLocalVariable);

    // You can also shadow variables with the same name.
    int globalVariable = 40; // Shadowing the global variable
    Console.WriteLine("\nInside If Block with Shadowing:");
    Console.WriteLine("Shadowed Global Variable: " + globalVariable); // Accessing the shadowed variable
}

// The ifLocalVariable is not accessible here; it's out of scope.
// Console.WriteLine("Outside If Block: " + ifLocalVariable); // Uncommenting this line would result in a compilation error.

Console.WriteLine("\nBack Inside Main:");
Console.WriteLine("Global Variable: " + globalVariable); // Accessing the global variable
Console.WriteLine("Main Local Variable: " + localVariable);