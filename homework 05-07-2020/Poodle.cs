using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Poodle : Dog
    {
        public string _numOfPonyTails;

        public Poodle(string name, string fav, string tails) : base(name, fav)
        {
            _numOfPonyTails = tails;
        }

        public override void Bark()
        {
            Console.WriteLine("weef!");
        }

        public override string ToString()
        {
            return base.ToString() + $"Number of Pony Tails: {_numOfPonyTails}\n";
        }
    }
}
