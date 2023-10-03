

// Represents only time portion
TimeOnly opensAt = TimeOnly.Parse("8:00 AM");
Console.WriteLine(opensAt);

// when we want to get from others (DateTime)
TimeOnly rightNow = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine(rightNow);

var currentDate = DateOnly.FromDateTime(DateTime.Now);