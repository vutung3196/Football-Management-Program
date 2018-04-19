using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagament
{
    class FootBallResultController
    {
        private List<FootballResult> resultList;
        internal List<FootballResult> ResultList
        {
            get { return resultList; }
            set { resultList = value; }
        }
        internal FootBallResultController()
        {
            ResultList = new List<FootballResult>();
        }
        internal void DisplayResult()
        {
            Console.WriteLine("====Result====");
            Console.WriteLine("1. Thể Công – Viettel 3 - 0 Hoàng Anh Gia Lai");
            Console.WriteLine("2. SLNA 2 - 0 Hai Phong");
        }
    }
}
