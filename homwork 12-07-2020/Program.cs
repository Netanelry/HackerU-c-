using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Citizen c1 = new Citizen("Kane", 0);
            Citizen c2 = new Citizen("kanny", 1);
            Citizen c3 = new Citizen("Kane jr", 1);
            Citizen c4 = new Citizen("fridrick augustus the 3rd", 1);

            Citizen[] childrens = new Citizen[]
            {
                    c2,
                    c3,
                    c4,
            };

            c1.SetChildren(childrens);
        }

        public bool HasChildren(Citizen citizen)
        {
            return citizen._children.Length != 0;
        }

        public bool ChackValidity(Citizen citizen)
        {
            bool chack = false;
            if (HasChildren(citizen))
            {
                foreach (Citizen children in citizen._children)
                {
                    if (children._fatherID == citizen._id)
                        chack = true;
                }
            }
            return chack;
        }
    }
}