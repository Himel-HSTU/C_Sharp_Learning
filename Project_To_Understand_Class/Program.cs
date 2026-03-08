// This is a simple project to understand the basics of C# classes and objects.
// Here we will use multiple class methods also try to follow SOLID and DRY Principles.

//Lets Understand Our Requirements:
// There will be an admin,who will give total number of user ,then each user will have number of operation,
// then we will perform those operations and print the result on console,before another user the console will be cleared
// then comes next user his operation and so on..

using Project;
start:
ProvideData.TopMsg();
(string adminName, int TotalUser) info = ProvideData.adminMsg();
//Console.WriteLine($"Admin Name is {info.adminName} {info.TotalUser}.");
Console.Clear();
int count = 1;
while (info.TotalUser>0)
{
    ProvideData.TopMsg();
    (string UName,int Uoperation) userInfo = reqData.userData(count);
    //Console.WriteLine($" {userInfo.UName} {userInfo.Uoperation}.");
    while (userInfo.Uoperation > 0)
    {
        (char operation, double num1, double num2) userCalcInfo = reqData.UserCalcData(userInfo.UName);
        double result = Calculations.calcChker(userCalcInfo.operation, userCalcInfo.num1, userCalcInfo.num2);
        ProvideData.finalOutput(userInfo.UName, userCalcInfo.operation, userCalcInfo.num1, userCalcInfo.num2, result);
        userInfo.Uoperation--;
    }
    ProvideData.EndMsg();
    Console.WriteLine("Press Any Key To Clean The Screen And Started as New User !!!");
    Console.ReadLine();
    Console.Clear();
    count++;
    info.TotalUser--; 
}

char close = ProvideData.adminEndMsg(info.adminName);
if (close == 'N' || close == 'n')
    goto start;


// Finally, There is many bugs and exceptions in this code, I know where and how to fix them 
// For example using goto statement is not a good practice but I just wanna try it :@
// I just want to understand the class and use as much as possible also Follow DRY and SOliD Principles,
// I really feel like I did a great Job !!! As I m Just Beginner in C# and Class,Methods Concepts..