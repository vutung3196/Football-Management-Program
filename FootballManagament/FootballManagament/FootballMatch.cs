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
        private string dateMatch;
        private string nameMatch;
        private string hourMatch;
        private string stadiumMatch;

        public string IdMatch
        {
            get { return idMatch; }
            set { idMatch = value; }
        }

        internal string DateMatch
        {
            get { return dateMatch; }
            set { dateMatch = value; }
        }

        internal string NameMatch
        {
            get { return nameMatch; }
            set { nameMatch = value; }
        }

        internal string HourMatch
        {
            get { return hourMatch; }
            set { hourMatch = value; }
        }

        internal string StadiumMatch
        {
            get { return stadiumMatch; }
            set { stadiumMatch = value; }
        }
    }
}