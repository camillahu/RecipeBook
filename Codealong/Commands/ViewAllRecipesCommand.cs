using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codealong.Commands.Commands;
using Codealong.Commands.RecipeListCommands;

namespace Codealong.Commands
{
    internal class ViewAllRecipesCommand : ICommand
    {
        public int Option => 1;
        public string Label => "View all recipes";

        public ICommand[] Commands => new ICommand[]
        {
            new ViewRecipeCommand(),
            new FilterRecipeCommand(),
            new MainMenu(),
        };


        private List<Recipe> AllRecipes = new List<Recipe>()
        {
          new Pizza("Vegetar Pizza", 2),
          new Pizza("Pepperoni Pizza", 1),
        };

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("All recipes:");
            PrintList();
            ShowOptions();
        }

        public void PrintMenuName()
        {
            Console.WriteLine($"{Option}. {Label}");
        }

        public void ShowOptions()
        {
            foreach (var command in Commands)
            {
                command.PrintMenuName();
            }
        }

        public void PrintList()
        {
            foreach (Recipe recipe in AllRecipes)
            {
                recipe.PrintShortRecipeInfo();
            }
        }
    }
}
