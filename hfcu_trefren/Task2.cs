using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hfcu_trefren
{
    internal class TeamStats
    {
        public int Position;
        public string Club;
        public int GF;
        public int GA;
        public int Diff;

    }

    public class Task2
    {
        readonly List<TeamStats> _seasonStats = new List<TeamStats>
        {
            new TeamStats { Position = 1, Club = "Arsenal", GF = 33, GA = 11 },
            new TeamStats { Position = 2, Club = "Manchester City", GF = 40, GA = 14 },
            new TeamStats { Position = 3, Club = "Newcastle United", GF = 29, GA = 11 },
            new TeamStats { Position = 4, Club = "Tottenham Hotspur", GF = 31, GA = 21 },
            new TeamStats { Position = 5, Club = "Manchester United", GF = 20, GA = 20 },
            new TeamStats { Position = 6, Club = "Liverpool", GF = 28, GA = 17 },
            new TeamStats { Position = 7, Club = "Brighton & Hove Albion", GF = 23, GA = 19 },
            new TeamStats { Position = 8, Club = "Chelsea", GF = 17, GA = 17 },
            new TeamStats { Position = 9, Club = "Fulham", GF = 24, GA = 26 },
            new TeamStats { Position = 10, Club = "Brentford", GF = 23, GA = 25 },
            new TeamStats { Position = 11, Club = "Crystal Palace", GF = 15, GA = 18 },
            new TeamStats { Position = 12, Club = "Aston Villa", GF = 16, GA = 22 },
            new TeamStats { Position = 13, Club = "Leicester City", GF = 25, GA = 25 },
            new TeamStats { Position = 14, Club = "AFC Bournemouth", GF = 18, GA = 32 },
            new TeamStats { Position = 15, Club = "Leeds United", GF = 22, GA = 26 },
            new TeamStats { Position = 16, Club = "West Ham United", GF = 12, GA = 17 },
            new TeamStats { Position = 17, Club = "Everton", GF = 11, GA = 17 },
            new TeamStats { Position = 18, Club = "Nottingham Forest", GF = 11, GA = 30 },
            new TeamStats { Position = 19, Club = "Southampton", GF = 13, GA = 27 },
            new TeamStats { Position = 20, Club = "Wolverhampton Wanderers", GF = 8, GA = 24 },

        };

        public Task2() => CalcScoringDiffs();

        private void CalcScoringDiffs()
        {
            foreach (var s in _seasonStats) s.Diff = s.GF - s.GA;
        }

        public void Run()
        {

            int minDiff = _seasonStats.Min(x => Math.Abs(x.Diff));
            var minDiffTeamStats = _seasonStats.First(x => Math.Abs(x.Diff) == minDiff);
            Console.WriteLine($"Min goal difference: Position: {minDiffTeamStats.Position} Club: {minDiffTeamStats.Club} " +
                              $"GF: {minDiffTeamStats.GF} GA: {minDiffTeamStats.GA} Diff: {minDiffTeamStats.Diff}");


            int maxDiff = _seasonStats.Max(x => Math.Abs(x.Diff));
            var maxDiffTeamStats = _seasonStats.First(x => Math.Abs(x.Diff) == maxDiff);
            Console.WriteLine($"Max goal difference: Position: {maxDiffTeamStats.Position} Club: {maxDiffTeamStats.Club} " +
                              $"GF: {maxDiffTeamStats.GF} GA: {maxDiffTeamStats.GA} Diff: {maxDiffTeamStats.Diff}");

        }

    }
}
