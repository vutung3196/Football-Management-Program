using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagament
{
    class Program
    {
        static void Main(string[] args)
        {
            FootballMatchController fbm = new FootballMatchController();
            FootballClubController fbc = new FootballClubController();
            int choice, choice2, choice3, choice4;
            Console.WriteLine("---Welcome to Premier League 2008---");
            Console.WriteLine("=====================================");
            Console.WriteLine("1. Manage the Football club list.");
            Console.WriteLine("2. Manage the schedule of the match.");
            Console.WriteLine("3. Manage the result of the match.");
            Console.WriteLine("4. Rank");
            Console.WriteLine("5. Exit.");
            do
            {
                Console.WriteLine("# Choose: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(" ");
                        Console.WriteLine("=====================================");
                        Console.WriteLine("1. Display the football club list.");
                        Console.WriteLine("2. Update the football club list.");
                        Console.WriteLine("3. Add a new club.");
                        Console.WriteLine("4. Display the club list in ID order");
                        Console.WriteLine("5. Display the club list in name order");
                        Console.WriteLine("0. Back to the main menu");
                        do
                        {
                            Console.WriteLine("# Choose: ");
                            choice2 = int.Parse(Console.ReadLine());

                            switch (choice2)
                            {
                                case 1:
                                    fbc.Display();
                                    break;
                                case 2:
                                    fbc.UpdateClub();
                                    break;
                                case 3:
                                    fbc.AddClub();
                                    break;
                                case 4:
                                    fbc.DisplayId();
                                    break;
                                case 5:
                                    fbc.DisplayName();
                                    break;
                                case 0:
                                    Console.WriteLine("---Welcome to V-League 2008---");
                                    Console.WriteLine("=====================================");
                                    Console.WriteLine("1. Manage the Football club list.");
                                    Console.WriteLine("2. Manage the schedule of the match.");
                                    Console.WriteLine("3. Manage the result of the match.");
                                    Console.WriteLine("4. Rank");
                                    Console.WriteLine("5. Exit.");
                                    break;
                            }
                        }
                        while (choice2 >= 6);
                        break;
                    case 2:
                        Console.WriteLine("=============================");
                        Console.WriteLine("1. Display the schedule.");
                        Console.WriteLine("2. Update the schedule.");
                        Console.WriteLine("3. Create the schedule.");
                        Console.WriteLine("0. Back to the main menu.");
                        do
                        {
                            Console.WriteLine("# Choose: ");
                            choice3 = int.Parse(Console.ReadLine());
                            switch (choice3)
                            {
                                case 1:
                                    fbm.DisplayMatch();
                                    break;
                                case 2:
                                    fbm.UpdateMatch();
                                    break;
                                case 3:
                                    fbm.AddMatch();
                                    break;
                                case 0:
                                    Console.WriteLine("---Welcome to V-League 2008---");
                                    Console.WriteLine("=====================================");
                                    Console.WriteLine("1. Manage the Football club list.");
                                    Console.WriteLine("2. Manage the schedule of the match.");
                                    Console.WriteLine("3. Manage the result of the match.");
                                    Console.WriteLine("4. Rank");
                                    Console.WriteLine("5. Exit.");
                                    break;
                            }
                        }
                        while (choice3 >= 4);
                        break;
                    case 3:
                        Console.WriteLine("=====Football result=====");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("1. Arsenal 3 - 0 Manchester United");
                        Console.WriteLine("2. Chelsea 0 - 3 Tottenham Hotspur");
                        Console.WriteLine("3. Manchester City vs Liverpool");
                        Console.WriteLine("0. Back to the main manu");
                        do
                        {
                            Console.WriteLine("# Choose: ");
                            choice4 = int.Parse(Console.ReadLine());
                            switch (choice4)
                            {
                                case 1:
                                    Console.WriteLine("Arsenal 3 - 0 Manchester United");
                                    Console.WriteLine("Player of the match: Theo Walcot");
                                    Console.WriteLine("Goal: Theo Walcot (19', 46'); Mesut Ozil (72')");
                                    break;
                                case 2:
                                    Console.WriteLine("Chelsea 0 - 3 Tottenham Hotspur");
                                    Console.WriteLine("Player of the match: Harry Kane");
                                    Console.WriteLine("Goal: Harry Kane (57', 80', 88')");
                                    break;
                                case 3:
                                    fbc.UpdateResult();
                                    break;
                            }
                        }
                        while (choice4 >= 4);
                        break;
                    case 4:
                        Console.WriteLine("==========Football Rank==========");
                        fbc.DisplayRank();
                        break;
                    case 5:
                        Console.WriteLine("Good luck");
                        Environment.Exit(0);
                        break;                    
                }
            }
            while (choice != 6) ;
        }
    }
}