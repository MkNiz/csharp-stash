using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035_abstract_class
{
    class Enemy : Actor
    {
        public Enemy(string name, int atk, int hp)
        {
            this.name = name;
            this.atk = atk;
            this.hp = hp;
        }

        public override void taunt()
        {
            Console.WriteLine("The " + name + " leers!");
            Console.WriteLine();
        }
    }
}
