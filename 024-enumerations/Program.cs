using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_enumerations
{
    class Program
    {
        public enum PlayerClass { FightingMan, MagicUser, Priest };

        static void Main(string[] args)
        {
            PlayerClass bobClass = PlayerClass.FightingMan;

            switch (bobClass)
            {
                case PlayerClass.FightingMan:
                    Console.WriteLine("Bob is a Fighting Man.");
                    break;
                case PlayerClass.MagicUser:
                    Console.WriteLine("Bob is a Magic User.");
                    break;
                case PlayerClass.Priest:
                    Console.WriteLine("Bob is a Priest.");
                    break;
                default:
                    Console.WriteLine("Bob does not have a class.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
