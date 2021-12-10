using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Race race = new Race();
            race.CreateContestants();
            race.StartRace(1600);
            race.ShowRanking();
            Console.ReadLine();
        }
    }
}
