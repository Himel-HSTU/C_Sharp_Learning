// ============================================================
// 📅 Date & Time in C#
// Today we learn how to work with DateTime, DateOnly, TimeOnly
// ============================================================



// ======================= DateTime ===========================
// DateTime represents BOTH date and time

DateTime date_time = DateTime.Now;     // Current local date & time
Console.WriteLine(date_time);           // Default output (culture dependent)
// Example: M/dd/yyyy hh:mm:ss AM/PM


// ---------- Custom DateTime Formatting ----------
// We can control how date & time are displayed using format strings

Console.WriteLine(
    date_time.ToString("yyyy-MM-dd HH:mm:ss tt")
);
// Example output: 2024-06-15 14:30:45 PM


// Common DateTime format specifiers:
// yyyy → 4-digit year
// yy   → 2-digit year
// MM   → month with leading zero
// M    → month without leading zero
// dd   → day with leading zero
// d    → day without leading zero
// HH   → 24-hour format (00–23)
// H    → 24-hour format (no leading zero)
// hh   → 12-hour format (01–12)
// h    → 12-hour format (no leading zero)
// mm   → minutes
// ss   → seconds
// tt   → AM / PM


// ---------- Advanced formatted string ----------
// Text inside single quotes is printed as-is

Console.WriteLine(
    date_time.ToString("tt 'of' d MMMM, yy 'about' h:m zzz")
);
// Example output: PM of 15 June, 24 about 2:30 +06:00



// ⚠ IMPORTANT NOTE ABOUT DateTime.Now
// DateTime.Now uses the user's LOCAL time zone
// In global applications, this can cause confusion because:
// - Different users have different time zones
// - Date formats vary by region (dd/MM vs MM/dd)
//
// ✅ Best practice:
// Store date & time in UTC, convert to local time when displaying



// ---------- UTC DateTime (Recommended for backend) ----------

DateTime utc_date_time = DateTime.UtcNow;
Console.WriteLine(utc_date_time);   // Current UTC date & time



// ---------- Creating a specific DateTime ----------
// Useful for fixed events, testing, deadlines, schedules

DateTime specific = new DateTime(
    2026,   // year
    01,     // month
    05,     // day
    2,      // hour (24-hour format)
    30,     // minute
    2       // second
);

Console.WriteLine(
    specific.ToString("hh:mm:ss 'of' yy, MMMM dd")
);
// Example: 02:30:02 of 26, January 05



// ======================= DateOnly ============================
// DateOnly represents ONLY a date (NO time)
// Introduced in .NET 6+

// Used for:
// - Birthdays
// - Anniversaries
// - Holidays
// - Exam dates

DateOnly date_only = DateOnly.FromDateTime(DateTime.UtcNow);
Console.WriteLine(date_only);       // Output: yyyy-MM-dd

// DateOnly does NOT have time
// Console.WriteLine(date_only.ToString("yyyy-MM-dd hh:mm:ss")); ❌ Invalid

DateOnly birthday = new DateOnly(2002, 5, 10);
Console.WriteLine(birthday);



// ======================= TimeOnly ============================
// TimeOnly represents ONLY time (NO date)
// Introduced in .NET 6+

// Used for:
// - Meeting times
// - Opening hours
// - Class schedules

TimeOnly time_only = TimeOnly.FromDateTime(DateTime.UtcNow);
Console.WriteLine(time_only);        // Output: HH:mm:ss.fffffff

TimeOnly meeting_time = new TimeOnly(
    14,     // hour
    30,     // minute
    0       // second
);
Console.WriteLine(meeting_time);





/*// Today we will learn about Date and Time in C#.
// first we will see how to work with DateTime struct.
//................. DateTime ..................

DateTime date_time = DateTime.Now; // current date and time
Console.WriteLine(date_time); // output: m/dd/yyyy hh:mm:ss AM/PM style
                              //we can also specify the exect format of date and time output
Console.WriteLine(date_time.ToString("yyyy-MM-dd HH:mm:ss tt")); // output: 2024-06-15 14:30:45 AM style
                                                                 // various format specifiers can be used to customize the output
                                                                 // some common format specifiers:
                                                                 // yyyy - 4 digit year
                                                                 // MM   - 2 digit month
                                                                 // dd   - 2 digit day
                                                                 // HH   - 2 digit hour (24-hour clock)
                                                                 // mm   - 2 digit minute
                                                                 // ss   - 2 digit second
                                                                 // hh   - 2 digit hour (12-hour clock)
                                                                 // tt   - AM/PM designator
                                                                 //yy   - 2 digit year
                                                                 // M    - month without leading zero
                                                                 // d    - day without leading zero
                                                                 // H    - hour without leading zero (24-hour clock)
                                                                 // h    - hour without leading zero (12-hour clock)
                                                                 //Heres a basic information we must remember that the variable date_time holds all the information about current date and time
                                                                 // we can access individual components like year, month, day, hour, minute, second using properties as per our need
Console.WriteLine( date_time.ToString("tt 'of' d MMMM, yy 'about' h:m zzz")); // output: PM of 15 June, 24 about 2:30 +00:00 style
//there has some serious issues,lets discuss: in the above section we are accesing current date and time using DateTime.Now of the user device 
//assume we are working with a global application where users are from different time zones
// if we store date and time in local format then it will create confusion while displaying the date and time to users from different time zones
// as local time will vary from time zone to time zone
// also the syntax of showing date and time may vary from region to region
// for example in asia we use dd/mm/yyyy format but in us its mm/dd/yyyy format
// to avoid this confusion we use UTC (Coordinated Universal Time) format for storing date and time in global applications
DateTime utc_date_time = DateTime.UtcNow; // current date and time in UTC format
Console.WriteLine(utc_date_time);// output: m/dd/yyyy hh:mm:ss AM/PM style in UTC format

//we can use our specific date and time using DateTime struct constructor
DateTime specific = new DateTime(2026, 01, 05, 2, 30, 2); // year, month, day, hour, minute, second
Console.WriteLine(specific.ToString("hh:mm:ss 'of' yy,MMMM dd")); // output: 02:30:02 of 26,January 05 style

//................. DateOnly ..................
// DateOnly struct is used to represent only date without time component
// introduced in .NET 6 and later versions
// there are many scenarios where we only need to work with date without time
// for example storing birth dates, anniversaries, holidays etc.
DateOnly date_only = DateOnly.FromDateTime(DateTime.UtcNow);// get current date in UTC format without time component
Console.WriteLine(date_only); // output: yyyy-MM-dd style
//Console.WriteLine(date_only.ToString("yyyy-MM-dd hh:mm:ss")); // output: yyyy-MM-dd time error as DateOnly does not have time component
DateOnly birthday = new DateOnly(2002, 5, 10);
Console.WriteLine(birthday);

//................. TimeOnly ..................
// TimeOnly struct is used to represent only time without date component
// introduced in .NET 6 and later versions
// there are many scenarios where we only need to work with time without date
// for example storing opening hours, meeting times, alarm times etc.
TimeOnly time_only = TimeOnly.FromDateTime(DateTime.UtcNow); // get current time in UTC format without date component
Console.WriteLine(time_only); // output: HH:mm:ss.fffffff style
TimeOnly meeting_time = new TimeOnly(14, 30, 0); // hour, minute, second
Console.WriteLine(meeting_time);
*/