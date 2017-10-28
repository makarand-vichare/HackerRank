using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparator_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var checker = new Checker();
            Player[] player = new Player[] {

                new Player("amy",100),
                new Player("david",100),
                new Player("heraldo",50),
                new Player("aakansha",75),
                new Player("aleksa",150),
            };

            Array.Sort(player, checker);
            for (int i = 0; i < player.Length; i++)
            {
                Console.WriteLine($"{player[i].name} {player[i].score}");
            }

            Console.ReadLine();
        }
    }
}
