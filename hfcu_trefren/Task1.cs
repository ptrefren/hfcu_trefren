using System;
using System.Collections.Generic;
using System.Linq;

namespace hfcu_trefren
{
    internal class Reading
    {
        public string Day;
        public int High { get; set; }
        public int Low { get; set; }
        public int Change { get; set; }
    }

    public class Task1
    {
        private readonly List<Reading> _readings = new List<Reading>
        {
            new Reading { Day = "6/1/2022", High = 101, Low = 67 },
            new Reading { Day = "6/2/2022", High = 102, Low = 67 },
            new Reading { Day = "6/3/2022", High = 101, Low = 68 },
            new Reading { Day = "6/4/2022", High = 99, Low = 74 },
            new Reading { Day = "6/5/2022", High = 100, Low = 66 },
            new Reading { Day = "6/6/2022", High = 102, Low = 70 },
            new Reading { Day = "6/7/2022", High = 105, Low = 74 },
            new Reading { Day = "6/8/2022", High = 107, Low = 78 },
            new Reading { Day = "6/9/2022", High = 106, Low = 84 },
            new Reading { Day = "6/10/2022", High = 109, Low = 78 },
            new Reading { Day = "6/11/2022", High = 109, Low = 80 },
            new Reading { Day = "6/12/2022", High = 108, Low = 81 },
            new Reading { Day = "6/13/2022", High = 106, Low = 80 },
            new Reading { Day = "6/14/2022", High = 103, Low = 77 },
            new Reading { Day = "6/15/2022", High = 105, Low = 71 },
            new Reading { Day = "6/16/2022", High = 111, Low = 72 },
            new Reading { Day = "6/17/2022", High = 97, Low = 85 },
            new Reading { Day = "6/18/2022", High = 96, Low = 79 },
            new Reading { Day = "6/19/2022", High = 100, Low = 76 },
            new Reading { Day = "6/20/2022", High = 101, Low = 74 },
            new Reading { Day = "6/21/2022", High = 101, Low = 75 },
            new Reading { Day = "6/22/2022", High = 102, Low = 76 },
            new Reading { Day = "6/23/2022", High = 103, Low = 80 },
            new Reading { Day = "6/24/2022", High = 102, Low = 75 },
            new Reading { Day = "6/25/2022", High = 101, Low = 79 },
            new Reading { Day = "6/26/2022", High = 96, Low = 81 },
            new Reading { Day = "6/27/2022", High = 96, Low = 71 },
            new Reading { Day = "6/28/2022", High = 101, Low = 80 },
            new Reading { Day = "6/29/2022", High = 99, Low = 80 },
            new Reading { Day = "6/30/2022", High = 101, Low = 78 },
            new Reading { Day = "7/1/2022", High = 97, Low = 75 },
            new Reading { Day = "7/2/2022", High = 101, Low = 75 },
            new Reading { Day = "7/3/2022", High = 101, Low = 81 },
            new Reading { Day = "7/4/2022", High = 97, Low = 79 },
            new Reading { Day = "7/5/2022", High = 101, Low = 79 },
            new Reading { Day = "7/6/2022", High = 102, Low = 74 },
            new Reading { Day = "7/7/2022", High = 104, Low = 73 },
            new Reading { Day = "7/8/2022", High = 107, Low = 77 },
            new Reading { Day = "7/9/2022", High = 108, Low = 82 },
            new Reading { Day = "7/10/2022", High = 108, Low = 81 },
            new Reading { Day = "7/11/2022", High = 110, Low = 81 },
            new Reading { Day = "7/12/2022", High = 106, Low = 88 },
            new Reading { Day = "7/13/2022", High = 108, Low = 80 },
            new Reading { Day = "7/14/2022", High = 106, Low = 81 },
            new Reading { Day = "7/15/2022", High = 108, Low = 80 },
            new Reading { Day = "7/16/2022", High = 108, Low = 78 },
            new Reading { Day = "7/17/2022", High = 106, Low = 78 },
            new Reading { Day = "7/18/2022", High = 105, Low = 80 },
            new Reading { Day = "7/19/2022", High = 107, Low = 83 },
            new Reading { Day = "7/20/2022", High = 104, Low = 81 },
            new Reading { Day = "7/21/2022", High = 106, Low = 80 },
            new Reading { Day = "7/22/2022", High = 107, Low = 87 },
            new Reading { Day = "7/23/2022", High = 104, Low = 80 },
            new Reading { Day = "7/24/2022", High = 94, Low = 74 },
            new Reading { Day = "7/25/2022", High = 95, Low = 74 },
            new Reading { Day = "7/26/2022", High = 93, Low = 74 },
            new Reading { Day = "7/27/2022", High = 94, Low = 74 },
            new Reading { Day = "7/28/2022", High = 87, Low = 75 },
            new Reading { Day = "7/29/2022", High = 96, Low = 71 },
            new Reading { Day = "7/30/2022", High = 96, Low = 74 },
            new Reading { Day = "7/31/2022", High = 98, Low = 70 },
            new Reading { Day = "8/1/2022", High = 99, Low = 71 },
            new Reading { Day = "8/2/2022", High = 99, Low = 76 },
            new Reading { Day = "8/3/2022", High = 98, Low = 74 },
            new Reading { Day = "8/4/2022", High = 95, Low = 72 },
            new Reading { Day = "8/5/2022", High = 99, Low = 76 },
            new Reading { Day = "8/6/2022", High = 104, Low = 78 },
            new Reading { Day = "8/7/2022", High = 101, Low = 74 },
            new Reading { Day = "8/8/2022", High = 99, Low = 72 },
            new Reading { Day = "8/9/2022", High = 98, Low = 75 },
            new Reading { Day = "8/10/2022", High = 99, Low = 73 },
            new Reading { Day = "8/11/2022", High = 97, Low = 75 },
            new Reading { Day = "8/12/2022", High = 95, Low = 77 },
            new Reading { Day = "8/13/2022", High = 99, Low = 73 },
            new Reading { Day = "8/14/2022", High = 99, Low = 74 },
            new Reading { Day = "8/15/2022", High = 100, Low = 77 },
            new Reading { Day = "8/16/2022", High = 102, Low = 76 },
            new Reading { Day = "8/17/2022", High = 101, Low = 74 },
            new Reading { Day = "8/18/2022", High = 95, Low = 73 },
            new Reading { Day = "8/19/2022", High = 85, Low = 75 },
            new Reading { Day = "8/20/2022", High = 82, Low = 74 },
            new Reading { Day = "8/21/2022", High = 91, Low = 72 },
            new Reading { Day = "8/22/2022", High = 95, Low = 74 },
            new Reading { Day = "8/23/2022", High = 100, Low = 70 },
            new Reading { Day = "8/24/2022", High = 93, Low = 72 },
            new Reading { Day = "8/25/2022", High = 97, Low = 75 },
            new Reading { Day = "8/26/2022", High = 98, Low = 75 },
            new Reading { Day = "8/27/2022", High = 98, Low = 75 },
            new Reading { Day = "8/28/2022", High = 96, Low = 76 },
            new Reading { Day = "8/29/2022", High = 99, Low = 74 },
            new Reading { Day = "8/30/2022", High = 104, Low = 75 },
            new Reading { Day = "8/31/2022", High = 97, Low = 78 }
        };

        public Task1() => CalcDailyTempChanges(); 

        private void CalcDailyTempChanges()
        {
            foreach (var r in _readings) r.Change = r.High - r.Low;
        }

        public void Run()
        {

            int maxChange = _readings.Max(x => x.Change);
            var maxChangeReading = _readings.First(x => x.Change == maxChange);
            Console.WriteLine($"Biggest temperature change Date: {maxChangeReading.Day}, High: {maxChangeReading.High}, " +
                              $"Low: {maxChangeReading.Low}, Change: {maxChangeReading.Change}");

            int minChange = _readings.Min(x => x.Change);
            var minChangeReading = _readings.First(x => x.Change == minChange);
            Console.WriteLine($"Smallest temperature change Date: {minChangeReading.Day}, High: {minChangeReading.High}, " +
                              $"Low: {minChangeReading.Low}, Change: {minChangeReading.Change}");

        }

    }
}