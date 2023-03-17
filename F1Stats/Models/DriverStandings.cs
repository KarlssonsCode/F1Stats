using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Stats.Models
{


    public class DriverStandings
    {
        public MrdataStandings MRData { get; set; }
    }

    public class MrdataStandings
    {
        public string xmlns { get; set; }
        public string series { get; set; }
        public string url { get; set; }
        public string limit { get; set; }
        public string offset { get; set; }
        public string total { get; set; }
        public Standingstable StandingsTable { get; set; }
    }

    public class Standingstable
    {
        public string season { get; set; }
        public Standingslist[] StandingsLists { get; set; }
    }

    public class Standingslist
    {
        public string season { get; set; }
        public string round { get; set; }
        public DriverStanding[] DriverStandings { get; set; }
    }

    public class DriverStanding
    {
        public string position { get; set; }
        public string positionText { get; set; }
        public string points { get; set; }
        public string wins { get; set; }
        public Driver Driver { get; set; }
        public Constructor[] Constructors { get; set; }
    }
    public class DriverStand
    {
        public string DriverName { get; set; }
        public string Nationality { get; set; }
        public string Points { get; set; }
        public string Position { get; set; }
        public string Wins { get; set; }
    }


}
