using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("K9", "oil")
            {
            };

            Poodle poodle = new Poodle("Mega Overlord of Doom", "Tears of the Innocents", "9")
            {
            };

            Wolf wolf = new Wolf("Belgarath", "liquor", "Sons of Aldur")
            {
            };

            Horse horse = new Horse("Thowra", true)
            { 
            };

            AnimalBase[] zoo = new AnimalBase[]
                {
                    dog,
                    poodle,
                    wolf,
                    horse,
                };

            PetWolf petWolf = new PetWolf("Belgarion", "helf-Dryads", "the Children of Prophecy")
            {
            };
        }

        public static void AnimalSing(AnimalBase [] animalBase)
        {   
            foreach (AnimalBase animal in animalBase)
            {
               animal.MakeSound();
            }
        }

        /* 
         second chalenge- well this way is much much easier, but i did have to learn about list<> from the web... oh well...

         public static Horse[] GetRacingHorses(Horse[] horses)
         {
             List <Horse> list = new List<Horse>();

             foreach (Horse horse in horses)
             {
                 if (horse._isRacingHorse)
                     list.Add(horse);
             }
             return list.ToArray();
         }
        */

        public static Horse[] GetRacingHorses(Horse[] horses)
        {
            int i = -1;
            foreach (Horse horse in horses)
            {
                i++;
            }

            Horse[] raceHorses = new Horse[i];

            int c = 0;
            foreach (Horse horse in horses)
            {
                if (horse._isRacingHorse)
                {
                    raceHorses[c] = horse;
                    c++;
                }
            }
            return raceHorses;
        }
    }
}
