using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }
        public List<TeamModel> EnteredTeams { get; set; }
        public List<PrizeModel> Prizes { get; set; }
        public List<List<MatchupModel>> Rounds { get; set; }

        public TournamentModel()
        {
            this.EnteredTeams = new List<TeamModel>();
            this.Prizes = new List<PrizeModel>();
            this.Rounds = new List<List<MatchupModel>>();
        }
    }

    
}
