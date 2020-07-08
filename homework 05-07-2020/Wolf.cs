using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Wolf : Dog
    {
        public string _nameOfPack;

        public Wolf(string name, string fav, string pack) : base(name, fav)
        {
            _nameOfPack = pack;
        }

        public override string ToString()
        {
            return base.ToString() + $"Pack Name: {_nameOfPack}\n";
        }
    }
}
