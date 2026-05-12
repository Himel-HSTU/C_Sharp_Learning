// Today we will learn about Events in C#. Events are a way for a class to notify other classes or objects when something of interest occurs.
// They are based on the publisher-subscriber model, where one class (the publisher) raises an event, and other classes (the subscribers) handle that event. This allows for a decoupled design, where the publisher does not need to know about the subscribers, and vice versa.


CollegeClassModel history = new CollegeClassModel("History 320", 3);
CollegeClassModel math = new CollegeClassModel("Math 101", 1);

history.EnrolmentFull += Course_EnrolmentFull;
math.EnrolmentFull += Course_EnrolmentFull;
//history.EnrolmentFull += History_EnrolmentFull;
//math.EnrolmentFull += Math_EnrolmentFull;


history.SignUpStudent("Alice").PrintToConsole();
history.SignUpStudent("Bob").PrintToConsole(); 
history.SignUpStudent("Charlie").PrintToConsole(); // Event fire before the last full printing process
history.SignUpStudent("David").PrintToConsole(); // This student will be added to the waiting list
"".PrintToConsole();
math.SignUpStudent("Eve").PrintToConsole();
math.SignUpStudent("Frank").PrintToConsole(); // This student will be added to the waiting list
math.SignUpStudent("Grace").PrintToConsole(); // This student will be added to the waiting list

void Course_EnrolmentFull(object? sender, string e)
{
    CollegeClassModel model = sender as CollegeClassModel; // in this way we can assure that which class is calling the event
    $"{model.CourseTitle} is Calling Now!!!".PrintToConsole(); 
    "".PrintToConsole();
    e.PrintToConsole();
    "".PrintToConsole();
}
//void Math_EnrolmentFull(object? sender, string e)
//{
//    e.PrintToConsole();
//}
//void History_EnrolmentFull(object? sender, string e)
//{
//    e.PrintToConsole();
//} 

Console.ReadLine(); 

public static class ConsoleHelpers
{
    public static void PrintToConsole(this string message)
    {
        Console.WriteLine(message);
    }
}

public class CollegeClassModel
{
    public event EventHandler<string> EnrolmentFull;
    private List<string> enrolledStudents = new List<string>();
    private List<string> waitingStudents = new List<string>();
    public string CourseTitle { get; private set; }
    public int MaxStudents { get; private set; }

    public CollegeClassModel(string title,int maxStdnt)
    {
        CourseTitle = title;
        MaxStudents = maxStdnt;
    }
    public string SignUpStudent (string StudentName)
    {
        string output = "";
        if (enrolledStudents.Count < MaxStudents)   
        {
            enrolledStudents.Add(StudentName);
            output += $"{StudentName}, Enrolled successfully for {CourseTitle}";
            if (enrolledStudents.Count == MaxStudents)
            {
                EnrolmentFull?.Invoke(this, $"{CourseTitle} enrollment is now full.");
            }
        }
        else
        {
            
            waitingStudents.Add(StudentName);
            output += $"{StudentName}, Added to waiting list for {CourseTitle}";
        }
            return output;
    }
}

// ╔══════════════════════════════════════════════════════════════╗
// ║                        EVENTS                                ║
// ╚══════════════════════════════════════════════════════════════╝

// WHAT IS IT?
// A notification system between classes.
// Publisher fires the event → Subscribers react automatically.
// Publisher doesn't know who's listening — fully decoupled.

// ══════════════════════════════════════════════════════════════
// PART 1 — DECLARE (inside the publisher class)
// ══════════════════════════════════════════════════════════════
// public event EventHandler<T> EventName;
// T = the data type you want to pass to subscribers
// Example:
// public event EventHandler<string> EnrolmentFull;

// ══════════════════════════════════════════════════════════════
// PART 2 — INVOKE / FIRE (inside the publisher class)
// ══════════════════════════════════════════════════════════════
// EventName?.Invoke(this, data);
// this  = sender (who fired it)
// data  = the message/info passed to subscriber (e)
// ?.    = null check — if nobody subscribed, don't crash
// Example:
// EnrolmentFull?.Invoke(this, $"{CourseTitle} is now full.");

// ══════════════════════════════════════════════════════════════
// PART 3 — SUBSCRIBE / LISTEN (outside the publisher class)
// ══════════════════════════════════════════════════════════════
// obj.EventName += HandlerMethod;   // subscribe
// obj.EventName -= HandlerMethod;   // unsubscribe
// += means "add this method as a listener"
// multiple methods can subscribe to the same event
// Example:
// history.EnrolmentFull += Course_EnrolmentFull;

// ══════════════════════════════════════════════════════════════
// PART 4 — HANDLER METHOD (the subscriber's reaction)
// ══════════════════════════════════════════════════════════════
// void HandlerMethod(object? sender, T e)
// sender = WHO fired the event (cast it to get the object)
// e      = the data passed from Invoke
// Example:
// void Course_EnrolmentFull(object? sender, string e)
// {
//     CollageClassModel model = sender as CollageClassModel;
//     // model.CourseTitle tells you which class fired it
//     // e contains the message passed from Invoke
// }