using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name of the selected Tournament.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the Entry fee to buy into the tournament.        
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents a list of Teams that are entered into the currently selected tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents a list of prizes from the PrizeModel library.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents a list of lists of rounds from the MatchUpModel Library.
        /// </summary>
        public List<List<MatchUpModel>> Rounds { get; set; } = new List<List<MatchUpModel>>();
    }
}
