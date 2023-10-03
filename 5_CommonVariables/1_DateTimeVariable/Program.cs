using System.Globalization;

DateTime today = DateTime.Now;
Console.WriteLine(today);

// just says the date
Console.WriteLine(today.ToString("d"));

// somebody's birthday
DateTime birthday = DateTime.Parse("16/08/1375");
Console.WriteLine(birthday);

// Being safe 
// Invariant culture tells the compiler to just listen to us
DateTime birthDay2 = DateTime.ParseExact
               ("16/08/1375",
            "dd/MM/yyyy",
           CultureInfo.CurrentCulture);

Console.WriteLine(birthDay2);

// Writing some time with WriteLine member
Console.WriteLine(today.ToString("dd MMM, yyyy HH:mm:ss tt zzz"));
