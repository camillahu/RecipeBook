using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codealong.Commands.Commands;

namespace Codealong.Commands.RecipeListCommands
{
    internal class FilterRecipeCommand : ICommand
    {
        public int Option { get; }
        public string Label { get; }
        public ICommand[] Commands { get; }
        public void Run()
        {
            throw new NotImplementedException();
        }

        public void PrintMenuName()
        {
            Console.WriteLine($"{Option}. {Label}");
        }

        public void ShowOptions()
        {
            throw new NotImplementedException();
        }
    }
}
