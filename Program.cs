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
        }
    }
}
