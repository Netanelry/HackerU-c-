using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Horse : AnimalBase
    {
        public bool _isRacingHorse;

        public Horse(string name, bool race) : base(name)
        {
            _isRacingHorse = race;
        }

        public override void MakeSound()
        {
            Neigh();
        }

        public virtual void Neigh()
        {
            Console.WriteLine("Neigh!");
        }

        public override string ToString()
        {
            return base.ToString() + $"Racing horse: {_isRacingHorse}\n";
        }
    }
}
