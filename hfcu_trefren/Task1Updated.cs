using System;
using System.Collections.Generic;
using System.Linq;

namespace hfcu_trefren
{
    internal class ReadingUpdated : IBaseValues
    {
        public string Day;
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        public int Diff { get; set; }
    }

    class Task1Updated
    {
        private readonly List<ReadingUpdated> _readings = new List<ReadingUpdated>
        {
            new ReadingUpdated { Day = "6/1/2022", Value1 = 101, Value2 = 67 },
            new ReadingUpdated { Day = "6/2/2022", Value1 = 102, Value2 = 67 },
            new ReadingUpdated { Day = "6/3/2022", Value1 = 101, Value2 = 68 },
            new ReadingUpdated { Day = "6/4/2022", Value1 = 99, Value2 = 74 },
            new ReadingUpdated { Day = "6/5/2022", Value1 = 100, Value2 = 66 },
            new ReadingUpdated { Day = "6/6/2022", Value1 = 102, Value2 = 70 },
            new ReadingUpdated { Day = "6/7/2022", Value1 = 105, Value2 = 74 },
            new ReadingUpdated { Day = "6/8/2022", Value1 = 107, Value2 = 78 },
            new ReadingUpdated { Day = "6/9/2022", Value1 = 106, Value2 = 84 },
            new ReadingUpdated { Day = "6/10/2022", Value1 = 109, Value2 = 78 },
            new ReadingUpdated { Day = "6/11/2022", Value1 = 109, Value2 = 80 },
            new ReadingUpdated { Day = "6/12/2022", Value1 = 108, Value2 = 81 },
            new ReadingUpdated { Day = "6/13/2022", Value1 = 106, Value2 = 80 },
            new ReadingUpdated { Day = "6/14/2022", Value1 = 103, Value2 = 77 },
            new ReadingUpdated { Day = "6/15/2022", Value1 = 105, Value2 = 71 },
            new ReadingUpdated { Day = "6/16/2022", Value1 = 111, Value2 = 72 },
            new ReadingUpdated { Day = "6/17/2022", Value1 = 97, Value2 = 85 },
            new ReadingUpdated { Day = "6/18/2022", Value1 = 96, Value2 = 79 },
            new ReadingUpdated { Day = "6/19/2022", Value1 = 100, Value2 = 76 },
            new ReadingUpdated { Day = "6/20/2022", Value1 = 101, Value2 = 74 },
            new ReadingUpdated { Day = "6/21/2022", Value1 = 101, Value2 = 75 },
            new ReadingUpdated { Day = "6/22/2022", Value1 = 102, Value2 = 76 },
            new ReadingUpdated { Day = "6/23/2022", Value1 = 103, Value2 = 80 },
            new ReadingUpdated { Day = "6/24/2022", Value1 = 102, Value2 = 75 },
            new ReadingUpdated { Day = "6/25/2022", Value1 = 101, Value2 = 79 },
            new ReadingUpdated { Day = "6/26/2022", Value1 = 96, Value2 = 81 },
            new ReadingUpdated { Day = "6/27/2022", Value1 = 96, Value2 = 71 },
            new ReadingUpdated { Day = "6/28/2022", Value1 = 101, Value2 = 80 },
            new ReadingUpdated { Day = "6/29/2022", Value1 = 99, Value2 = 80 },
            new ReadingUpdated { Day = "6/30/2022", Value1 = 101, Value2 = 78 },
            new ReadingUpdated { Day = "7/1/2022", Value1 = 97, Value2 = 75 },
            new ReadingUpdated { Day = "7/2/2022", Value1 = 101, Value2 = 75 },
            new ReadingUpdated { Day = "7/3/2022", Value1 = 101, Value2 = 81 },
            new ReadingUpdated { Day = "7/4/2022", Value1 = 97, Value2 = 79 },
            new ReadingUpdated { Day = "7/5/2022", Value1 = 101, Value2 = 79 },
            new ReadingUpdated { Day = "7/6/2022", Value1 = 102, Value2 = 74 },
            new ReadingUpdated { Day = "7/7/2022", Value1 = 104, Value2 = 73 },
            new ReadingUpdated { Day = "7/8/2022", Value1 = 107, Value2 = 77 },
            new ReadingUpdated { Day = "7/9/2022", Value1 = 108, Value2 = 82 },
            new ReadingUpdated { Day = "7/10/2022", Value1 = 108, Value2 = 81 },
            new ReadingUpdated { Day = "7/11/2022", Value1 = 110, Value2 = 81 },
            new ReadingUpdated { Day = "7/12/2022", Value1 = 106, Value2 = 88 },
            new ReadingUpdated { Day = "7/13/2022", Value1 = 108, Value2 = 80 },
            new ReadingUpdated { Day = "7/14/2022", Value1 = 106, Value2 = 81 },
            new ReadingUpdated { Day = "7/15/2022", Value1 = 108, Value2 = 80 },
            new ReadingUpdated { Day = "7/16/2022", Value1 = 108, Value2 = 78 },
            new ReadingUpdated { Day = "7/17/2022", Value1 = 106, Value2 = 78 },
            new ReadingUpdated { Day = "7/18/2022", Value1 = 105, Value2 = 80 },
            new ReadingUpdated { Day = "7/19/2022", Value1 = 107, Value2 = 83 },
            new ReadingUpdated { Day = "7/20/2022", Value1 = 104, Value2 = 81 },
            new ReadingUpdated { Day = "7/21/2022", Value1 = 106, Value2 = 80 },
            new ReadingUpdated { Day = "7/22/2022", Value1 = 107, Value2 = 87 },
            new ReadingUpdated { Day = "7/23/2022", Value1 = 104, Value2 = 80 },
            new ReadingUpdated { Day = "7/24/2022", Value1 = 94, Value2 = 74 },
            new ReadingUpdated { Day = "7/25/2022", Value1 = 95, Value2 = 74 },
            new ReadingUpdated { Day = "7/26/2022", Value1 = 93, Value2 = 74 },
            new ReadingUpdated { Day = "7/27/2022", Value1 = 94, Value2 = 74 },
            new ReadingUpdated { Day = "7/28/2022", Value1 = 87, Value2 = 75 },
            new ReadingUpdated { Day = "7/29/2022", Value1 = 96, Value2 = 71 },
            new ReadingUpdated { Day = "7/30/2022", Value1 = 96, Value2 = 74 },
            new ReadingUpdated { Day = "7/31/2022", Value1 = 98, Value2 = 70 },
            new ReadingUpdated { Day = "8/1/2022", Value1 = 99, Value2 = 71 },
            new ReadingUpdated { Day = "8/2/2022", Value1 = 99, Value2 = 76 },
            new ReadingUpdated { Day = "8/3/2022", Value1 = 98, Value2 = 74 },
            new ReadingUpdated { Day = "8/4/2022", Value1 = 95, Value2 = 72 },
            new ReadingUpdated { Day = "8/5/2022", Value1 = 99, Value2 = 76 },
            new ReadingUpdated { Day = "8/6/2022", Value1 = 104, Value2 = 78 },
            new ReadingUpdated { Day = "8/7/2022", Value1 = 101, Value2 = 74 },
            new ReadingUpdated { Day = "8/8/2022", Value1 = 99, Value2 = 72 },
            new ReadingUpdated { Day = "8/9/2022", Value1 = 98, Value2 = 75 },
            new ReadingUpdated { Day = "8/10/2022", Value1 = 99, Value2 = 73 },
            new ReadingUpdated { Day = "8/11/2022", Value1 = 97, Value2 = 75 },
            new ReadingUpdated { Day = "8/12/2022", Value1 = 95, Value2 = 77 },
            new ReadingUpdated { Day = "8/13/2022", Value1 = 99, Value2 = 73 },
            new ReadingUpdated { Day = "8/14/2022", Value1 = 99, Value2 = 74 },
            new ReadingUpdated { Day = "8/15/2022", Value1 = 100, Value2 = 77 },
            new ReadingUpdated { Day = "8/16/2022", Value1 = 102, Value2 = 76 },
            new ReadingUpdated { Day = "8/17/2022", Value1 = 101, Value2 = 74 },
            new ReadingUpdated { Day = "8/18/2022", Value1 = 95, Value2 = 73 },
            new ReadingUpdated { Day = "8/19/2022", Value1 = 85, Value2 = 75 },
            new ReadingUpdated { Day = "8/20/2022", Value1 = 82, Value2 = 74 },
            new ReadingUpdated { Day = "8/21/2022", Value1 = 91, Value2 = 72 },
            new ReadingUpdated { Day = "8/22/2022", Value1 = 95, Value2 = 74 },
            new ReadingUpdated { Day = "8/23/2022", Value1 = 100, Value2 = 70 },
            new ReadingUpdated { Day = "8/24/2022", Value1 = 93, Value2 = 72 },
            new ReadingUpdated { Day = "8/25/2022", Value1 = 97, Value2 = 75 },
            new ReadingUpdated { Day = "8/26/2022", Value1 = 98, Value2 = 75 },
            new ReadingUpdated { Day = "8/27/2022", Value1 = 98, Value2 = 75 },
            new ReadingUpdated { Day = "8/28/2022", Value1 = 96, Value2 = 76 },
            new ReadingUpdated { Day = "8/29/2022", Value1 = 99, Value2 = 74 },
            new ReadingUpdated { Day = "8/30/2022", Value1 = 104, Value2 = 75 },
            new ReadingUpdated { Day = "8/31/2022", Value1 = 97, Value2 = 78 }
        };

        public Task1Updated() => Helper.CalcDiffs<ReadingUpdated>(_readings);

        public void Run()
        {

            int maxChange = _readings.Max(x => x.Diff);
            var maxChangeReading = _readings.First(x => x.Diff == maxChange);
            Console.WriteLine($"Biggest temperature change Date: {maxChangeReading.Day}, High: {maxChangeReading.Value1}, " +
                              $"Low: {maxChangeReading.Value2}, Change: {maxChangeReading.Diff}");

            decimal minChange = _readings.Min(x => x.Diff);
            var minChangeReading = _readings.First(x => x.Diff == minChange);
            Console.WriteLine($"Smallest temperature change Date: {minChangeReading.Day}, High: {minChangeReading.Value1}, " +
                              $"Low: {minChangeReading.Value2}, Change: {minChangeReading.Diff}");

        }

    }
}
