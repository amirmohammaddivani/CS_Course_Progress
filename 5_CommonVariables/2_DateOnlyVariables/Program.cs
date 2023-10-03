


DateTime today = DateTime.Now;

// used only when we care only about the date
DateOnly birthday = DateOnly.ParseExact("6/11/1998", "d/MM/yyyy");
Console.WriteLine(birthday);

Console.WriteLine(birthday.ToString("MM dd, yyyy"));
Console.WriteLine(birthday.ToString("MMMM dd, yyyy"));

Console.WriteLine($"today full format: {today}");
Console.WriteLine($"today just date: {today.Date}");
Console.WriteLine($"Birthday full format: {birthday}");
// Non-existent field Date
//Console.WriteLine($"Birthday just date: {birthday}"); 
