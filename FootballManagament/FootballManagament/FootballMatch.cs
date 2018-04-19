using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagament
{
    class FootballMatch
    {
        private string idMatch;

        public string IdMatch
        {
            get { return idMatch; }
            set { idMatch = value; }
        }

        private string dateMatch;

        internal string DateMatch
        {
            get { return dateMatch; }
            set { dateMatch = value; }
        }

        private string nameMatch;
        internal string NameMatch
        {
            get { return nameMatch; }
            set { nameMatch = value; }
        }
        private string hourMatch;

        internal string HourMatch
        {
            get { return hourMatch; }
            set { hourMatch = value; }
        }
        private string stadiumMatch;

        internal string StadiumMatch
        {
            get { return stadiumMatch; }
            set { stadiumMatch = value; }
        }
        


    }
}
