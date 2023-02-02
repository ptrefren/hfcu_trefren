using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace hfcu_trefren
{
    public class Helper
    {
        public static void CalcDiffs<T>(IList<T> myList) where T : IBaseValues
        {
            foreach (T r in myList) r.Diff = r.Value1 - r.Value2;
        }

    }
}
