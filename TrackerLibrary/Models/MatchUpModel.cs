using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchUpModel
    {
        /// <summary>
        /// Represents a list of entries in the matchup list.
        /// </summary>
        public List<MatchUpEntryModel> Entries { get; set; } = new List<MatchUpEntryModel>();

        /// <summary>
        /// Represents the winner of the round.
        /// </summary>
        public TeamModel Winnner { get; set; }

        /// <summary>
        /// Represents a matchup during the round.
        /// </summary>
        public int MacthUpRound { get; set; }
    }
}
