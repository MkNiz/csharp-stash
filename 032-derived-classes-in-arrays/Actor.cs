using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_derived_classes_in_arrays
{
    class Actor
    {
        protected string name { get; set; }

        protected int hp;
        protected int atk;
        protected int def;

        public Actor(string name, int hp, int atk, int def)
        {
            this.name = name;
            this.hp = hp;
            this.atk = atk;
            this.def = def;
        }

        public void attack(Actor target)
        {
            Console.WriteLine(name + " attacks " + target.name + "!");
            target.takeHit(atk);
        }

        public void takeHit(int incomingDmg)
        {
            int mitigatedDmg = incomingDmg - (def / 4);
            if (mitigatedDmg < 1) { mitigatedDmg = 1; }
            Console.WriteLine(name + " took " + mitigatedDmg + " damage! ");
            hp -= mitigatedDmg;
        }

        public void battleCry()
        {
            Console.WriteLine(name + " screams!");
        }

        public void smileForCamera()
        {
            Console.WriteLine(name + " smiles for the camera!");
        }
    }
}
