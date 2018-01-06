using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044_generic_constraints
{
    class Pantry<T> where T : Edible
    {
        private T[] contents;

        public Pantry(int size)
        {
            contents = new T[size];
        }

        public void place(int idx, T item)
        {
            if (!isValidSpace(idx))
            {
                Console.WriteLine("You can't place an item in a space that doesn't exist!");
            }
            else if (contents[idx] != null)
            {
                Console.WriteLine("There's a " + contents[idx].name + " in this space, you'll have to move it first.");
            }
            else
            {
                contents[idx] = item;
                Console.WriteLine("Placed a " + item.name + " in the pantry.");
            }
        }

        public void move(int idx1, int idx2)
        {   
            if (!isValidSpace(idx1) || !isValidSpace(idx2))
            {
                Console.WriteLine("You can't work with spaces that don't exist!");
            }
            else if (contents[idx1] == null)
            {
                Console.WriteLine("There's nothing to move from space #" + (idx1 + 1) + "!");
            }
            else if (contents[idx2] == null)
            {
                Console.WriteLine("Moving " + contents[idx1].name + " to space #" + (idx2 + 1) + ".");
                contents[idx2] = contents[idx1];
                contents[idx1] = default(T);
            }
            else
            {
                T item1 = contents[idx1];
                T item2 = contents[idx2];
                Console.WriteLine("Swapping the positions of the " + item1.name + " and " + item2.name + "...");
                contents[idx2] = item1;
                contents[idx1] = item2;
            }
        }

        public T remove(int idx)
        {
            if (!isValidSpace(idx))
            {
                Console.WriteLine("That space does not exist in the pantry.");
                return default(T);
            }
            else if (contents[idx] == null)
            {
                Console.WriteLine("There is nothing in space #" + (idx+1) + " in the pantry.");
                return default(T);
            }
            else
            {
                T item = contents[idx];
                Console.WriteLine("You remove the " + item.name + ".");
                contents[idx] = default(T);
                return item;
            }
        }

        public void eat(int idx)
        {
            T item = remove(idx);
            if (item != null)
                item.eat();
        }

        public void eatAll()
        {
            Console.WriteLine("Eating everything in the pantry...");
            for(int i = 0; i < contents.Length; i++)
                eat(i);
        }

        private bool isValidSpace(int idx)
        {
            return (idx >= 0 && idx < contents.Length);
        }
    }
}
