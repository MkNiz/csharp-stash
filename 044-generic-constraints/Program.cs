using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044_generic_constraints
{
    class Program
    {
        static void Main(string[] args)
        {
            Pantry<Food> foodPantry = new Pantry<Food>(5);
            foodPantry.place(0, new Food("Chicken Noodle Soup"));
            foodPantry.place(4, new Food("Macaroni and Cheese"));
            foodPantry.eat(4);

            Console.WriteLine();

            Pantry<Ingredient> ingredientPantry = new Pantry<Ingredient>(3);
            ingredientPantry.place(0, new Ingredient("Pancake Mix"));
            ingredientPantry.place(1, new Ingredient("Baking Soda"));
            ingredientPantry.place(2, new Ingredient("Vinegar"));
            ingredientPantry.eatAll();

            Console.ReadKey();
        }
    }
}
