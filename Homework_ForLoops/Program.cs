
// Ask user for a comma-separated list of first names.
// Split string into string array.
// Loop through array and print "Hello <name>" to the console.

//ask user for names
Console.Write("Enter list of comma-separated names: ");
string? data = Console.ReadLine();

//place each name into array
string[] names = data.Split(',');

//loop and display names
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"Hello {names[i]}");
}
