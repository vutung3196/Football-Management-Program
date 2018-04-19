using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagament
{
    class FootballMatchController
    {
       
        private List<FootballMatch> matchList;

        internal List<FootballMatch> MatchList
        {
            get { return matchList; }
            set { matchList = value; }
        }

        internal FootballMatchController()
        {
            MatchList = new List<FootballMatch>();
        }

        internal void AddMatch()
        {
            Console.WriteLine("=====Creat a match =======");
            Console.WriteLine("Please enter the id: ");
            string idMatch1 = Console.ReadLine();
            Console.WriteLine("Please enter the name ");
            string nameMatch1 = Console.ReadLine();
            Console.WriteLine("Please enter the date: ");
            string dateMatch1 = Console.ReadLine();
            Console.WriteLine("Please enter the time: ");
            string hourMatch1 = Console.ReadLine();
            Console.WriteLine("Please enter the name of stadium: ");
            string stadiumMatch1 = Console.ReadLine();
            Console.WriteLine("Do you want to update(Y/N) ?");
            string userchoice3 = Console.ReadLine();
            if (userchoice3.Equals("Y"))
            {
                FootballMatch fm = new FootballMatch() { IdMatch = idMatch1, NameMatch = nameMatch1, DateMatch = dateMatch1, HourMatch = hourMatch1, StadiumMatch = stadiumMatch1 };
                MatchList.Add(fm);
                Console.WriteLine("The match is created successfully");
            }
            else
            {
                Console.WriteLine("Come back us another time if you want to update");
            }
        }

        internal void UpdateMatch()
        {
            Console.WriteLine("=====Creat a match =======");
            Console.WriteLine("Please enter the id:");
            string idMatch2 = Console.ReadLine();
            for (int i = 0; i < MatchList.Count; i++)
            {
                if (MatchList[i].IdMatch.Equals(idMatch2))
                {
                    Console.WriteLine("Please enter the new name: ");
                    string nameMatch2 = Console.ReadLine();
                    Console.WriteLine("Please enter the new date: ");
                    string dateMatch2 = Console.ReadLine();
                    Console.WriteLine("Please enter the time: ");
                    string hourMatch2 = Console.ReadLine();
                    Console.WriteLine("Please enter the name of stadium: ");
                    string stadiumMatch2 = Console.ReadLine();
                    Console.WriteLine("Do you want to update(Y/N) ?");
                    string userchoice2 = Console.ReadLine();
                    if (userchoice2.Equals("Y"))
                    {
                        MatchList[i].NameMatch = nameMatch2;
                        MatchList[i].DateMatch = dateMatch2;
                        MatchList[i].HourMatch = hourMatch2;
                        MatchList[i].StadiumMatch = stadiumMatch2;
                        Console.WriteLine("The information is updated successfully");
                    }
                    else
                    {
                        Console.WriteLine("Comeback us if you want to update");
                    }
                }
            }
        }
         internal void DisplayMatch()
         {
            Console.WriteLine("==========================================================");
            Console.WriteLine("|Name\t\t\t|Date\t\t|Time\t|Stadium\t|");
            Console.WriteLine("==========================================================");
            for (int i = 0; i < MatchList.Count; i++)
            {
                FootballMatch fm2 = MatchList[i];
                Console.Write("|"+ fm2.NameMatch + "\t|" + fm2.DateMatch + "\t|" + fm2.HourMatch + "\t|" + fm2.StadiumMatch +"\t|");
                Console.WriteLine(" ");
                
            }
            Console.WriteLine("=================================================================");
        }
         
        }
    }
