using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagament
{
    public class FootballClub : IEquatable<FootballClub>, IComparable<FootballClub>
    {
        private string idClub;
        private string nameClub;
        private string nameCoach;
        private int matchNumber;
        private int winMatchNumber;
        private int loseMatchNumber;
        private int tieMatchNumber;
        private int pointClub;
        private int goalClub;

        public string IdClub {
            get { return idClub; }
            set { idClub = value; }
        }

        public string NameClub
        {
            get { return nameClub; }
            set { nameClub = value; }
        }
      
        public string NameCoach
        {
            get { return nameCoach; }
            set { nameCoach = value; }
        }

        public int MatchNumber
        {
            get { return matchNumber; }
            set { matchNumber = value; }
        }

        public int WinMatchNumber
        {
            get { return winMatchNumber; }
            set { winMatchNumber = value; }
        }
 
        public int LoseMatchNumber
        {
            get { return loseMatchNumber; }
            set { loseMatchNumber = value; }
        }

        public int TieMatchNumber
        {
            get { return tieMatchNumber; }
            set { tieMatchNumber = value; }
        }
      
        public int PointClub
        {
            get { return pointClub; }
            set { pointClub = value; }
        }

        public int GoalClub
        {
            get { return goalClub; }
            set { goalClub = value; }
        }

        public FootballClub(string NameClub)
        {
            this.NameClub = NameClub;
        }

        public FootballClub()
        {
        }

        public FootballClub(string IdClub, string NameClub, string NameCoach)
        {
            this.IdClub = IdClub;
            this.NameClub = NameClub;
            this.NameCoach = NameCoach;
        }

        public FootballClub(string IdClub, string NameClub, string NameCoach, int MatchNumber, int WinMatchNumber, int LoseMatchNumber, int TieMatchNumber)
        {
            this.IdClub = IdClub;
            this.NameClub = NameClub;
            this.NameCoach = NameCoach;
            this.MatchNumber = MatchNumber;
            this.WinMatchNumber = WinMatchNumber;
            this.LoseMatchNumber = LoseMatchNumber;
            this.TieMatchNumber = TieMatchNumber;
        }

        public int PointFootBall()
        {
            return 3 * WinMatchNumber + 1 * TieMatchNumber;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            FootballClub objAspart = obj as FootballClub;
            if (objAspart == null)
                return false;
            else
                return Equals(objAspart);         
        }

        public int SortbyPoint(int point1, int point2)
        {
            return point1.CompareTo(point2);
        }

        public int CompareTo(FootballClub comparePart)
        {
            if (comparePart == null)
                return 1;
            else
                return this.PointClub.CompareTo(comparePart.PointClub);
        }

        public override int GetHashCode()
        {
            return PointClub;
        }

        public bool Equals(FootballClub other)
        {
            if (other == null) return false;
            return this.PointClub.Equals(other.PointClub);
        }
    }
}