// Today We will building a simple console application in C# that will work as BattleShip Game.
// We Will maintain proper DRY,Single Responsibility and Class Library for future use and scalability of the project.

//..............................................................................................................

using BattleShipGameClassLibrary;
using BattleShipGameClassLibrary.Models;

MainClass.Main();

Console.ReadLine();

public class MainClass
{
    public static void Main()
    {
        WelcomeMessage();

        PlayerInfoModel activeplayer = CreatePlayer("Player 1");
        PlayerInfoModel opponent = CreatePlayer("Player 2");

        PlayerInfoModel winner = null;

        do
        {
            DisplayShotGrid(activeplayer);

            RecordPlayerShot(activeplayer, opponent);

            bool doesGameContinue = GameLogics.PlayerStillActive(opponent);

            if (doesGameContinue)
            {
                PlayerInfoModel temp = opponent;
                opponent = activeplayer;
                activeplayer = temp;
            }
            else
            {
                winner = activeplayer;
            }

        } while (winner == null);

        IdentifyWinner(winner);
    }

    private static void IdentifyWinner(PlayerInfoModel winner)
    {
        Console.WriteLine($"Congratulation To Our Winner : {winner.Name}");
        Console.WriteLine($"{winner.Name} Took Total {GameLogics.GetShotCount(winner)} Shots");
    }

    private static void RecordPlayerShot(PlayerInfoModel activeplayer, PlayerInfoModel opponent)
    {
        bool isValidShot = false;
        string row = "";
        int column = 0;

        do
        {
            string shot = AskForShot();

            (row, column) = GameLogics.SplitRowAndColumn(shot);

            isValidShot = GameLogics.ValidateShot(activeplayer, row, column);

            if (!isValidShot)
            {
                Console.WriteLine("Invalid Shot Location! Please Choose Again!");
            }

        } while (!isValidShot);

        bool isAHit = GameLogics.IdentifyShotResult(opponent, row, column);

        GameLogics.MarkShotResults(activeplayer, row, column, isAHit);
    }

    private static string AskForShot()
    {
        Console.Write("Enter Shot Location (A1-E5): ");
        return Console.ReadLine();
    }

    private static void DisplayShotGrid(PlayerInfoModel activeplayer)
    {
        string currentRow = activeplayer.ShotGrid[0].SpotLetter;

        foreach (var gridSpot in activeplayer.ShotGrid)
        {
            if (gridSpot.SpotLetter != currentRow)
            {
                Console.WriteLine();
                currentRow = gridSpot.SpotLetter;
            }

            if (gridSpot.Status == GridSpotStatus.Empty)
                Console.Write($" {gridSpot.SpotLetter}{gridSpot.SpotNumber}");
            else if (gridSpot.Status == GridSpotStatus.Hit)
                Console.Write(" X ");
            else if (gridSpot.Status == GridSpotStatus.Miss)
                Console.Write(" O ");
        }

        Console.WriteLine();
    }

    private static void WelcomeMessage()
    {
        Console.WriteLine("Welcome To BattleShip Lite Game - By Himel Rahman");
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine();
    }

    private static PlayerInfoModel CreatePlayer(string PlayerTitle)
    {
        PlayerInfoModel output = new PlayerInfoModel();

        Console.WriteLine($"Player Setup For {PlayerTitle}");

        output.Name = AskUsersName();

        GameLogics.InitializeGrid(output);

        PlaceShips(output);

        Console.Clear();

        return output;
    }

    private static string AskUsersName()
    {
        Console.Write("Enter Your NickName: ");
        return Console.ReadLine();
    }

    private static void PlaceShips(PlayerInfoModel model)
    {
        do
        {
            Console.Write($"Place Ship #{model.ShipLocations.Count + 1} (A1-E5): ");

            string location = Console.ReadLine();

            bool isValidLocation = GameLogics.ValidateShipLocation(location, model);

            if (!isValidLocation)
            {
                Console.WriteLine("Invalid Location!");
            }

        } while (model.ShipLocations.Count < 5);
    }
}











/*
using BattleShipGameClassLibrary.Models;
using BattleShipGameClassLibrary;
MainClass.Main();








Console.ReadLine();
//...................................For Program Main Classes...............................................
public class MainClass{ 
    public static void Main() { 
        WelcomeMessage();
        PlayerInfoModel activeplayer = CreatePlayer("Player 1");
        PlayerInfoModel opponent = CreatePlayer("Player 2");
        PlayerInfoModel winner = null;
        do
        {
                                                        // Display Grid From Player 1,Where they fired
            DisplayShotGrid(activeplayer) ;
                                                        //ask Active where they want to fire
                                                        //determine if Active Player shot was valid
                                                        //Determine Shot result for player 1
            RecordPlayerShot(activeplayer,opponent) ;
                                                        //determine if game is over or not
            bool doesGameContinue = GameLogics.PlayerStillActive(opponent);
                                                        //if over , Active Player is winner
                                                        // if not over, go to opponent mean swap position    and repeat the same process
            if (doesGameContinue == true)
            {
                PlayerInfoModel temp = opponent;
                opponent = activeplayer;
                activeplayer = temp;
                // (activeplayer, opponent) = (opponent, activeplayer); // this is also a way to swap two variables in C#
            }
            else { 
                winner = activeplayer;
            }
        } while (winner == null);
        IdentifyWinner(winner);
    }

    private static void IdentifyWinner(PlayerInfoModel winner)
    {
        Console.WriteLine($"Congratulation To Our Winner : {winner.Name}");
        Console.WriteLine($"{winner.Name} Took Total {GameLogics.GetShotCount(winner)} Shots");
    }

    private static void RecordPlayerShot(PlayerInfoModel activeplayer, PlayerInfoModel opponent)
    {
        bool isValidShot = false;
        string row = "";
        int column = 0;
        do
        {
            string shot=AskForShot();
            ( row, column) = GameLogics.SplitRowAndColumn(shot);
            isValidShot = GameLogics.ValidateShot(activeplayer, row, column);
            if (isValidShot==false)
            {
                Console.WriteLine("Ivalid Shot Location!Please Choose a Valid Location Again!!!");
            }
        }
        while (isValidShot==false);
        //Ask for a shot location Like A1/B2/C3
        // Have to manually determine row and column from the user input
        // determine if the shot is valid or not
        // if valid determine if its a hit or miss
        // go back to begining if not valid
        bool isAHit = GameLogics.IdentifyShotResult(opponent, row, column);
        //determine shot resuly
        //record rsult
        GameLogics.MarkShotResults(activeplayer, row, column, isAHit);
    }

    private static string AskForShot()
    {
        Console.Write("Please Enter Your Shot Location (eg. A1/B2/C3) : ");
        string output = Console.ReadLine();
        return output;
    }

    private static void DisplayShotGrid(PlayerInfoModel activeplayer)
    { 
        string currentRow = activeplayer.ShotGrid[0].SpotLetter;
        foreach (var gridSpot in activeplayer.ShotGrid)
        {
            if (gridSpot.SpotLetter != currentRow)
            {
                Console.WriteLine();
                currentRow = gridSpot.SpotLetter;
            }
            if (gridSpot.Status == GridSpotStatus.Empty)
            {
                Console.Write($" {gridSpot.SpotLetter}{gridSpot.SpotNumber}");
            }
            else if (gridSpot.Status == GridSpotStatus.Hit)
            {
                Console.Write(" X ");
            }
            else if (gridSpot.Status== GridSpotStatus.Miss)
            {
                Console.Write(" O ");
            }
            else
            {
                Console.Write(" ? ");
            }
        }
    }
    private static void WelcomeMessage(){
        Console.WriteLine("Welcome To Our BattleShip Lite Game - By Himel Rahman");
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine();

    }
    private static PlayerInfoModel CreatePlayer(string PlayerTitle) 
    {  
        PlayerInfoModel output = new PlayerInfoModel();
         
        Console.WriteLine($"Player Information For {PlayerTitle}!");

        //Ask user for name
        output.Name =AskUsersName(); 
        //Load up the shot grid
        GameLogics.InitializeGrid(output);
        //ask user for ship placement
        PlaceShips(output);
        //clear the console
        Console.Clear();
        return output;
    }
    private static string AskUsersName() {
        Console.Write("Please Write Your NickName: ");
        string output = Console.ReadLine();
        return output;
    }
    private static void PlaceShips(PlayerInfoModel model) {
        do
        {
            Console.Write($"Please Place Your Ship Number - { model.ShipLocations.Count + 1 } (eg. A1/D3/E5) : ");
            String location = Console.ReadLine();
            bool isValidLocation = GameLogics.ValidateShipLocation(location, model);
            if (isValidLocation)
            {
                Console.WriteLine("That Was Not a Valid Location :( ");
                
            }
        }
        while (model.ShipLocations.Count<5);

    }
}
*/
