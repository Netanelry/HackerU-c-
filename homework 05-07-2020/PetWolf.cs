using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    /*
     first chalange- make the PetWolf class a non-inheritable class: we can use "sealed" in the class singuture as so:

    public sealed class PetWolf : Wolf

    while making the class static will have the same effect it is not possibale to use it with a class that is not derived from the object class
     */
    public class PetWolf : Wolf
    {
        public PetWolf(string name, string fav, string pack) : base(name, fav, pack)
        {

        }

        public override void Bark()
        {
            Console.WriteLine("Grrrrrrrrrr....");
        }
    }
}
