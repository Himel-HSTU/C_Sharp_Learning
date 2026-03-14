
using System.Collections.Generic;

namespace BattleShipGameClassLibrary.Models
{
    public class PlayerInfoModel
    {
        public string Name { get; set; }

        public List<GridSpotModel> ShipLocations { get; set; } = new List<GridSpotModel>();

        public List<GridSpotModel> ShotGrid { get; set; } = new List<GridSpotModel>();
    }
}



/* System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipGameClassLibrary.Models
{
    public class PlayerInfoModel
    {
        public string Name { get; set; } 
        public List<GridSpotModel> ShipLocations { get; set; } = new List<GridSpotModel>();

        public List<GridSpotModel> ShotGrid { get; set; } = new List<GridSpotModel>();
    }
}
*/
