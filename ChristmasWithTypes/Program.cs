using System;
using System.Diagnostics;

namespace ChristmasWithTypes
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    class Program
    {
        static void Main(string[] args, string Kris)
        {
        }

        private static void Main1(string[] args, string Kringle, string kris, string kris)
        {
            var xmas = new Christmas();

            var xmasDay = Christmas.Day.Thursday;

            //TODO set Santa's name to Kris Kringle
            xmas.Santa = kris Kringle
        
                //TODO Insert 3 presents you would like for xmas.  They must be strings
                xmas.Presents = new string[3] { };

            //TODO Set the TreeHeight to 10
            xmas.TreeHeight = 10;

            Console.WriteLine($"This year christmas falls on {xmasDay} \n");
            Console.WriteLine($"Our tree will be {xmas.TreeHeight} feet high \n");
            Console.WriteLine("Here are the presents we would like:");

            foreach (var present in xmas.Presents)
            {
                Console.WriteLine($"    {present}");
            }

            Console.WriteLine($"\n We like to call Santa, {xmas.Santa}");
        }


    }
    }
