using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public abstract class AnimalBase
    {
        public string _name;

        public AnimalBase(string n)
        {
            _name = n;
        }

        public abstract void MakeSound();

        public override string ToString()
        {
            return $"name: {_name}\n";
        }
    }
}
