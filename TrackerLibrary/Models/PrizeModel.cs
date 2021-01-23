using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }
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

        //created an empty constructor for use in other classes
        public PrizeModel()
        {

        }

        //created an overloaded constructor to try parse the strings to the correct data type
        public PrizeModel(string placeNumber, string placeName, string prizeAmount, string prizePercentage)
        {
            //taking the placeName parameter and putting it into the PlaceName property of the Model
            PlaceName = placeName;

            //parsing placeNumber to an int, and don't really care about the pass of fail value (0,1), just do it
            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            //put the parsed value into the PlaceNumber property of the Model
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;

        }
    }
}
