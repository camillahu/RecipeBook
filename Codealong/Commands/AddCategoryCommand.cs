using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codealong.Commands.Commands;

internal class AddCategoryCommand : ICommand
{
    public int Option { get; }
    public string Label { get; }
    public ICommand[] Commands { get; }
    public List<string> Options { get; }

    public void Run()
    {
        throw new NotImplementedException();
    }

    public void PrintMenuName()
    {
        throw new NotImplementedException();
    }

    public void ShowOptions()
    {
        throw new NotImplementedException();
    }

}