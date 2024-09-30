using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeOrganizer
{
    internal class Recipe
    {
        int id;
        String name;
        ArrayList ingredients;

        public Recipe(int id, String name, ArrayList ingredients)
        {
            this.id = id;
            this.name = name;
            this.ingredients = ingredients;
        }

        public int getID()
        {
            return id;
        }

        public String getName()
        {
            return name;
        }

        public ArrayList getIngredients()
        {
            return ingredients;
        }


    }
}
