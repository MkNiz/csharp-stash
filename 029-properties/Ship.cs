using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_properties
{
    class Ship
    {
        // Uses a basic, automatic getter and setter
        public int speed { get; set; }

        // Specify a getter and setter. Getter is public, but the setter is private.
        private int passengers;

        public int Passengers
        {
            get
            {
                return passengers;
            }
            private set
            {
                passengers = value;
                if (passengers < 0)
                {
                    passengers = 0;
                }
            }
        }

        // Getter and setter properties can be separately named from the member itself
        private int cannons;

        public int TurboCannons
        {
            get
            {
                return cannons;
            }
            set
            {
                cannons = value;
            }
        }

        // Use the private setter for passengers
        public void BoardPassengers(int p)
        {
            Console.WriteLine(p + " passengers board the ship.");
            Passengers += p;
        }

        public void Describe()
        {
            Console.WriteLine("The ship is sailing at a speed of " + speed + " while carrying " + passengers + " passengers.");
            Console.WriteLine("There are " + TurboCannons + " cannons currently on board.");
        }
    }
}
