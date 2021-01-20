using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the rank number (i.e. first place, second place, third place)
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the name of the place rank.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the set cash amount of the prize.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents a percentage of entire cash pot.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
