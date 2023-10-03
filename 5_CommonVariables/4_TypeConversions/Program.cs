

Console.WriteLine("What is your age?");

string? ageText =Console.ReadLine();

// converting string to int 
// I know 2 ways... let me think ...

// way 1:
int age = int.Parse(ageText);
Console.WriteLine(age);
Console.WriteLine("converting again...");

// way 2:
age = Convert.ToInt32(ageText);
Console.WriteLine("converting done...");
Console.WriteLine(age);

/* Again */
Console.Write($"Enter your age: ");
string? userAgeText = Console.ReadLine();

// for people who have trust issues
int userAge = default;
int.TryParse(userAgeText, out userAge);
Console.WriteLine($"User age is {userAge}.");

// casting 
double testDouble = userAge;
decimal decimalValue = (decimal)testDouble;
Console.WriteLine("Decimal value is : " + decimalValue);

// experiments
/* Can I "cast" a number to a string? */
int someInt = 100;
//string someString = (string) someInt; // failed
string someString = someInt.ToString();

Console.WriteLine($"This is a string: {someString} and it's type is {someString.GetType()}");

