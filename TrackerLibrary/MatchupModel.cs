using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// List of teams in the matchup
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Indicates the winner of the matchup
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Shows match round.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
