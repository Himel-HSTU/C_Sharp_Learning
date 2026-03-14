namespace BattleShipGameClassLibrary.Models
{
    public class GridSpotModel
    {
        public string SpotLetter { get; set; }

        public int SpotNumber { get; set; }

        public GridSpotStatus Status { get; set; } = GridSpotStatus.Empty;
    }
}








/*using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipGameClassLibrary.Models
{
    public class GridSpotModel
    {
        public string SpotLetter { get; set; }

        public int SpotNumber { get; set; }

        public GridSpotStatus Status { get; set; } = GridSpotStatus.Empty;
    }
}
*/
