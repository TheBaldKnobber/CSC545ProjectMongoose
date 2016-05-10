using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GroupProject545
{
    class Program
    {

        static void Main(string[] args)
        {
            //Recipe recipe = new Recipe();
            //recipe.rec_name = "David's food";
            //recipe.instructions = "David's instructions for said food item";
            //recipe.ingredients_post.Add(1); //errors here
            //recipe.category = "entree";
            //recipe.CreateRecipe();
            //var recipe_i_want = recipe.GetARecipeName("David's food");
            //foreach(var recipes in recipe_i_want.recipes){
            //    Console.WriteLine(recipe.rec_name);
            //}

            //Fridge fridge = new Fridge();
            //fridge.GetAllFridgeItems();

            Recipe recipe = new Recipe();
            recipe.GetAllRecipes();
            recipe.DeleteARecipeID(1);
            recipe.GetAllRecipes();
        }
    }

}
