using System;
using Spectre.Console;

namespace GoodLookingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            AnsiConsole.Markup("[underline red]Hello[/] World!");

            Console.WriteLine();

            AnsiConsole.Render(
                new FigletText("Hello world")
                .LeftAligned()
                .Color(Color.Red));

            var selectedItem = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title<string>("What's your [green]favorite fruit[/]?")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
                    .AddChoices<string>(new[] {
                        "", "Avocado", 
                        "Banana", "Blackcurrant", "Blueberry",
                        "Cherry", "Cloudberry", "Cocunut",
                    })
                    );

            var table = new Table();

            table.AddColumn(new TableColumn("Id").Centered());
            table.AddColumn(new TableColumn("Name").Centered());
            table.AddColumn(new TableColumn("Status").Centered());


            table.AddRow("1", "Alpha", "Enabled");
            table.AddRow("2", "Beta", "Enabled");
            table.AddRow("3", "Gamma", "Enabled");

            AnsiConsole.Render(table);
        }
    }
}
