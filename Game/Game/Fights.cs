using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Fights
    {
        public void FightWithBeast(int playerhealth, int monsterhealth, double playerdamage, double monsterdamage)
        {   
            Console.WriteLine("Бой с тварью начинается");

        }
        public void Death()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                           Вы мертвы");
        }
    }
}
