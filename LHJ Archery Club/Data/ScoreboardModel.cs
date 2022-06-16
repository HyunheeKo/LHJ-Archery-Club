using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHJ_Archery_Club.Data
{
    public class ScoreboardModel
    {
        //public List<Set> Sets = new List<Set>();
        public int Score { get; set; }
        public List<Set> Sets { get; set; }

        //public ScoreboardModel(int SetCount = 12)
        //{
        //    Sets = new List<Set>();
        //    for (int i = 0; i < SetCount; i++)
        //    {
        //        Set s = new Set();
        //        s.First = 0;
        //        s.Second = 0;
        //        s.Third = 0;

        //        Sets.Add(s);
        //    }
        //}
    }

    public class Set
    {
        // 첫번째 화살
        public int First { get; set; }
        // 두번째 화살
        public int Second { get; set; }
        // 세번째 화살
        public int Third { get; set; }
    }
}
