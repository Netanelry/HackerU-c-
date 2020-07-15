using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Citizen
    {
        public string _name;
        public Citizen[] _children;
        public readonly int _fatherID;
        public readonly int _id;
        public static int _numOfCurrentCitizens = 0;
        public const int _MAX_NUM_OF_CITIZENS = 10;

        public Citizen(string name, int fatherID)
        {
            Citizen._numOfCurrentCitizens++;
            _id = Citizen._numOfCurrentCitizens;
            _name = name;
            _fatherID = fatherID;
        }
        public static void PrintNumOfCitizens()
        {
            Console.WriteLine (_numOfCurrentCitizens);
        }

        public static bool IsMaxSizeReached()
        {
            bool isMax;
            if (_numOfCurrentCitizens <= _MAX_NUM_OF_CITIZENS)
                isMax = true;
            else
                isMax = false;
            return isMax;
        }

        public void PrintID()
        {
            Console.WriteLine(_id);
        }

        public void PrintGapBetweenMyIDAndFather()
        {
            Console.WriteLine(_id - _fatherID);
        }

        public void SetChildren(Citizen[] Childrens)
        {
            _children = Childrens;
        }

        public override string ToString()
        {
            return $"CITIZEN INFO.\nName: {_name}\nID: {_id}\nFather ID: {_fatherID}\nKnown Childrens: {_children}";
        }
    }
}
