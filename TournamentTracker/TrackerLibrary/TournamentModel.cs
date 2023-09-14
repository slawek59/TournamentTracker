using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents tournaments name.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents an entry fee.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents teams as a list of TeamModels.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents prizes as a list of PrizeModels.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();  

        /// <summary>
        /// Represents rounds as a list of lists of MatchupModels.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>(); 

    }
}
