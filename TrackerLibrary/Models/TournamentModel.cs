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
        /// The Id number of Tournament.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Specific name of the tournament.
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Cost to participate in the tournament.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Teams participating in the tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// List of prizes that can be won.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// List of Matchups.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
