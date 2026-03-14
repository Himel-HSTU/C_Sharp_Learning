using BattleShipGameClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BattleShipGameClassLibrary
{
    public static class GameLogics
    {
        public static void InitializeGrid(PlayerInfoModel model)
        {
            List<string> letters = new List<string> { "A", "B", "C", "D", "E" };

            for (int i = 1; i <= 5; i++)
            {
                foreach (var letter in letters)
                {
                    AddGridSpot(model, letter, i);
                }
            }
        }

        private static void AddGridSpot(PlayerInfoModel model, string letter, int number)
        {
            GridSpotModel spot = new GridSpotModel
            {
                SpotLetter = letter,
                SpotNumber = number,
                Status = GridSpotStatus.Empty
            };

            model.ShotGrid.Add(spot);
        }

        public static bool ValidateShipLocation(string location, PlayerInfoModel model)
        {
            bool output = false;

            (string row, int column) = SplitRowAndColumn(location);

            bool isValidLocation = ValidateGridLocation(row, column);

            bool isSpotEmpty = CheckIfSpotEmpty(model, row, column);

            if (isValidLocation && isSpotEmpty)
            {
                model.ShipLocations.Add(new GridSpotModel
                {
                    SpotLetter = row,
                    SpotNumber = column,
                    Status = GridSpotStatus.Ship
                });

                output = true;
            }

            return output;
        }

        private static bool ValidateGridLocation(string row, int column)
        {
            List<string> validLetters = new List<string> { "A", "B", "C", "D", "E" };

            return validLetters.Contains(row.ToUpper()) && column >= 1 && column <= 5;
        }

        private static bool CheckIfSpotEmpty(PlayerInfoModel model, string row, int column)
        {
            foreach (var ship in model.ShipLocations)
            {
                if (ship.SpotLetter == row && ship.SpotNumber == column)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool PlayerStillActive(PlayerInfoModel player)
        {
            foreach (var ship in player.ShipLocations)
            {
                if (ship.Status != GridSpotStatus.Sunk)
                {
                    return true;
                }
            }

            return false;
        }

        public static int GetShotCount(PlayerInfoModel player)
        {
            int shotCount = 0;

            foreach (var shot in player.ShotGrid)
            {
                if (shot.Status != GridSpotStatus.Empty)
                {
                    shotCount++;
                }
            }

            return shotCount;
        }

        public static (string row, int column) SplitRowAndColumn(string shot)
        {
            if (shot.Length != 2)
                throw new ArgumentException("Invalid Shot");

            string row = shot[0].ToString().ToUpper();
            int column = int.Parse(shot[1].ToString());

            return (row, column);
        }

        public static bool ValidateShot(PlayerInfoModel player, string row, int column)
        {
            foreach (var gridSpot in player.ShotGrid)
            {
                if (gridSpot.SpotLetter == row && gridSpot.SpotNumber == column)
                {
                    return gridSpot.Status == GridSpotStatus.Empty;
                }
            }

            return false;
        }

        public static bool IdentifyShotResult(PlayerInfoModel opponent, string row, int column)
        {
            foreach (var ship in opponent.ShipLocations)
            {
                if (ship.SpotLetter == row && ship.SpotNumber == column)
                {
                    ship.Status = GridSpotStatus.Sunk;
                    return true;
                }
            }

            return false;
        }

        public static void MarkShotResults(PlayerInfoModel player, string row, int column, bool isAHit)
        {
            foreach (var gridSpot in player.ShotGrid)
            {
                if (gridSpot.SpotLetter == row && gridSpot.SpotNumber == column)
                {
                    gridSpot.Status = isAHit ? GridSpotStatus.Hit : GridSpotStatus.Miss;
                }
            }
        }
    }
}




/*using BattleShipGameClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BattleShipGameClassLibrary
{
    public static class GameLogics
    {
        public static void InitializeGrid(PlayerInfoModel model)
        {
            List<string> letters = new List<string> { "A", "B", "C", "D", "E" };
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            foreach (string letter in letters) {
                foreach (int number in numbers) {
                    AddGridSpot(model, letter, number);
                }
            }
        }
        private static void AddGridSpot(PlayerInfoModel model,string letter,int number)
        {
            GridSpotModel spot = new GridSpotModel();
            spot.SpotLetter = letter;
            spot.SpotNumber = number;
            spot.Status = GridSpotStatus.Empty;
            model.ShotGrid.Add(spot);
        }
        public static bool ValidateShipLocation(string location, PlayerInfoModel model)
        {
            bool output = false;
            (string row, int column) = SplitRowAndColumn(location);
            bool isValidLocation = ValidateGridLocation(model,row,column);
            bool isSpotEmpty = CheckIfSpotEmpty(model, row, column);
            if (isValidLocation && isSpotEmpty) {
                model.ShipLocations.Add(new GridSpotModel { SpotLetter = row.ToUpper(), SpotNumber = column, Status = GridSpotStatus.Ship });
                output = true;
            }
            return output;
        }

        private static bool CheckIfSpotEmpty(PlayerInfoModel model, string row, int column)
        {
            bool output = true;
            foreach (var ship in model.ShipLocations) {
                if (ship.SpotLetter == row.ToUpper() && ship.SpotNumber == column)
                {
                       output = false;
                }
            }
            return output;
        }

        private static bool ValidateGridLocation(PlayerInfoModel model, string row, int column)
        {
            bool output = false;

            List<string> validLetters = new List<string> { "A", "B", "C", "D", "E" };

            if (validLetters.Contains(row.ToUpper()) && column >= 1 && column <= 5)
            {
                output = true;
            }

            return output;
        }


        public static bool PlayerStillActive(PlayerInfoModel player)
        {
            bool isActive = false;
            foreach (var ship in player.ShipLocations ) {
                if (ship.Status != GridSpotStatus.Sunk)
                {
                    isActive = true; //break;
                }
            }
            return isActive;
        }

        public static int GetShotCount(PlayerInfoModel player)
        {
            int shotCount = 0;
            foreach (var shot in player.ShotGrid)
            {
                if (shot.Status!=GridSpotStatus.Empty)
                {
                    shotCount += 1;
                }
            }
            return shotCount;
        }

        public static (string row, int column) SplitRowAndColumn(string shot)
        {
            string row = "";
            int column = 0;
            if (shot.Length!=2)
            {
                throw new ArgumentException("This was an Invalid Shot Type");
            }
            char[] shotArray = shot.ToArray();
            row = shotArray[0].ToString().ToUpper();
            column = int.Parse(shotArray[1].ToString());
            return (row, column);
        }

        public static bool ValidateShot(PlayerInfoModel player, string row, int column)
        {
            bool output = false;
            foreach (var gridSpot in player.ShotGrid)
            {
                if (gridSpot.SpotLetter == row.ToUpper() && gridSpot.SpotNumber == column)
                {
                    if (gridSpot.Status==GridSpotStatus.Empty)
                    {
                         output = true;
                    }
                }
            }
            return output;
        }

        public static bool IdentifyShotResult(PlayerInfoModel opponent, string row, int column)
        {
            bool output = false;
            foreach (var ship in opponent.ShipLocations)
            {
                if (ship.SpotLetter == row.ToUpper() && ship.SpotNumber == column)
                {
                    output = true;
                }
            }
            return output;
        }

        public static void MarkShotResults(PlayerInfoModel player, string row, int column, bool isAHit)
        {
            bool output = true;
            foreach (var gridSpot in player.ShotGrid)
            {
                if (gridSpot.SpotLetter == row.ToUpper() && gridSpot.SpotNumber == column)
                {
                    if (output)
                    {
                        gridSpot.Status = GridSpotStatus.Hit;
                    }
                    else
                    {
                        gridSpot.Status = GridSpotStatus.Miss;
                    }
                }
            }
        }
    }
}
*/