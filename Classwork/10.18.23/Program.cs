using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._18._23
{
    class Program
    {
        public class Footbaler
        {
            private string egn;
            private string position;
            private int hours;
            public string Name { get; set; }
            public string EGN { get { return egn; } set { if (value.Length < 10 || value.Length > 10) { Console.WriteLine("It needs to 10 numbers!"); } else { egn = value; } ; } }
            public string Position { get { return position; } set { if (value != "defender" || value != "striker" || value != "midfielder" || value != "goalkeeper") { Console.WriteLine("It needs to be defender,midfielder,striker or goalkeeper"); } else { position = value; } } }
            public int Hours { get { return hours; } set { if (value < 0) { Console.WriteLine("It needs to be a real number!"); } else { hours = value; } } }
            public Footbaler(string name,string egn,string position,int hours)
            {
                Name = name;
                EGN = egn;
                Position = position;
                Hours = hours;
            }

            public double Coefficiency()
            {
                double coef = 0;
                int age = 0;
                
                string year;
                if (EGN[2] == '4' || EGN[2] == '5')
                {
                    year = "20" + EGN[0] + EGN[1];
                    age = Convert.ToInt32(year);
                }
                string yearb;
                if (EGN[2]=='0' || EGN[2] == '1')
                {
                    yearb="19"+ EGN[0] + EGN[1];
                    age = Convert.ToInt32(yearb);
                }
                coef = (60 - age) * Hours / 100;
                return coef;
            }
            public override string ToString()
            {
                return $"The player {Name} who is a {position} has coefficient {Coefficiency()}";
            }
        }

        public class Team
        {
            List<Footbaler> footbalers = new List<Footbaler>();
            public string Club { get; set; }

            public Team(string club)
            {
                Club = club;
            }

            public void AddPlayer(Footbaler fb)
            {
                for (int i = 0; i < footbalers.Count; i++)
                {
                    if (footbalers[i].EGN.Equals(i))
                    {
                        Console.WriteLine("There is a footbaler with this social secuty number!");
                    }
                    else
                    {
                        footbalers.Add(fb);
                        Console.WriteLine("You have succsessfully added a new player");
                    }
                }
            }

            public void Sell(string egn)
            {
                for (int i = 0; i < footbalers.Count; i++)
                {
                    if (footbalers[i].EGN.Equals(egn) && footbalers[i].Coefficiency()>50)
                    {
                        Console.WriteLine("The player is not for sale!");
                    }
                    else if (footbalers[i].EGN.Equals(egn) && footbalers[i].Coefficiency() < 50)
                    {
                        Console.WriteLine("Successful sale!");
                        footbalers.RemoveAt(i);
                        i--;
                    }
                    else
                    {
                        Console.WriteLine("You have succsessfully added a new player");
                    }
                } 
            }

            public void FootballGame(string Egn,int time)
            {
                for (int i = 0; i < footbalers.Count; i++)
                {
                    if (footbalers[i].EGN.Equals(Egn))
                    {
                        footbalers[i].Hours+=time;
                        Console.WriteLine("Successful augumentation");
                    }
                    else
                    {
                        Console.WriteLine("There is no such player");
                    }
                }
            }

            public int CountPlayers(string position)
            {
                int count = 0;
                for (int i = 0; i < footbalers.Count; i++)
                {
                    if (footbalers[i].Position.Equals(position))
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

        }
    }
}
