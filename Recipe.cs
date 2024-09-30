using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeOrganizer
{
    public class Recipe
    {
        int id;
        String name;
        String ingredients;

        public Recipe(int id, String name, String ingredients)
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

        public String getIngredients()
        {
            return ingredients;
        }


    }
}
