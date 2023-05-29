using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallengeTeamPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Enter number of players");

            int n = Convert.ToInt32(Console.ReadLine());

            List<Team> tl = new List<Team>();

            for (int i = 0; i < n; i++)

            {

                Console.WriteLine("Enter player name");

                string pn = Console.ReadLine();

                Console.WriteLine("Enter team name");

                string tn = Console.ReadLine();

                Console.WriteLine("Enter number of raid points");

                long point = long.Parse(Console.ReadLine());

                tl.Add(new Team(pn, tn, point));



            }


            var v = from l in tl

                    orderby l.RaidPoints descending

                    group l by l.TeamName into grp

                    select new

                    {

                        tn = grp.Key,

                        d = grp

                    };



            foreach (var p in v)

            {

                Console.WriteLine("Team : " + p.tn);

                foreach (var item in p.d)

                {

                    Console.WriteLine(item.PlayerName + " " + item.RaidPoints);

                }

            }
            Console.ReadLine();

        }

    }
}

