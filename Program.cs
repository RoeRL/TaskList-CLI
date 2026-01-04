// See https://aka.ms/new-console-template for more information
using System;
using Spectre.Console;
using TaskList.Services;

namespace TaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // Create an instance of the other class
            TaskService TS = new TaskService();
            var welcomeFiglet = new FigletText("Welcome To Task CLI")
                {
                    Justification = Justify.Center
                }
                .Color(Color.Blue);
            AnsiConsole.Write(welcomeFiglet);
            
            var features = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Choose your [green]Option[/]")
                    .AddChoices("Read Task", "Add Task", "Update", "Delete"));
            AnsiConsole.MarkupLine($"You Selected: [green]{features}[/]");
        }
    }
}

