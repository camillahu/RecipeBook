using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codealong.Commands.Commands;

internal interface ICommand
{
    int Option { get; }
    string Label { get; }
    ICommand[] Commands { get; }
    void Run();
    void PrintMenuName();
    void ShowOptions();
}