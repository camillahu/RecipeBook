using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Codealong.Commands.Commands;

namespace Codealong.Commands
{
     internal class Methods 
    {
         protected string Ask(string question = "What would you like to do?")
        {
            Console.Write(question + " ");
            return Console.ReadLine();
        }

        protected int AskForInt(string input)
        {   
            return Convert.ToInt32(input);
        }

        public ICommand? FindCommand(int input, ICommand[] commands) //skjønner ikke ?
        {
            ICommand? cmd = commands.FirstOrDefault(c => c.Option == input);
            return cmd;
        }


        protected void PrintAllCategories()
        {
            int i = 1;
            foreach (var category in Enum.GetValues(typeof(EnumCategories)))
            {
                Console.WriteLine($"{i}. {category}");
                i++;
            }
        }

        //protected void DrawOptionsLoop(List<string>Options)
        //{
        //    for (var i = 0; i < Options.Count; i++)
        //    {
        //        Console.WriteLine($"{i + 1}. {Options[i]}");
        //    }
        //}


        //int AskForInt(string input)
        //{
        //    int output = 0;
        //    bool success = int.TryParse(input, out int result);

        //    if (success) output = result;

        //    return output;
        //}


    }
}
