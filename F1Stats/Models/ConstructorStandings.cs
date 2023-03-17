using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Stats.Models
{


    public class ConstructorStandings
    {
        public MrdataConstructorsStandings MRData { get; set; }
    }

    public class MrdataConstructorsStandings
    {
        public string xmlns { get; set; }
        public string series { get; set; }
        public string url { get; set; }
        public string limit { get; set; }
        public string offset { get; set; }
        public string total { get; set; }
        public StandingsTableConstructors StandingsTable { get; set; }
    }

    public class StandingsTableConstructors
    {
        public string season { get; set; }
        public StandingsListConstructors[] StandingsLists{ get; set; }
    }

    public class StandingsListConstructors
    {
        public string season { get; set; }
        public string round { get; set; }
        public ConstructorStanding[] ConstructorStandings { get; set; }
    }

    public class ConstructorStanding
    {
        public string position { get; set; }
        public string positionText { get; set; }
        public string points { get; set; }
        public string wins { get; set; }
        public Constructor Constructor { get; set; }
    }

    public class ConstructorStand
    {
        public string ConstructorName { get; set; }
        public string Position { get; set; }
        public string Points { get; set; }
        public string Wins { get; set; }
        public string ConstructorId { get; set; }
    }


}
