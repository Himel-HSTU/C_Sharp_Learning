// Today We will building a simple console application in C# that will work as BattleShip Game.
// We Will maintain proper DRY,Single Responsibility and Class Library for future use and scalability of the project.

//..............................................................................................................

using BattleShipGameClassLibrary.Models;
using BattleShipGameClassLibrary;
MainClass.Main();








Console.ReadLine();
//...................................For Program Main Classes...............................................
public class MainClass{
    public static void Main() { 
        WelcomeMessage();
    }
    private static void WelcomeMessage(){
        Console.WriteLine("Welcome To Our BattleShip Lite Game - By Himel Rahman");
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine();

    }
    private static PlayerInfoModel CreatePlayer() 
    { 
        PlayerInfoModel output = new PlayerInfoModel();
        //Ask user for name
        output.Name =AskUsersName(); 
        //Load up the shot grid
        output.ShotGrid 
        //ask user for ship placement
        //clear the console
    }
    private static string AskUsersName() {
        Console.WriteLine("Please Write Your NickName: ");
        string output = Console.ReadLine();
        return output;
    }
}
