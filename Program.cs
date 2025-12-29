// See https://aka.ms/new-console-template for more information
using ConsoleTables;
using System;
using Spectre.Console;
using TaskList.Services;

namespace TaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the other class
            TaskService TS = new TaskService();
            
            // Call its public method
            TS.AddTask();
        }
    }
}

