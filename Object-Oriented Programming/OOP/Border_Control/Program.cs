using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Border_Control
{
    class Program
    {
        public interface IPerson
        {
            string Name { get; set; }
            int Age { get; set; }
        }

        public interface IID
        {
            string ID { get; set; }
        }

        public interface IRobot
        {
            string Model { get; set; }
        }

        public interface IBirthable
        {
            string BirthDate { get; set; }
        }

        public interface IPet
        {
            string Name { get; set; }
        }


        public class Citizen : IPerson, IID,IBirthable
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string ID { get; set; }
            public string BirthDate { get; set; }

            public Citizen(string name,int age,string id,string birthdate)
            {
                Name = name;
                Age = age;
                ID = id;
                BirthDate = birthdate;
            }
            
        }

        public class Pet : IPet, IBirthable
        {
            public string Name { get; set; }
            public string BirthDate { get; set; }

            public Pet(string name,string birthdate)
            {
                Name = name;
                BirthDate = birthdate;
            }
        }

        public class Robot : IRobot, IID
        {
            public string Model { get; set; }
            public string ID { get; set; }

            public Robot(string model, string id)
            {
                Model = model;
                ID = id;
            }
        }

        static void Main(string[] args)
        {
            List<IBirthable> birthDates = new List<IBirthable>();
            List<IID> iDs = new List<IID>();
            string[] input = Console.ReadLine().Split(' ');

            while (input[0].ToLower()!="end")
            {
                if (input[0]=="Citizen")
                {
                    Citizen citizen = new Citizen(input[1], Convert.ToInt32(input[2]),input[3],input[4]);
                    birthDates.Add(citizen);
                }
                else if(input[0]=="Robot")
                {
                    Robot robot = new Robot(input[1], input[2]);
                    iDs.Add(robot);
                }
                else if(input[0]=="Pet")
                {
                    Pet pet = new Pet(input[1], input[2]);
                    birthDates.Add(pet);
                }
                input = Console.ReadLine().Split(' ');
            }
            string banNum = Console.ReadLine();
            /*List<IID> iDs1 = iDs.Where(x => x.ID.EndsWith(banNum)).ToList();

            foreach (var item in iDs1)
            {
                Console.WriteLine(item.ID);
            }*/

            List<IBirthable> birthables = birthDates.Where(x => x.BirthDate.EndsWith(banNum)).ToList();
            foreach (var item in birthables)
            {
                Console.WriteLine(item.BirthDate);
            }
        }
    }
}
/*
Robot VV-XYZ 11213141 
Citizen Corso 35 7903210713 21/03/1979 
Citizen Kane 40 7409073566 07/09/1974 
End 
1975   */

