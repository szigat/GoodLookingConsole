using System;
using System.Linq;
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

            var table = new Table();

            table.AddColumn(new TableColumn("Id").Centered());
            table.AddColumn(new TableColumn("Name").LeftAligned());
            table.AddColumn(new TableColumn("Status").Centered());

            Environment.GetEnvironments().ToList()
            .ForEach(e =>
            {
                table.AddRow(e.Id.ToString(), e.Name, e.Status.ToString());
            });

            AnsiConsole.Render(table);

            try
            {
                HandleEnvironment(null);
            }
            catch(Exception ex)
            {
                Console.WriteLine("------ ex.ToString()");
                Console.WriteLine(ex.ToString());
                Console.WriteLine("------ Default");
                AnsiConsole.WriteException(ex);
                Console.WriteLine("------ ShortenEverything");
                AnsiConsole.WriteException(ex,ExceptionFormats.ShortenEverything);
                Console.WriteLine("------ ShortenMethods");
                AnsiConsole.WriteException(ex,ExceptionFormats.ShortenMethods);
                Console.WriteLine("------ ShortenPaths");
                AnsiConsole.WriteException(ex,ExceptionFormats.ShortenPaths);
                Console.WriteLine("------ ShortenTypes");
                AnsiConsole.WriteException(ex,ExceptionFormats.ShortenTypes);
                Console.WriteLine("------ ShowLinks");
                AnsiConsole.WriteException(ex,ExceptionFormats.ShowLinks);

            }
        }

        private static void HandleEnvironment(Environment environment)
        {
            if (environment is null)
            {
                throw new ArgumentNullException(nameof(environment));
            }

            Console.WriteLine($"Selected env id:{environment.Id} name: {environment.Name}");
        }
    }
}
