using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codealong.Commands.Commands;

namespace Codealong.Commands
{
    internal class ViewAllRecipesCommand : ICommand
    {
        public int Option => 1;
        public string Label => "View all recipes";
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
