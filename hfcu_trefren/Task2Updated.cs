using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hfcu_trefren
{
    internal class TeamStatsUpdated : IBaseValues
    {
        public int Position;
        public string Club;
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        public int Diff { get; set; }

    }

    class Task2Updated
    {
        readonly List<TeamStatsUpdated> _seasonStats = new List<TeamStatsUpdated>()
        {
            new TeamStatsUpdated { Position = 1, Club = "Arsenal", Value1 = 33, Value2 = 11 },
            new TeamStatsUpdated { Position = 2, Club = "Manchester City", Value1 = 40, Value2 = 14 },
            new TeamStatsUpdated { Position = 3, Club = "Newcastle United", Value1 = 29, Value2 = 11 },
            new TeamStatsUpdated { Position = 4, Club = "Tottenham Hotspur", Value1 = 31, Value2 = 21 },
            new TeamStatsUpdated { Position = 5, Club = "Manchester United", Value1 = 20, Value2 = 20 },
            new TeamStatsUpdated { Position = 6, Club = "Liverpool", Value1 = 28, Value2 = 17 },
            new TeamStatsUpdated { Position = 7, Club = "Brighton & Hove Albion", Value1 = 23, Value2 = 19 },
            new TeamStatsUpdated { Position = 8, Club = "Chelsea", Value1 = 17, Value2 = 17 },
            new TeamStatsUpdated { Position = 9, Club = "Fulham", Value1 = 24, Value2 = 26 },
            new TeamStatsUpdated { Position = 10, Club = "Brentford", Value1 = 23, Value2 = 25 },
            new TeamStatsUpdated { Position = 11, Club = "Crystal Palace", Value1 = 15, Value2 = 18 },
            new TeamStatsUpdated { Position = 12, Club = "Aston Villa", Value1 = 16, Value2 = 22 },
            new TeamStatsUpdated { Position = 13, Club = "Leicester City", Value1 = 25, Value2 = 25 },
            new TeamStatsUpdated { Position = 14, Club = "AFC Bournemouth", Value1 = 18, Value2 = 32 },
            new TeamStatsUpdated { Position = 15, Club = "Leeds United", Value1 = 22, Value2 = 26 },
            new TeamStatsUpdated { Position = 16, Club = "West Ham United", Value1 = 12, Value2 = 17 },
            new TeamStatsUpdated { Position = 17, Club = "Everton", Value1 = 11, Value2 = 17 },
            new TeamStatsUpdated { Position = 18, Club = "Nottingham Forest", Value1 = 11, Value2 = 30 },
            new TeamStatsUpdated { Position = 19, Club = "Southampton", Value1 = 13, Value2 = 27 },
            new TeamStatsUpdated { Position = 20, Club = "Wolverhampton Wanderers", Value1 = 8, Value2 = 24 },

        };

        public Task2Updated() => Helper.CalcDiffs<TeamStatsUpdated>(_seasonStats);

        public void Run()
        {

            int minDiff = _seasonStats.Min(x => Math.Abs(x.Diff));
            var minDiffTeamStats = _seasonStats.First(x => Math.Abs(x.Diff) == minDiff);
            Console.WriteLine($"Min goal difference: Position: {minDiffTeamStats.Position} Club: {minDiffTeamStats.Club} " +
                              $"GF: {minDiffTeamStats.Value1} GA: {minDiffTeamStats.Value2} Diff: {minDiffTeamStats.Diff}");


            int maxDiff = _seasonStats.Max(x => Math.Abs(x.Diff));
            var maxDiffTeamStats = _seasonStats.First(x => Math.Abs(x.Diff) == maxDiff);
            Console.WriteLine($"Max goal difference: Position: {maxDiffTeamStats.Position} Club: {maxDiffTeamStats.Club} " +
                              $"GF: {maxDiffTeamStats.Value1} GA: {maxDiffTeamStats.Value2} Diff: {maxDiffTeamStats.Diff}");

        }

    }
}
