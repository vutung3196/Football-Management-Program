using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagament
{
    class FootballResult 
    {
        private string nameClub1;
        private string nameClub2;
        private int goalClub1;
        private int goalClub2;

        internal string NameClub1
        {
            get { return nameClub1; }
            set { nameClub1 = value; }
        }

        internal string NameClub2
        {
            get { return nameClub2; }
            set { nameClub2 = value; }
        }

        internal int GoalClub1
        {
            get { return goalClub1; }
            set { goalClub1 = value; }
        }

        internal int GoalClub2
        {
            get { return goalClub2; }
            set { goalClub2 = value; }
        }
    }
}