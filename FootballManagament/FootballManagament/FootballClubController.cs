using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagament {
    class FootballClubController {
        int d = 0;
        private List<FootballClub> clubList;
        internal List<FootballClub> ClubList
        {
            get { return clubList; }
            set { clubList = value; }
        }

        internal FootballClubController() {
            ClubList = new List<FootballClub>();
        }

        internal void AddClub() {
            Console.WriteLine("Please enter the ID: ");
            string idclub1 = Console.ReadLine();
            Console.WriteLine("Please enter the name of the club: ");
            string nameclub1 = Console.ReadLine();
            Console.WriteLine("Please enter the name of the coach: ");
            string namecoach1 = Console.ReadLine();
            FootballClub fc = new FootballClub() { IdClub = idclub1, NameClub = nameclub1, NameCoach = namecoach1 };
            ClubList.Add(fc);
        }

        internal void UpdateClub() {
            Console.WriteLine("Please enter the ID: ");
            string idclub2 = Console.ReadLine();
            for (int i = 0; i < ClubList.Count; i++) {
                if (ClubList[i].IdClub.Equals(idclub2)) {
                    Console.WriteLine("Please enter the new name: ");
                    string nameclub2 = Console.ReadLine();
                    Console.WriteLine("Please enter the new coach's name: ");
                    string namecoach2 = Console.ReadLine();
                    Console.WriteLine("Do you want to update(Y/N) ?");
                    string userchoice2 = Console.ReadLine();
                    if (userchoice2.Equals("Y")) {
                        ClubList[i].NameClub = nameclub2;
                        ClubList[i].NameCoach = namecoach2;
                        Console.WriteLine("The information is updated successfully");
                    } else{
                        Console.WriteLine("Comeback us if you want to update");
                    }
                }
            }
        }

        internal void Display() {
            Console.WriteLine("================================================");
            Console.WriteLine("|ID\t|Club\t|Coach\t|");
            Console.WriteLine("================================================");
            for (int i = 0; i < ClubList.Count; i++) {
                FootballClub fd = ClubList[i];
                Console.WriteLine("|" + fd.IdClub + "  |  " + fd.NameClub + "  |  " + fd.NameCoach + " |");
            }
            Console.WriteLine("================================================");
        }

        internal void DisplayId() {
            Console.WriteLine("================================================");
            Console.WriteLine("|ID\t|Club\t|Coach\t|");
            List<FootballClub> SortedIdClubList = ClubList.OrderBy(o => o.IdClub).ToList();
            for (int i = 0; i < SortedIdClubList.Count; i++) {
                FootballClub fd2 = ClubList[i];
                Console.WriteLine("|  " + fd2.IdClub + "\t|" + fd2.NameClub + "\t|" + fd2.NameCoach + "\t|");
            }
            Console.WriteLine("================================================");
        }

        internal void DisplayName() {
            Console.WriteLine("================================================");
            Console.WriteLine("|ID\t|Club\t|Coach\t|");
            List <FootballClub> SortedNameClubList = ClubList.OrderBy(o => o.NameClub).ToList();
            for (int i = 0; i < SortedNameClubList.Count; i++) {
                FootballClub fd3 = ClubList[i];
                Console.WriteLine("|  " + fd3.IdClub, "  |  " + fd3.NameClub, "  |  " + fd3.NameCoach, " |");
            }
            Console.WriteLine("================================================");
        }

        internal void UpdateResult() {
            Console.WriteLine("Manchester City vs Liverpool");
            Console.WriteLine("Goals from Manchester City: ");
            int goal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Goal from Liverpool: ");
            int goal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Do you want to update ?(Y/N)");
            string choice5 = Console.ReadLine();
            if (choice5.Equals("Y")) {
                Console.WriteLine("The result is updated successfully");
                Console.WriteLine(" ");
                Console.WriteLine("Manchester City " + goal1 + " - " + goal2 + " Liverpool");
            }
            if (choice5.Equals("N")) {
                Console.WriteLine("Visit us if you want to update result");
            }
        }

        internal void DisplayRank() {
            for (int i = 0; i < ClubList.Count; i++) {
                Console.WriteLine("Welcome to  " + ClubList[i].NameClub);
                Console.WriteLine("Please enter the number of match: ");
                ClubList[i].MatchNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the number of won match: ");
                ClubList[i].WinMatchNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the number of drawn match: ");
                ClubList[i].TieMatchNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the number of lost match: ");
                ClubList[i].LoseMatchNumber = int.Parse(Console.ReadLine());
                ClubList[i].PointClub = ClubList[i].pointFootBall();
            }
            Console.WriteLine("==============================================");
            Console.WriteLine("|Club\t|Match\t|Won\t|Drawn\t|Lost\t|Points\t|");
            ClubList.Sort(delegate (FootballClub x, FootballClub y) {
                if (x.PointClub == 0) return -1;
                else if (x.PointClub == 0) return 1;
                else return x.PointClub.CompareTo(y.PointClub);
            });
            
            for (int i = 0; i < ClubList.Count; i++) {
                Console.WriteLine("|" + ClubList[i].NameClub + "\t|" + ClubList[i].MatchNumber + "\t|" + ClubList[i].WinMatchNumber + "\t|" + ClubList[i].TieMatchNumber + "\t|" + ClubList[i].LoseMatchNumber + "\t|" + ClubList[i].PointClub + "\t|");
            }
            Console.WriteLine("=================================================================");
        }
    }
}