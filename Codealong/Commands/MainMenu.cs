using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Codealong.Commands.Commands;

namespace Codealong.Commands
{
    internal class MainMenu : Methods
    {
        ICommand[] Commands =
        [
            new ViewAllRecipesCommand()
        ];

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Welcome to your recipe book!");
            ShowOptions();
            var input = AskForInt(Ask());
            ICommand cmd = FindCommand(input, Commands);
            cmd.Run();
        }


        public void ShowOptions()
        {
            foreach (var command in Commands)
            {
                command.PrintMenuName();
            }
        }


        //public void ShowOptions()
        //{
        //    for (var i = 0; i < commands.Length; i++)
        //    {
        //        Console.WriteLine($"{i + 1}. {commands[i]}");
        //    }
        //}

    }
}
