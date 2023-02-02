using System;
using System.Collections.Generic;
using System.Linq;

namespace hfcu_trefren
{

    class Program
    {
        static void Main()
        {
            // task 1
            Console.WriteLine("Results Task 1");
            var task1 = new Task1();
            task1.Run();

            Console.WriteLine("");
            Console.WriteLine("");

            // task 2
            Console.WriteLine("Results Task 2");
            var task2 = new Task2();
            task2.Run();

            Console.WriteLine("");
            Console.WriteLine("");


            // task 3
            Console.WriteLine("Results task 3");
            var task1Updated = new Task1Updated();
            task1Updated.Run();

            Console.WriteLine("");

            var task2Updated = new Task2Updated();
            task2Updated.Run();

        }
    }
}
