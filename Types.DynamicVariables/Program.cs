// Creating a dynamic variable
dynamic dynamicVariable;

// Assigning different types of values to the dynamic variable
dynamicVariable = 10;        // An integer
Console.WriteLine(dynamicVariable);

dynamicVariable = "Hello";   // A string
Console.WriteLine(dynamicVariable);

dynamicVariable = true;      // A boolean
Console.WriteLine(dynamicVariable);

// Performing operations based on the dynamic type
dynamic x = 5;
dynamic y = 10;
dynamic sum = x + y; // Dynamic type allows this, but it's not type-safe.
Console.WriteLine("Sum: " + sum);

// Using dynamic to access properties and methods
dynamic person = new { Name = "John", Age = 30 };
Console.WriteLine("Név: " + person.Name);
Console.WriteLine("Kor: " + person.Age);

// Dynamic can represent different types
dynamic anything = 42;
Console.WriteLine("Az anything típusa: " + anything.GetType()); // System.Int32

anything = "Dynamic Type";
Console.WriteLine("Az anything típusa: " + anything.GetType()); // System.String