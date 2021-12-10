using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest
{
    public class Race
    {

        public List<Equipage> raceTrackOne = new List<Equipage>();
        public Queue<Equipage> raceTrackOneFinished = new Queue<Equipage>();
        //Creates 8 Equipages with each their Jockey, Sulky and Horse.
        public void CreateContestants()
        {
            for (int i = 1; i < 9; i++)
            {
                IHorse h = Factory.CreateHorse();
                h.HorseNumber = i;
                h.RunInMeters = 0;
                ISulky s = Factory.CreateSulky();
                s.Type = "Carbon Fiber";
                IJockey j = Factory.CreateJockey();
                j.Firstname = "Contestant ";
                j.Lastname = "Number: " + i;
                Equipage con = new Equipage(h, s, j);
                raceTrackOne.Add(con);
            }
        }
        //Starts a race with a given range. 8-18 is meters pr second.
        public void StartRace(int range)
        {
            Random ran = new Random();
            while (raceTrackOne != null)
            {
                foreach (Equipage item in raceTrackOne)
                {
                    if (item.Horse.RunInMeters < range)
                    {
                        item.Horse.RunInMeters = item.Horse.RunInMeters + ran.Next(8, 18);
                    }
                    else if (item.Horse.RunInMeters <= range)
                    {
                        raceTrackOneFinished.Enqueue(item);
                        raceTrackOne.Remove(item);
                    }
                }
                
            }
        }
        //Method that runs trough the que  from the last place to the winner, in that order (That's why i used the Que)
        public void ShowRanking()
        {
            for (int i = 0; i < raceTrackOneFinished.Count; i++)
            {
                foreach (Equipage item in raceTrackOneFinished)
                {
                    Console.WriteLine(item.Horse.HorseNumber);
                    Console.WriteLine(item.Horse.RunInMeters);
                    Console.WriteLine(item.Sulky.Type);
                    Console.WriteLine(item.Jockey.Firstname + item.Jockey.Lastname);
                }
            }
        }

    }
}

