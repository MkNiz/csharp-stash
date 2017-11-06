using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031_inheritance
{
    class Monster : Actor
    {
        private string monsterType;

        public Monster(string name, string monsterType, int hp, int atk, int def) : base(name, hp, atk, def)
        {
            this.monsterType = monsterType;
        }

        public new void battleCry()
        {
            Console.WriteLine(name.ToUpper() + ": You can't possibly defeat a " + monsterType.ToUpper() + "!");
        }
    }
}
