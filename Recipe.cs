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
        String name;
        String ingredients;

        public Recipe(String name, String ingredients)
        {
            this.name = name;
            this.ingredients = ingredients;
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
