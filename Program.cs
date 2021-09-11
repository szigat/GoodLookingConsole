using System;
using Spectre.Console;

namespace GoodLookingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // AnsiConsole.Render(
            //     new FigletText("Hello world")
            //     .LeftAligned()
            //     .Color(Color.Red));
            // Console.WriteLine();

            AnsiConsole.MarkupLine("[underline red]Hello[/] Installer!");

            Environment selectedEnvironment = AnsiConsole.Prompt(
                    new SelectionPrompt<Environment>()
                    .UseConverter(e => e.Name)
                    .Title("Choose an [green]environment[/]?")
                    .PageSize(5)
                    .MoreChoicesText("[grey](Move up and down to reveal more environment)[/]")
                    .AddChoices<Environment>(Environment.GetEnvironments())
                );

            HandleEnvironment(selectedEnvironment);

            // var table = new Table();

            // table.AddColumn(new TableColumn("Id").Centered());
            // table.AddColumn(new TableColumn("Name").Centered());
            // table.AddColumn(new TableColumn("Status").Centered());


            // table.AddRow("1", "Alpha", "Enabled");
            // table.AddRow("2", "Beta", "Enabled");
            // table.AddRow("3", "Gamma", "Enabled");

            // AnsiConsole.Render(table);
        }

        private static void HandleEnvironment(Environment environment)
        {
            Console.WriteLine($"Selected env id:{environment.Id} name: {environment.Name}");
        }
    }
}
