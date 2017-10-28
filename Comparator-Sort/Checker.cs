using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparator_Sort
{
    public class Checker : IComparer<Player>
    {

        public int Compare(Player a, Player b)
        {
            if (a.score == b.score)
            {
                return b.name.CompareTo(b.name);
            }
            return b.score - a.score;
        }
    }
}
