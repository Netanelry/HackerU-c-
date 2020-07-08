using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Dog : AnimalBase
    {
        public string _favDogFood;

        public Dog(string name, string fav) : base(name)
        {
            _favDogFood = fav;
        }

        public override void MakeSound()
        {
            Bark();
        }

        public virtual void Bark()
        {
            Console.WriteLine("Bark! Bark! Bark!");
        }

        public override string ToString()
        {
            return base.ToString() + $"Favorite Food: {_favDogFood}\n";
        }
    }
}
