/*
HOMEWORK
Capture a user's age from the console and then
identify how old they will be in 25 years,
as well as how old they were 25 years ago.
Print that information to the console
 */

// with possible null value
Console.Write($"Please enter your age: ");
int age = int.Parse( Console.ReadLine() );
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Age in 25 years: {age+25}");
Console.WriteLine($"Age 25 years ago: {age-25}");

// without possible null value
Console.Write($"Please enter your age: ");
int.TryParse(Console.ReadLine(), out int age2);
Console.WriteLine($"Age: {age2}");
Console.WriteLine($"Age in 25 years: {age2 + 25}");
Console.WriteLine($"Age 25 years ago: {age2 - 25}");


