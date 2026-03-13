using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipGameClassLibrary.Models
{
    public class PlayerInfoModel
    {
        public string Name { get; set; } 
        public List<GridSpotModel> ShipLocations { get; set; }

        public List<GridSpotModel> ShotGrid { get; set; }
    }
}
