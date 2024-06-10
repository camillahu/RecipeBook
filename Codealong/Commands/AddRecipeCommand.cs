﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codealong.Commands.Commands;

internal class AddRecipeCommand : ICommand
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
        Console.WriteLine($"{Option}. {Label}");
    }

    public void ShowOptions()
    {
        
    }
}